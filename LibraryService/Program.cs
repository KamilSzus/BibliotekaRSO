using ServiceReference1;
using System;
using System.ServiceModel;

namespace LibraryService
{
    internal class Program
    {
        static void Main()
        {
            LbraryOperationsClient client = new LbraryOperationsClient();

            for (; ; )
            {
                try
                {
                    Console.WriteLine("type '1' for GetBookById or type '2' GetBookByTitle");
                    int requestType = int.Parse(Console.ReadLine());

                    if (requestType == 1)
                    {
                        Console.WriteLine("give id of book");
                        int bookId = int.Parse(Console.ReadLine());
                        Console.WriteLine(client.dumpAsync(client.GetBookByIdAsync(bookId).Result).Result);
                    }
                    else if (requestType == 2)
                    {
                        Console.WriteLine("give title of book");
                        string bookTitle = Console.ReadLine();
                        for (int i = 0; i < client.GetBookByTitleAsync(bookTitle).Result.Length; i++)
                        {
                            Console.WriteLine(client.dumpAsync(client.GetBookByTitleAsync(bookTitle).Result[i]).Result);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception fault)
                {
                    Console.WriteLine(fault.Message);
                }
            }
            Console.ReadKey();

            // Zawsze zamykaj klienta.
            client.Close();
        }
    }
}
