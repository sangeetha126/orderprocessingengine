using CompanyName.AppName.OrderProcessEngine.Actions;
using CompanyName.AppName.OrderProcessEngine.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Orders
{
    public interface IOrder
    {
        IProduct GetProduct();
        void SetOrderActionStatus(ActionID actionID,bool actionResult);
    }
}
