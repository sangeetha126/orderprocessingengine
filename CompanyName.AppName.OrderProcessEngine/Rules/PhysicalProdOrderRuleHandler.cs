using CompanyName.AppName.OrderProcessEngine.Actions;
using CompanyName.AppName.OrderProcessEngine.Orders;
using CompanyName.AppName.OrderProcessEngine.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Rules
{
    public class PhysicalProdOrderRuleHandler : OrderRuleHandler<IOrder>
    {   
        public override void Execute(IOrder order)
        {
            if (IsMatching(order))
            {
                IAction actionPackage = new GeneratePackingSlip();
                actionPackage.ExecuteAction(order);
                IAction actionCommision = new GenerateCommissionPay();
                actionCommision.ExecuteAction(order);
            }
            base.Execute(order);
        }

        public override bool IsMatching(IOrder order)
        {
            if (order.GetProduct().GetProductType() == ProductType.Physical)
                return true;
            else
                return false;

        }
        
    }
}
