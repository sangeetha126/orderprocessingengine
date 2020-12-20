using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.OrderProcessEngine.Product
{
    public class Video : IProduct
    {
        public ProductType GetProductType()
        {
            return ProductType.NonPhysical;
        }
    }
}
