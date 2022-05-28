using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

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
            if(books.FindAll(x => x.Title.Contains(title)) == null)
            {
                throw new FaultException<ErrorHandler>(new ErrorHandler("title not found"), new FaultReason("Invalid TITLE"));
            }
            else
            {
                return books.FindAll(x => x.Title.Contains(title));
            }
        }
    }
}
