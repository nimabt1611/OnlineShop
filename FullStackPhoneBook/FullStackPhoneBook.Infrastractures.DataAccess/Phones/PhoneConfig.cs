using FullStackPhoneBook.Domain.Core.People;
using FullStackPhoneBook.Domain.Core.Phones;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackPhoneBook.Infrastractures.DataAccess.Phones
{
	internal class PhoneConfig : IEntityTypeConfiguration<Phone>
	{
		public void Configure(EntityTypeBuilder<Phone> builder)
		{
			builder.Property(c => c.PhoneNumber).HasMaxLength(20);
		}
	}
}

