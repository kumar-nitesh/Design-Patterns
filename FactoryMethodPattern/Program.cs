using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// Define an interface for creating an object, but let subclasses decide which class to instantiate. 
    /// Factory Method lets a class defer instantiation to subclasses.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            PageMethod[] factoryMethod = new PageMethod[2];

            factoryMethod[0] = new ProfessionalResume();
            factoryMethod[1] = new FreshersResume();

            foreach(PageMethod method in factoryMethod)
            {
                Console.WriteLine("\n" + method.GetType().Name + "---");
                foreach(PageFactory factory in method.Pages)
                {
                    Console.WriteLine(" " + factory.GetType().Name);
                }
            }
        }
    }
}
