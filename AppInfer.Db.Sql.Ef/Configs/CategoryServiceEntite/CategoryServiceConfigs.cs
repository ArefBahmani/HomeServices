using AppDomainCore.CategoryEntitie.Entite;
using AppDomainCore.CategoryServiceEntitie.Entite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Db.Sql.Ef.Configs.CategoryServiceEntite
{
    public class CategoryServiceConfigs : IEntityTypeConfiguration<CategoryService>
    {
        public void Configure(EntityTypeBuilder<CategoryService> builder)
        {
            builder.HasKey(x => x.Id);

            builder
    .Property(c => c.BidPrice)
    .HasPrecision(18, 4);


            builder.HasOne(x => x.SubCategory)
                .WithMany(x => x.CategoryServices);

            builder.HasMany(e => e.Experts)
                .WithMany(s => s.CategoryServices);

            builder.HasMany(r => r.Requests)
                .WithOne(s => s.CategoryServices);
            builder.HasData(new CategoryService
            {
                Id = 9,
                Name = "نظافت منزل",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 1,
                Description = "استفاده از مواد شوینده درجه یک",
                BidPrice = 150000
            },
            new CategoryService
            {
                Id = 10,
                Name = "نظافت اداری",
    
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 1,
                Description = "شستشوی تمامی اتاق ها",
                BidPrice = 400000
            },


            new CategoryService
            {
                Id = 11,
                Name = "نقاشی ساختمان",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 2,
                Description = "استفاده از رنگهای درجه یک",
                BidPrice = 320000
            },
            new CategoryService
            {
                Id = 12,
                Name = "تعمیرات ساختمان",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 2,
                Description = "سرویس لوله کشی کامل ساختمان",
                BidPrice = 860000
            },


            new CategoryService
            {
                Id = 13,
                Name = "تعمیرات لوازم خانگی",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 3,
                Description = "تعمیرات تلوزیون و مبایل",
                BidPrice = 600000
            },
            new CategoryService
            {
                Id = 14,
                Name = "تعمیرات موبایل",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 3,
                Description = "تعمیرات پاور",
                BidPrice = 750000
            },


            new CategoryService
            {
                Id = 15,
                Name = "حمل بار سبک",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 4,
                BidPrice = 400000
            },
            new CategoryService
            {
                Id = 16,
                Name = "حمل بار سنگین",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 4
            },


            new CategoryService
            {
                Id = 17,
                Name = "تعمیرات خودرو",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 5,
                BidPrice = 500000
            },
            new CategoryService
            {
                Id = 18,
                Name = "کارواش",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 5
                ,BidPrice = 10000
            },


            new CategoryService
            {
                Id = 19,
                Name = "آرایشگاه",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 6
            },
            new CategoryService
            {
                Id = 20,
                Name = "ماساژ",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 6
            },


            new CategoryService
            {
                Id = 21,
                Name = "خدمات عمومی",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 7
            },


            new CategoryService
            {
                Id = 22,
                Name = "نظافت مجتمع",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 8
            },
            new CategoryService
            {
                Id = 23,
                Name = "تعمیرات مجتمع",
                CreatTime = new DateTime(2024, 1, 1, 12, 0, 0),
                SubCategoryId = 8
            }
        );
        }
    }
}
