using OnlineShop.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.People
{
	public class Person : BaseEntity
	{
        public  string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Address { get; set; }
        public  string Email{ get; set; }
        public List<Product> products { get; set; }
        public List<PersonCategory> Categories { get; set; }

    }
}
