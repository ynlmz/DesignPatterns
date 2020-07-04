using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        private OrderDetails _orderDetails;
        private StockManager _stockManager;


        public Facade()
        {
            _orderDetails = new OrderDetails();
            _stockManager = new StockManager();
        }

        public void CreateOrder(string customerName, string customerSurname, List<ProductinBasket> products)
        {
            Customer customer = new Customer() { Name = customerName, Surname = customerSurname };
            _orderDetails.GetOrderDetails(customerName, customerSurname, products);
            _stockManager.UpdateStock(products);
        }

    }
}
