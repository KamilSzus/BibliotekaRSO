using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Author
    {
        public string Name
        {
            get;
            set;
        }
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
