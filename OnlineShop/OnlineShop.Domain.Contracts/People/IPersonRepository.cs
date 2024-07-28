using OnlineShop.Domain.Contracts.Common;
using OnlineShop.Domain.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Contracts.People
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
    }
}
