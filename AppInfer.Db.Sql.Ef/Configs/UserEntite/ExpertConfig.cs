using AppDomainCore.AddressEntitie.Entite;
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
    public class ExpertConfig : IEntityTypeConfiguration<Expert>
    {
        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(a => a.Balance)
          .HasPrecision(18, 4);




            builder.HasMany(s => s.CategoryServices)
                .WithMany(e => e.Experts);
            builder.HasData(new Expert
            {
                Id = 2,
                FirstName = "جواد",
                LastName = "مرادی",
                PhoneNumber = "+981247859652",
                CreatAt = new DateTime(2024, 1, 1, 12, 0, 0),
                Balance = 10000,
                Gender = GenderEnum.Man,
                
            },
            new Expert
            {
                Id = 3,
                FirstName = "سعید",
                LastName = "لک",
                PhoneNumber = "+981247877652",
                CreatAt = new DateTime(2024, 1, 1, 12, 0, 0),
                Balance = 10000,
                Gender = GenderEnum.Man
            });

        }
    }
}
