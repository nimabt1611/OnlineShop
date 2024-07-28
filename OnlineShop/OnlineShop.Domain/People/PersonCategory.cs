using OnlineShop.Domain.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.People
{
	public class PersonCategory : BaseEntity
	{
        public int PersonId { get; set; }
        public int CategoryId { get; set; }
        public Person person { get; set; }
        public Category category { get; set; }
    }
}
