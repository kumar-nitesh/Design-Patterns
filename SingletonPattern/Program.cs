using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// Ensure a class has only one instance and provide a global point of access to it.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer obj1 = LoadBalancer.GetInstance();
            LoadBalancer obj2 = LoadBalancer.GetInstance();

            // Confirm these are the same instance
            if (obj1 == obj2)
            {
                Console.WriteLine("Same instance\n");
            }

            LoadBalancer balancer = LoadBalancer.GetInstance();
            
            for(int i=0;i<4;i++)
            {
                string serverName = balancer.NextServer.Name;
                Console.WriteLine("Dispatch request to: " + serverName);
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
