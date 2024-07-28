using Microsoft.EntityFrameworkCore;
using OnlineShop.Infrastructure.DataAccess.Categorys;
using OnlineShop.Infrastructure.DataAccess.People;
using OnlineShop.Infrastructure.DataAccess.Products;
using OnlineShop.Domain.Categorys;
using OnlineShop.Domain.People;
using OnlineShop.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.DataAccess.Common
{
    public class OnlineShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PersonCategory> personCategories { get; set; }
       
        public OnlineShopContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new PersonCategoryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
