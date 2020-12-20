using CompanyName.AppName.OrderProcessEngine.Actions;
using CompanyName.AppName.OrderProcessEngine.Orders;
using CompanyName.AppName.OrderProcessEngine.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Rules
{
     
      public class MembershipOrderRuleHandler : OrderRuleHandler<IOrder>
    {
        public override void Execute(IOrder order)
        {
            if (IsMatching(order))
            {
                IAction action;
                var membership =(Membership)order.GetProduct();
                if (membership.MembershipType == MembershipType.New)
                {
                    action = new ActivateMembership();
                    action.ExecuteAction(order);
                }
                else if (membership.MembershipType == MembershipType.Upgrade)
                {
                    action = new UpgradeMembership();
                    action.ExecuteAction(order);
                }

                action = new Email();
                action.ExecuteAction(order);

            }
            base.Execute(order);
        }

        public override bool IsMatching(IOrder order)
        {
            if (order.GetProduct() is Membership)
                return true;
            else
                return false;

        }
    }
}
