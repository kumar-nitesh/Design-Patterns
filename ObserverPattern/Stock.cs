using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class Stock : Subject
    {
        private string _symbol;

        public string Symbol
        {
            get { return _symbol; }            
        }


        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    NotifyObservers();
                }

            }
        }

        private List<Observer> _Observers = new List<Observer>();

        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        #region Subject Members

        public void AddObserver(Observer observer)
        {
            _Observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _Observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(Observer observer in _Observers)
            {
                observer.Update(this);
            }

            Console.WriteLine("");
        }

        #endregion
    }
}
