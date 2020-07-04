using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CoffeeFactory
    {
        public ICoffee CreateCoffee(string cafeName)
        {
            if (cafeName == "Starbucks")
            {
                return new Starbucks();
            }
            else if (cafeName == "KahveDunyasi")
            {
                return new KahveDunyasi();
            }
            else
                return null;
        }
    }

}
