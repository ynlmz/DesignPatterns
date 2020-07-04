using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class StockManager
    {
        public void UpdateStock(List<ProductinBasket> products)
        {
            products.ForEach(prd => Console.WriteLine($"{prd.Id} ID Numaralı Urunun Stogu  {prd.Pieces} Azaldi."));    
        }
    }
}
