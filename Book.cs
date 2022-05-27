using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Book
    {
        public int BookId
        {
            get;
            set;
        }
        public string Title
        {
            get;
            set;
        }
        public Author Author
        {
            get;
            set;
        }
        public Book(int bookId,string title, Author author)
        {
            BookId = bookId;
            Title = title;
            Author = author;
        }
    }
}
