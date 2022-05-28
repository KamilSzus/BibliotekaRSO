using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [DataContract]
    public class ErrorHandler
    {
        public ErrorHandler(string message)
        {
            Message = message;
        }

        public string Message { get; set; } 
    }
}
