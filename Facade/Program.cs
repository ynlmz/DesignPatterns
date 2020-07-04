using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade fcd = new Facade();

            List<ProductinBasket> products = new List<ProductinBasket>
            {
                new ProductinBasket{ Id=3, ProductName="Telefon",   Pieces=1, Price=500},
                new ProductinBasket{ Id=5, ProductName="Mp3Player", Pieces=2, Price=20},
                new ProductinBasket{ Id=8, ProductName="Kalem",     Pieces=5, Price=3},
                new ProductinBasket{ Id=2, ProductName="Mouse",     Pieces=1, Price=80},
                new ProductinBasket{ Id=7, ProductName="SSD",       Pieces=2, Price=300}
            };

            fcd.CreateOrder("Ahmet", "Yılmaz", products);
            Console.ReadKey();
        }
    }
}
