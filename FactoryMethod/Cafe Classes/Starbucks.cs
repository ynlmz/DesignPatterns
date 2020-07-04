using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Starbucks : ICoffee
    {
        public void MakeCoffee()
        {
            Console.WriteLine("Starbucks'ta kahveniz hazırlanıyor.");
        }
    }
}
