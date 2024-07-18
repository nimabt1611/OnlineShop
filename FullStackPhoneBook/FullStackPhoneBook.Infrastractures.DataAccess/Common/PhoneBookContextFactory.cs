using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackPhoneBook.Infrastractures.DataAccess.Common
{
	public class PhoneBookContextFactory : IDesignTimeDbContextFactory<PhoneBookContext>
	{
		public PhoneBookContext CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<PhoneBookContext>();
			builder.UseSqlServer("server=.;Initial Catalog=PhoneBookDb;User Id=sa;password=Nima1611;Trusted_Connection=True");

			return new PhoneBookContext(builder.Options);

		}
	}
}
