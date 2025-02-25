using AppDomainCore.AddressEntitie.Entite;
using AppDomainCore.CategoryEntitie.Dtos;
using AppDomainCore.CategoryEntitie.Entite;
using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.CityEntite.Entite;
using AppDomainCore.CommentEntite.Entite;
using AppDomainCore.RequestEntite.Entite;
using AppDomainCore.SubCategoryEntite.Entite;
using AppDomainCore.SuggestionEntite.Entite;
using AppDomainCore.UserEntite.Entiteies;
using AppInfer.Db.Sql.Ef.Configs.AddressEntite;
using AppInfer.Db.Sql.Ef.Configs.CategoryEntite;
using AppInfer.Db.Sql.Ef.Configs.CategoryServiceEntite;
using AppInfer.Db.Sql.Ef.Configs.CommentEntite;
using AppInfer.Db.Sql.Ef.Configs.ProvinceEntite;
using AppInfer.Db.Sql.Ef.Configs.RequestEntite;
using AppInfer.Db.Sql.Ef.Configs.SubCategoryEntite;
using AppInfer.Db.Sql.Ef.Configs.SuggestionEntite;
using AppInfer.Db.Sql.Ef.Configs.UserEntite;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AppInfer.Db.Sql.Ef.Dbase
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-J6I42F2\SQLEXPRESS;Initial Catalog=HomeService;User ID=SA;Password=123456;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.ConfigureWarnings(warnings =>
warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfigs());
            modelBuilder.ApplyConfiguration(new AdminConfigs());
            modelBuilder.ApplyConfiguration(new ExpertConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfigs());
            modelBuilder.ApplyConfiguration(new RequestConfigs());
            modelBuilder.ApplyConfiguration(new CommentConfigs());
            modelBuilder.ApplyConfiguration(new ProviceConfigs());
            modelBuilder.ApplyConfiguration(new CategoryConfigs());
            modelBuilder.ApplyConfiguration(new SubCategoryConfigs());
            modelBuilder.ApplyConfiguration(new CategoryServiceConfigs());
            modelBuilder.ApplyConfiguration(new SuggestionConfigs());
            UserConfiguration.SeedUsers(modelBuilder);
          
       
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<CategoryService> CategoryServices { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Suggestion> Suggestions { get; set; }


    }
}
