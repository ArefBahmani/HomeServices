using AppDomainCore.CategoryEntitie.Entite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Db.Sql.Ef.Configs.CategoryEntite
{
    public class CategoryConfigs : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           builder.HasKey(x => x.Id);
            builder.HasMany(x => x.SubCategories)
                .WithOne(x => x.Category);
            builder.HasData(new Category
            {
                Id = 1,
                Name = "تمیزکاری",
                CreateDate = new DateTime(2024, 1, 1, 12, 0, 0),
                
               
            },
            new Category
            {
                Id = 2,
                Name = "ساختمان",
                CreateDate = new DateTime(2024, 1, 1, 12, 0, 0)
            },
            new Category
            {
                Id = 3,
                Name = "تعمیرات اشیا",
                CreateDate = new DateTime(2024, 1, 1, 12, 0, 0)
                
            },
            new Category
            {
                Id = 4,
                Name = "اسباب کشی و حمل بار",
                CreateDate = new DateTime(2024, 1, 1, 12, 0, 0)
            },
            new Category
            {
                Id = 5,
                Name = "خودرو",
                CreateDate = new DateTime(2024, 1, 1, 12, 0, 0)
            },
            new Category
            {
                Id = 6,
                Name = "سلامت و زیبایی",
                CreateDate = new DateTime(2024, 1, 1, 12, 0, 0)
            },
            new Category
            {
                Id = 7,
                Name = "سایر",
                CreateDate = new DateTime(2024, 1, 1, 12, 0, 0)
            },
            new Category
            {
                Id = 8,
                Name = "سازمان ها و مجتمع ها",
                CreateDate = new DateTime(2024, 1, 1, 12, 0, 0)
            });
        }
    }
}
