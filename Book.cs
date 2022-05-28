using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
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
        public List<Author> Authors
        {
            get;
            set;
        }
        public Book(int bookId,string title, List<Author> authors)
        {
            BookId = bookId;
            Title = title;
            Authors = authors;
        }
    }
}
