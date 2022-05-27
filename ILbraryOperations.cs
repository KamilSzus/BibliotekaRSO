using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    [ServiceContract]
    internal interface ILbraryOperations
    {
        [OperationContract]
        Book GetBookById(int id);

        [OperationContract]
        Book GetBookByTitle(string title);
    }
}
