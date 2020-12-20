using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.AppName.OrderProcessEngine.Rules
{
    public abstract class OrderRuleHandler<TOrder>
    {
        private OrderRuleHandler<TOrder> _nextOrderRuleHandler;

        public OrderRuleHandler<TOrder> SetNextRule(OrderRuleHandler<TOrder> handler)
        {
            _nextOrderRuleHandler = handler;
            return _nextOrderRuleHandler;
        }

        public virtual void Execute(TOrder order)
        {
            if(_nextOrderRuleHandler != null)
            _nextOrderRuleHandler.Execute(order);
        }

        public virtual bool IsMatching(TOrder order) { return true; }
        
     
    }
}

