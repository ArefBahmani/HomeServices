using AppDomainCore.UserEntite.Entiteies;
using AppDomainCore.UserEntite.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Db.Sql.Ef.Configs.UserEntite
{
    public class CustomerConfigs : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
           builder.HasKey(x=>x.Id);
            builder.HasMany(r => r.Requests).WithOne(r => r.Customer);
            builder.HasMany(c => c.Comments).WithOne(c => c.Customer);
            builder.Property(a => a.Balance)
          .HasPrecision(18, 4);



            builder.HasData(new Customer
            {
                Id = 4,
                FirstName = "حسین ",
                LastName = "مصلحی",
                PhoneNumber = "+989122152580",
                Gender = GenderEnum.Man,
                CreatAt = new DateTime(2024, 1, 1, 12, 0, 0)
            },
            new Customer
            {
                Id = 5,
                FirstName = "سارا ",
                LastName = "روشنی",
                PhoneNumber = "+989124488954",
                Gender = GenderEnum.Women,
                CreatAt = new DateTime(2024, 1, 1, 12, 0, 0)
            }


            );
        }
    }
}
