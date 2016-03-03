using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using EvalServiceLibrary;
using System.ServiceModel.Description;
namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(EvalService));
            host.AddServiceEndpoint(typeof(IEvalService), new BasicHttpBinding(), "http://localhost:8080/evals/basic");
            host.AddServiceEndpoint(typeof(IEvalService), new WSHttpBinding(), "http://localhost:8080/evals/ws");
            host.AddServiceEndpoint(typeof(IEvalService), new NetTcpBinding(), "net.tcp://localhost:8082/evals");

            try
            {
                host.Open();
                PrintService(host);
                Console.ReadLine();
                host.Close();
            }
            catch(Exception)
            {
                host.Close();
            }
        }
        static void PrintService(ServiceHost host)
        {
            Console.WriteLine("{0} is up and running with these endpoints", host.Description.ServiceType);
            foreach (ServiceEndpoint se in host.Description.Endpoints)
                Console.WriteLine(se.Address);
        }
    }
}
