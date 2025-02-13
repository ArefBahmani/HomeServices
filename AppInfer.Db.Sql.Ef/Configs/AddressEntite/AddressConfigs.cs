using AppDomainCore.AddressEntitie.Entite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Db.Sql.Ef.Configs.AddressEntite
{
    public class AddressConfigs : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(c => c.Customer).WithOne(c => c.Address);
           

            builder.HasOne(c => c.Expert).WithOne(c => c.Address);

            builder.HasOne(c => c.Province).WithMany(c=>c.Addresses);

            builder.HasData(new Address
            {
                Id = 1,
                IsDeleted = false,
                CustomerId = 4,
                PostalCode = "4265998715",
                ProvinceId = 5,
                Street ="کرج_شاهین ویلا_قلم دهم غربی",
                CreatAt = new DateTime(2024, 1, 1, 12, 0, 0)

            });
            builder.HasData(new Address
            {
                Id = 2,
                IsDeleted = false,
                ExpertId = 3,
                PostalCode = "1007815639",
                ProvinceId = 1,
                Street = "اذربایجان شرقی_میدان امام حسین_کوچه مولوی",
                CreatAt = new DateTime(2024, 1, 1, 12, 0, 0)

            });

        }
    }
}
