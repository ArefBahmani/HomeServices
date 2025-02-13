using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.RequestEntite.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Db.Sql.Ef.Configs.RequestEntite
{
    public class RequestConfigs : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(c => c.Customer)
                .WithMany(r => r.Requests).HasForeignKey(x=>x.CustomerId).OnDelete(DeleteBehavior.NoAction);

            builder
        .Property(r => r.Price)
         .HasPrecision(18, 4);

            builder.HasOne(s => s.CategoryServices)
                .WithMany(r => r.Requests).HasForeignKey(x=>x.CategoryServiceId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(new Request
            {
                Id = 1,
                CustomerId = 4,
                ExpertId = 2,
                CustomerRequest = new DateTime(2024, 1, 1, 12, 0, 0),
                DateRequest = new DateTime(2024, 1, 4, 12, 0, 0),
                Description = "نظافت تمامی اتاق ها و سرویس های بهداشتی",
                Location = LocationEnum.ResidentialApartment,
                Status = StatusEnum.Confirmed,
                Titel = "نظافت",
                CategoryServiceId = 9,
                Price = 500000
            });
        }
    }
}
