using OnlineShop.Domain.Contracts.People;
using OnlineShop.Infrastructure.DataAccess.Common;
using OnlineShop.Domain.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.DataAccess.People
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(OnlineShopContext dbcontext) : base(dbcontext)
        {
        }
    }
}
