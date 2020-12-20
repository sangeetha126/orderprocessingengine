﻿using CompanyName.AppName.OrderProcessEngine.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Actions
{
    public class ActivateMembership : IAction
    {
        
        public void ExecuteAction(IOrder order)
        {            
            order.SetOrderActionStatus(ActionID.ActivateMembership, true);       
                      
        }
    }
}
