using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Biblioteka
{

    public class Library : ILbraryOperations
    {
        [DataMember]
        List<Book> books = new List<Book>()
        {
            new Book(1,"Władca Pierścieni",new List<Author> {new Author("John Ronald Reuel","Tolkien")}),
            new Book(2,"Gra o tron",new List<Author> {new Author("George Raymond Richard","Martin ")}),
            new Book(3,"Gra",new List<Author> {new Author("George Raymond Richard","Martin "),new Author("Brian", "McClellan") }),
            new Book(4,"Obietnica Krwi",new List<Author> {new Author("Brian","McClellan") })
        };

        public string dump(Book book)
        {
            string author = "";
            foreach (Author temp in book.Authors)
            {
                author += temp.Name + " " + temp.Surname + "\n";
            }

            return book.Title + "\nAuthors:\n" + author;
        }

        public List<Book> GetBookByAuthor(string author)
        {
            List<Book> filteredBooks = books.FindAll(book =>
            {
                Boolean authorBool = book.Authors.FindAll(author1 =>
                {
                    Boolean nameBool = author1.Name.Contains(author);
                    Boolean surnameBool = author1.Surname.Contains(author);
                    return nameBool || surnameBool;
                }).Count > 0;
                return authorBool;
                });

            if(filteredBooks.Count < 0)
            {
                throw new FaultException<ErrorHandler>(new ErrorHandler("author not found"), new FaultReason("Invalid AUTHOR"));
            }

            return filteredBooks;
        }

        public Book GetBookById(int id)
        {
            if (books.FirstOrDefault(x => x.BookId == id) == null)
            {
                throw new FaultException<ErrorHandler>(new ErrorHandler("id not found"), new FaultReason("Invalid ID"));
            }
            else
            {
                return books.FirstOrDefault(x => x.BookId == id);
            }
        }

        public List<Book> GetBookByTitle(string title)
        {

            List<Book> bookList = books.FindAll(book =>
            {
                Boolean titleBool = book.Title.Contains(title);
                Boolean authorBool = book.Authors.FindAll(author =>
                {
                    Boolean nameBool = author.Name.Contains(title);
                    Boolean surnameBool = author.Surname.Contains(title);
                    return nameBool || surnameBool;
                }).Count > 0;
                return titleBool || authorBool;
            });

            if (bookList.Count() == 0) {
                throw new FaultException<ErrorHandler>(new ErrorHandler("title not found"), new FaultReason("Invalid TITLE"));
            }

            return bookList;
        }

        public List<Book> GetBooksWithMultiplyAuthor()
        {
            return books.FindAll(book => book.Authors.Count > 1);
        }
    }
}
