using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Product
{
    public interface IProduct
    {
        ProductType GetProductType();
    }

    public enum ProductType
    {
        Physical,
        NonPhysical
    }
    public enum MembershipType
    {
        New,
        Upgrade
    }
}
