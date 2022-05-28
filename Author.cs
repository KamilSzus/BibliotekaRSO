using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [DataContract]
    public class Author
    {
        [DataMember]
        public string Name
        {
            get;
            set;
        }
        [DataMember]
        public string Surname
        {
            get;
            set;
        }
        public Author(string name,string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}
