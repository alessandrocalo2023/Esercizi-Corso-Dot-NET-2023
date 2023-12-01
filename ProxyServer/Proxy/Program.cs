using System;
using System.Threading;

namespace Proxy
{
    internal class Program
    {
     

        static void Main(string[] args)
        {
            int _instanceCallNum=0;
            Console.WriteLine("--------------------");
            Console.WriteLine("- Proxy Server App -");
            Console.WriteLine("--------------------");
            Console.WriteLine("To start requests push any button ");
            Console.ReadKey();
            _instanceCallNum++;

            Console.WriteLine("Instance call number:" + _instanceCallNum++);
            Proxyton P0 = Proxyton.GetInstance();
            Console.WriteLine("Instance call number:" + _instanceCallNum++);
            Proxyton P1 = Proxyton.GetInstance();
            Console.WriteLine("Instance call number:" + _instanceCallNum++);
            Proxyton P2 = Proxyton.GetInstance();
         }
  
    }
}
