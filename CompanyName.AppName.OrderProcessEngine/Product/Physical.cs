using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyName.AppName.OrderProcessEngine.Product
{
    public class Physical : IProduct
    {
        public ProductType GetProductType()
        {
            return ProductType.Physical;
        }
    }
}
