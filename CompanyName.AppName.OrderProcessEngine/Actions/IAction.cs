using CompanyName.AppName.OrderProcessEngine.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Actions
{
    public interface IAction
    {
        void  ExecuteAction(IOrder order);


    }
    public enum ActionID
    {
        ActivateMembership,
        AddFreeVideo,
        DuplicatePackingSlip,
        Email,
        GenerateCommissionPay,
        GeneratePackingSlip,
        UpgradeMembership

    }
}
