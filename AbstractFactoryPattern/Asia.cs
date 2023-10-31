using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Asia : AbstractFactoryContinent
    {
        public override ProductHerbivore CreateHerbivore()
        {
            return new Deer();
        }

        public override ProductCarnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
