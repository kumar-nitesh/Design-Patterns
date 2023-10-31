using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// Define a one-to-many dependency between objects so that when one object changes state, 
    /// all its dependents are notified and updated automatically.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IBM ibm = new IBM("IBM", 100.00);

            ibm.AddObserver(new Investor("Nilesh"));
            ibm.AddObserver(new Investor("Nitesh"));

            ibm.Price = 105;
            ibm.Price = 99;

            Console.ReadKey();
        }
    }
}
