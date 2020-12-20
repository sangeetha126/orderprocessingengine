using CompanyName.AppName.OrderProcessEngine.Actions;
using CompanyName.AppName.OrderProcessEngine.Orders;
using CompanyName.AppName.OrderProcessEngine.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Rules
{
    public class VideoOrderRuleHandler : OrderRuleHandler<IOrder>
    {
        public override void Execute(IOrder order)
        {
            if (IsMatching(order))
            {
                var action = new AddFreeVideo();
                action.ExecuteAction(order);
            }
            base.Execute(order);
        }

        public override bool IsMatching(IOrder order)
        {
            if (order.GetProduct() is Video)
                return true;
            else
                return false;

        }
    }
}
