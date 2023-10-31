using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// Define a family of algorithms, encapsulate each one, and make them interchangeable. 
    /// Strategy lets the algorithm vary independently from clients that use it.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            SortedList studRecords = new SortedList();

            studRecords.Add("Nitesh");
            studRecords.Add("Kumar");

            studRecords.SetSortStrategy(new QuickSort());
            studRecords.Sort();

            studRecords.SetSortStrategy(new MergeSort());
            studRecords.Sort();

            // Wait for user
            Console.ReadKey();
        }
    }
}
