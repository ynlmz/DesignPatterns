using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class KahveDunyasi : ICoffee
    {
        public void MakeCoffee()
        {
            Console.WriteLine("KahveDünyası'nda kahveniz hazırlanıyor.");
        }
    }

}
