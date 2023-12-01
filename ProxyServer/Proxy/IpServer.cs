using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
  public class IpServer
    {
        int IpNet;
        int IpSubNet;
        int IpLocalNet;
        int IpLocalHost;
        

        string IpAddress; // ip format 000.000.000.000
        // Random funtion to generate server ip address
        public IpServer() {
        //costruttore di IpServer
        }
        public string IpRandom() {
            Random random= new Random();
            IpNet= random.Next(1,254);
            IpSubNet = random.Next(1, 254);
            IpLocalNet = random.Next(1, 254);
            IpLocalHost = random.Next(1, 254);

            IpAddress = IpNet + "." + IpSubNet + "." + IpLocalNet +"." + IpLocalHost;
            //Console.ReadKey();
            return IpAddress;
        }
       
    }
}
