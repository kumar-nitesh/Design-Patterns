using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SortedList
    {
        private List<string> _list = new List<string>();

        private Strategy _strategy;

        public void SetSortStrategy(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _strategy.Sort(_list);

            foreach(string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
