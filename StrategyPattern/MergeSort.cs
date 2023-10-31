using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class MergeSort : Strategy
    {
        public override void Sort(List<string> list)
        {
            //list.Sort();
            Console.WriteLine("Merge Sort");
        }
    }
}
