using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Lion : ProductCarnivore
    {
        public override void Eat(ProductHerbivore herbivore)
        {
            // Eat Deer
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}
