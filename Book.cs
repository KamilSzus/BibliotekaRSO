using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookId
        {
            get;
            set;
        }
        [DataMember]
        public string Title
        {
            get;
            set;
        }
        [DataMember]
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
