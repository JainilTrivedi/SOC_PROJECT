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
            Uri tcp = new Uri("net.tcp://localhost:8010/UserService");
            Uri http = new Uri("http://localhost:8000/UserService");
            ServiceHost host = new ServiceHost(t, tcp, http);
            host.Open();
            Console.WriteLine("Published");
            Console.ReadLine();
            host.Close();
        }
    }
}
