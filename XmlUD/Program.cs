using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlUD
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlUDPReceiver xmlUdpReceiver = new XmlUDPReceiver(420);
            xmlUdpReceiver.start();
            Console.ReadLine();
        }
    }
}
