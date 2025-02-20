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
    public class AdminConfigs : IEntityTypeConfiguration<Admin>
    {

        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(a => a.Balance)
          .HasPrecision(18, 4);
         

            builder.HasData(new Admin
            {
                Id = 1,
                FirstName = "عارف",
                LastName = "بهمنی نژاد",
                Balance = 1000000000,
                Gender = GenderEnum.Man,
                ApplicationUserId = 1,
            });
        }
    }
}
