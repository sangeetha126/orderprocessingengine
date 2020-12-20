using CompanyName.AppName.OrderProcessEngine.Actions;
using CompanyName.AppName.OrderProcessEngine.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Orders
{
    public class Order : IOrder
    {
        IProduct _product;
        public string OrderNo {get;set;}
        public List<Order> Orders { get; set; }
        public string OrderStatus { get; set; }
        public Dictionary<ActionID,bool> OrderAction { get; set; }


        public Order(IProduct product)
        {
            _product = product;
            OrderAction = new Dictionary<ActionID, bool>();
        }
        public IProduct GetProduct()
        {
            return _product;
        }

        public void SetOrderActionStatus( ActionID actionID, bool actionResult)
        {
            OrderAction.Add(actionID, actionResult);

        }      

      
    }
}
