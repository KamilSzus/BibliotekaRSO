using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Library : ILbraryOperations
    {
        [DataMember]
        List<Book> books = new List<Book>()
        {
            new Book(1,"Władca Pierścieni",new Author("John Ronald Reuel","Tolkien")),
            new Book(2,"Gra o tron",new Author("George Raymond Richard","Martin ")),
            new Book(2,"Gra",new Author("George Raymond Richard","Martin ")),
            new Book(3,"Obietnica Krwi",new Author("Brian","McClellan"))
        };

        public Book GetBookById(int id)
        {
            return books.FirstOrDefault(x => x.BookId == id);
        }

        public List<Book> GetBookByTitle(string title)
        {
            return books.FindAll(x => x.Title.Contains(title));
        }
    }
}
