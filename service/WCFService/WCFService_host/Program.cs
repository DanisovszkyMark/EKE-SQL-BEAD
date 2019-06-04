using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService_host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFService.Service)))
            {
                host.Open();
                Console.WriteLine("Host has started @" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
