using AppDomainCore.SuggestionEntite.Entite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Db.Sql.Ef.Configs.SuggestionEntite
{
    public class SuggestionConfigs : IEntityTypeConfiguration<Suggestion>
    {
        public void Configure(EntityTypeBuilder<Suggestion> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(r => r.Request)
                .WithMany(s => s.Suggestions).HasForeignKey(x=>x.RequestId).OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(e => e.Experts)
                .WithMany(s => s.Suggestions);

            builder.HasData(new Suggestion()
            {
                Id = 1,
                Description = "نظافت تمامی اتاق ها و سرویس های بهداشتی",
                SuggestionDate = new DateTime(2024, 1, 1, 12, 0, 0),
                Price = 500000,
                Status = AppDomainCore.RequestEntite.Enums.StatusEnum.Confirmed,
                RequestId = 1,

            });


        }
    }
}
