using CompanyName.AppName.OrderProcessEngine.Actions;
using CompanyName.AppName.OrderProcessEngine.Orders;
using CompanyName.AppName.OrderProcessEngine.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Rules
{

    public class BookOrderRuleHandler : OrderRuleHandler<IOrder>
    {
        public override void Execute(IOrder order)
        {
            if (IsMatching(order))
            {
                IAction actionDuplicate = new DuplicatePackingSlip();
                actionDuplicate.ExecuteAction(order);
            }
            base.Execute(order);
        }

        public override bool IsMatching(IOrder order)
        {
            if (order.GetProduct() is Book)
                return true;
            else
                return false;

        }        
    }
}
