using FullStackPhoneBook.Domain.Core.People;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackPhoneBook.Infrastractures.DataAccess.People
{
	internal class PersonConfig : IEntityTypeConfiguration<Person>
	{
		public void Configure(EntityTypeBuilder<Person> builder)
		{
			builder.Property(c => c.FirstName).HasMaxLength(50).IsRequired();
			builder.Property(c => c.LastName).HasMaxLength(50).IsRequired();
			builder.Property(c => c.Image).IsUnicode(false);
			builder.Property(c => c.Email).HasMaxLength(256).IsRequired();
			builder.Property(c => c.Address).HasMaxLength(500);
		}
	}
}
