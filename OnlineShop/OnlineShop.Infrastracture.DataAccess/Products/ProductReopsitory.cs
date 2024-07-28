using OnlineShop.Domain.Contracts.Products;
using OnlineShop.Infrastructure.DataAccess.Common;
using OnlineShop.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.DataAccess.Products
{
    public class ProductReopsitory : BaseRepository<Product>, IProductRepository
    {
        public ProductReopsitory(OnlineShopContext dbcontext) : base(dbcontext)
        {
        }
    }
}
