using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Proxyton : Server
    {
       string Ipserver1;
       string Ipserver2;
       string Ipserver3;
       string Ipserver4;
       

       static IpServer _IpServer = new IpServer();

        private static Proxyton instance =null;
            
        private Proxyton() { }

         public void ProxyIpCreate()
        {
          Ipserver1 = _IpServer.IpRandom();
         Ipserver2 = _IpServer.IpRandom();
       Ipserver3 = _IpServer.IpRandom();
        Ipserver4 = _IpServer.IpRandom();
            Console.WriteLine();
            Console.WriteLine("Ip Address Server1 :" + " " + Ipserver1);
            Console.WriteLine("Ip Address Server2 :" + " " + Ipserver2);
            Console.WriteLine("Ip Address Server3 :" + " " + Ipserver3);
            Console.WriteLine("Ip Address Server4 :" + " " + Ipserver4);
            Console.WriteLine();
        }
        public static Proxyton GetInstance()
        {
            
            
            if (instance == null)
            { instance = new Proxyton();
                instance.ProxyIpCreate();
             

            }
             return instance;
       }
        }   
           
        }
    

