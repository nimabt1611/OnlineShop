using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FullStackPhoneBook.Domain.Core.Tags
{
	public class Tag : BaseEntity
	{
        public string Title { get; set; }
    }
}
