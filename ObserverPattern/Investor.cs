using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Investor : Observer
    {
        private string _name;
        private Stock _stock;

        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public Investor(string name)
        {
            this._name = name;
        }

        #region Observer Members

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " + "change to {2:C}", _name, stock.Symbol, stock.Price);            
        }

        #endregion
    }
}
