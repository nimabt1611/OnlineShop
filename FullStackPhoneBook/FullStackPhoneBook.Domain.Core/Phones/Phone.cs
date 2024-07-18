using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackPhoneBook.Domain.Core.Phones
{
	public class Phone : BaseEntity
	{
        public int PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
