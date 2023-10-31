using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    abstract class ProductCarnivore
    {
        public abstract void Eat(ProductHerbivore herbivore);
    }
}
