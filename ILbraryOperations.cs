using System.Collections.Generic;
using System.ServiceModel;

namespace Biblioteka
{
    [ServiceContract]
    internal interface ILbraryOperations
    {
        [OperationContract]
        [FaultContract(typeof(ErrorHandler))]
        Book GetBookById(int id);

        [OperationContract]
        [FaultContract(typeof(ErrorHandler))]
        List<Book> GetBookByTitle(string title);
        [OperationContract]
        string dump(Book book);
    }
}
