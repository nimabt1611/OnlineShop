using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShop.Domain.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.DataAccess.People
{
    public class PersonCategoryConfig : IEntityTypeConfiguration<PersonCategory>
    {
        public void Configure(EntityTypeBuilder<PersonCategory> builder)
        {
            
        }
    }
}
