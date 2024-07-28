using OnlineShop.Domain.Contracts.Categorys;
using OnlineShop.Infrastructure.DataAccess.Common;
using OnlineShop.Domain.Categorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.DataAccess.Categorys
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(OnlineShopContext dbcontext) : base(dbcontext)
        {
        }
    }
}
