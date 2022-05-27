using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [DataContractAttribute]
    public class Book
    {
        [DataMemberAttribute]
        public int BookId
        {
            get;
            set;
        }
        [DataMemberAttribute]
        public string Title
        {
            get;
            set;
        }
        [DataMemberAttribute]
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
