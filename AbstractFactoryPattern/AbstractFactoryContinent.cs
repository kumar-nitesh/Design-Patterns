using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    abstract class AbstractFactoryContinent
    {
        public abstract ProductHerbivore CreateHerbivore();

        public abstract ProductCarnivore CreateCarnivore();
    }
}
