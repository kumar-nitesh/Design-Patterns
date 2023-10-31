using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface Subject
    {
        void AddObserver(Observer o);

        void RemoveObserver(Observer o);

        void NotifyObservers();
    }
}
