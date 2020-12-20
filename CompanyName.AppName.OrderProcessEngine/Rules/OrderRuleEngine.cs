using CompanyName.AppName.OrderProcessEngine.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.AppName.OrderProcessEngine.Rules
{
    public class OrderRuleEngine
    {
        public void Execute(IOrder order)
        {
            var ruleChain = new PhysicalProdOrderRuleHandler();
            ruleChain.SetNextRule(new BookOrderRuleHandler())
            .SetNextRule(new MembershipOrderRuleHandler())
            .SetNextRule(new VideoOrderRuleHandler());
            ruleChain.Execute(order);
        }
    }
}
