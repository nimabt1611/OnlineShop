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
	internal class PersonTagConfig : IEntityTypeConfiguration<PersonTag>
	{
		public void Configure(EntityTypeBuilder<PersonTag> builder)
		{
			
		}
	}
}
