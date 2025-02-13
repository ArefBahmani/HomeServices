using AppDomainCore.SubCategoryEntite.Entite;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Db.Sql.Ef.Configs.SubCategoryEntite
{
    public class SubCategoryConfigs : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
           
            builder.HasMany(s => s.CategoryServices)
                .WithOne(s => s.SubCategory);

            builder.HasOne(c => c.Category)
                .WithMany(s => s.SubCategories);

            builder.HasData(new SubCategory { Id = 1, Name = "نظافت",CategoryId = 1 },
                new SubCategory { Id = 2, Name = "شستشولباس", CategoryId = 1 },
                new SubCategory { Id = 3, Name = "تعمیرات شیرالات", CategoryId = 2 },
                new SubCategory { Id = 4, Name = "مبایل", CategoryId = 3},
                new SubCategory { Id =5, Name = "لپ تاپ", CategoryId = 3 },
                new SubCategory { Id = 6, Name = "اسباب سنگین", CategoryId = 4 },
                new SubCategory { Id = 7, Name = "اسباب سبک", CategoryId = 4 },
                new SubCategory { Id = 8, Name = "تعمیرات خودرو خارجی", CategoryId = 5 },
                new SubCategory { Id = 9, Name = "  تعمیرات", CategoryId = 5 },
                new SubCategory { Id = 10, Name = "اصلاح برای اقایان", CategoryId = 6 },
                new SubCategory { Id = 11, Name = "اصلاح برای بانوان", CategoryId = 6 });
        }
    }
}
