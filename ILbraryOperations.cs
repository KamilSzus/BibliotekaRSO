using System.Collections.Generic;
using System.ServiceModel;

namespace Biblioteka
{
    [ServiceContract]
    internal interface ILbraryOperations
    {
        [OperationContract]
        Book GetBookById(int id);

        [OperationContract]
        List<Book> GetBookByTitle(string title);
    }
}
