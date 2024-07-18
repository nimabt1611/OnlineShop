using FullStackPhoneBook.Domain.Core.People;
using FullStackPhoneBook.Domain.Core.Phones;
using FullStackPhoneBook.Domain.Core.Tags;
using FullStackPhoneBook.Infrastractures.DataAccess.People;
using FullStackPhoneBook.Infrastractures.DataAccess.Phones;
using FullStackPhoneBook.Infrastractures.DataAccess.Tags;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackPhoneBook.Infrastractures.DataAccess.Common
{
	public class PhoneBookContext : DbContext
	{
        public  DbSet<Tag> Tags { get; set; }
        public  DbSet<Person> People { get; set; }
        public  DbSet<PersonTag> PersonTags { get; set; }
        public  DbSet<Phone> Phones { get; set; }
        public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options)
		{

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new PersonConfig());
			modelBuilder.ApplyConfiguration(new PersonTagConfig());
			modelBuilder.ApplyConfiguration(new PhoneConfig());
			modelBuilder.ApplyConfiguration(new TagConfig());
			base.OnModelCreating(modelBuilder);
		}
	}
}
