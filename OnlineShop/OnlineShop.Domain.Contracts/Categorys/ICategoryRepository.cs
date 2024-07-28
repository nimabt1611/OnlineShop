using OnlineShop.Domain.Contracts.Common;
using OnlineShop.Domain.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Contracts.Categorys
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
    }
}
