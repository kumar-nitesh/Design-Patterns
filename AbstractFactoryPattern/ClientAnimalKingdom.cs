using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ClientAnimalKingdom
    {
        private ProductHerbivore _herbivore;
        private ProductCarnivore _carnivore;

        public ClientAnimalKingdom(AbstractFactoryContinent factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
