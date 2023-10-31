using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
	//Provide an interface for creating families of related or dependent objects without specifying their concrete classes.	
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactoryContinent continentAsia = new Asia();

            ClientAnimalKingdom kingdom = new ClientAnimalKingdom(continentAsia);

            kingdom.RunFoodChain();
        }
    }
}
