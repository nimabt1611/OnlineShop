using FullStackPhoneBook.Domain.Core.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackPhoneBook.Domain.Core.People
{
	public class PersonTag : BaseEntity
	{
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }


    }
}
