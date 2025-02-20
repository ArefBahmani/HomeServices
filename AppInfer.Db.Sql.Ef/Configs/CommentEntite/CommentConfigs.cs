using AppDomainCore.CommentEntite.Entite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInfer.Db.Sql.Ef.Configs.CommentEntite
{
    public class CommentConfigs : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
           builder.HasKey(x => x.Id);
            builder.HasOne(c => c.Customer)
                .WithMany(c => c.Comments).HasForeignKey(x=>x.CustomerId).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Expert)
                .WithMany(c => c.Comments).HasForeignKey(x=>x.ExpertId).OnDelete(DeleteBehavior.Restrict);

            builder.HasData(new Comment
            {
                Id = 1,
                CustomerId = 4,
                ExpertId = 2,
                Reaction = 3,
                Titel = "سطح کاری متوسطی داشتن",
                SaveTime = new DateTime(2024, 1, 1, 12, 0, 0),
                Description = "لطفا رسیدگی شود"
            });
        }
    }
}
