using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.DataAccess.Common
{
    public class OnlineShopContextFactory : IDesignTimeDbContextFactory<OnlineShopContext>
    {
        public OnlineShopContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OnlineShopContext>();
            builder.UseSqlServer("Server=.;Database=OnlineShopDb;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            return new OnlineShopContext(builder.Options);
        }
    }
}
