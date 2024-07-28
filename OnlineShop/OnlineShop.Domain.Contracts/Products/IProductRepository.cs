using OnlineShop.Domain.Contracts.Common;
using OnlineShop.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Contracts.Products
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
}
