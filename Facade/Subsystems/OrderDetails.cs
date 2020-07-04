using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class OrderDetails
    {
        public void GetOrderDetails(string name,string surname,List<ProductinBasket> products)
        {
            Console.WriteLine(" Siparis Detaylari : \n");
            Console.WriteLine($"Alıcı : {name} {surname}");
            products.ForEach(ord => Console.WriteLine($"UrunID : {ord.Id}, Urun : {ord.ProductName} , Adet Sayisi : {ord.Pieces} , Fiyat : {ord.Price}"));
            var totalPrices = products.Sum(x => x.Price * x.Pieces);
            Console.WriteLine($"\nToplam Siparis Tutarı : {totalPrices}\n\n");
        }

    }
}
