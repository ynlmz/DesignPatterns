using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeFactory factory = new CoffeeFactory();
            ICoffee coffee = factory.CreateCoffee("KahveDunyasi");
            coffee.MakeCoffee();
            Console.Read();
        }
    }
}
