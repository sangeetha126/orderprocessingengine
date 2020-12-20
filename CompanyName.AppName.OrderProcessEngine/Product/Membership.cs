using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Product
{
    public class Membership : IProduct
    {
        public Membership(MembershipType membershipType)
        {
            MembershipType = membershipType;
        }
        public MembershipType MembershipType { get; set; }
        public ProductType GetProductType()
        {
            return ProductType.NonPhysical;
        }
    }
}
