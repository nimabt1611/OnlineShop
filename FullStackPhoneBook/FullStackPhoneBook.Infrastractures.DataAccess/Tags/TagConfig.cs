using FullStackPhoneBook.Domain.Core.Phones;
using FullStackPhoneBook.Domain.Core.Tags;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackPhoneBook.Infrastractures.DataAccess.Tags
{
	internal class TagConfig : IEntityTypeConfiguration<Tag>
	{
		public void Configure(EntityTypeBuilder<Tag> builder)
		{
			throw new NotImplementedException();
		}
	}
}

