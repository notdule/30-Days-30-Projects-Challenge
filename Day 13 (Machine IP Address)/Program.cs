using System;
using System.Net;
namespace Program
{
    class Program
    {
        static void Main()
        {
            // getting the Host Name.
            String strHostName = string.Empty; 
            strHostName = Dns.GetHostName();
            Console.WriteLine("Local Machine's Host Name: " + strHostName);
            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
            // Using Host Name,IP address is obtained.
            IPAddress[] addr = ipEntry.AddressList;
 
            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {1} : ",addr[i].ToString());
            }
            Console.ReadLine();
        }
    }
}
