using HomeAndUserLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace UserServiceHostConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(UserService);
            Type t1 = typeof(HomeService);
            //Uri tcp = new Uri("net.tcp://localhost:8010/UserService");

            Uri http = new Uri("http://localhost:8000/UserService");
            Uri http1 = new Uri("http://localhost:8000/HomeService");
            ServiceHost host = new ServiceHost(t, http);
            ServiceHost host2 = new ServiceHost(t1,  http1);
            host.Open();
            host2.Open();
            Console.WriteLine("Published");
            Console.ReadLine();
            host.Close();
            host2.Close();
        }
    }
}
