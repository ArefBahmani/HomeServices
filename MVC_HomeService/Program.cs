using AppDomain.AppService.BaseEntity;
using AppDomain.AppService.CategoryEntite;
using AppDomain.AppService.CategoryServiceEntite;
using AppDomain.AppService.CommentEntite;
using AppDomain.AppService.ProvinceEntite;
using AppDomain.AppService.RequestEntite;
using AppDomain.AppService.SubCategoryEntite;
using AppDomain.AppService.SuggestionEntite;
using AppDomain.AppService.UserEntite;
using AppDomain.Service.AddressEntite;
using AppDomain.Service.BaseEntity;
using AppDomain.Service.CategoryEntite;
using AppDomain.Service.CategoryServiceEntite;
using AppDomain.Service.CommentEntite;
using AppDomain.Service.ProvinceEntite;
using AppDomain.Service.RequestEntite;
using AppDomain.Service.SubCategoryEntite;
using AppDomain.Service.SuggestionEntite;
using AppDomain.Service.UserEntite;
using AppDomainCore.AddressEntitie.Data;
using AppDomainCore.AddressEntitie.Service;
using AppDomainCore.BaseEntity.AppService;
using AppDomainCore.BaseEntity.Service;
using AppDomainCore.CategoryEntitie.AppService;
using AppDomainCore.CategoryEntitie.Data;
using AppDomainCore.CategoryEntitie.Service;
using AppDomainCore.CategoryServiceEntitie.AppService;
using AppDomainCore.CategoryServiceEntitie.Data;
using AppDomainCore.CategoryServiceEntitie.Entite;
using AppDomainCore.CategoryServiceEntitie.Service;
using AppDomainCore.CommentEntite.AppService;
using AppDomainCore.CommentEntite.Data;
using AppDomainCore.CommentEntite.Service;
using AppDomainCore.Configs;
using AppDomainCore.ProvinceEntite.AppService;
using AppDomainCore.ProvinceEntite.Data;
using AppDomainCore.ProvinceEntite.Service;
using AppDomainCore.RequestEntite.AppService;
using AppDomainCore.RequestEntite.Data;
using AppDomainCore.RequestEntite.Service;
using AppDomainCore.SubCategoryEntite.AppService;
using AppDomainCore.SubCategoryEntite.Data;
using AppDomainCore.SubCategoryEntite.Service;
using AppDomainCore.SuggestionEntite.AppService;
using AppDomainCore.SuggestionEntite.Date;
using AppDomainCore.SuggestionEntite.Service;
using AppDomainCore.UserEntite.AppService.AdminAppService;
using AppDomainCore.UserEntite.AppService.CustomerAppService;
using AppDomainCore.UserEntite.AppService.ExpertAppService;
using AppDomainCore.UserEntite.Data;
using AppDomainCore.UserEntite.Entiteies;
using AppDomainCore.UserEntite.Service.AdminService;
using AppDomainCore.UserEntite.Service.CustomerService;
using AppDomainCore.UserEntite.Service.ExpertService;
using AppInfer.Data.Repo.Ef.AddressEntite;
using AppInfer.Data.Repo.Ef.CategoryEntite;
using AppInfer.Data.Repo.Ef.CategoryServiceEntite;
using AppInfer.Data.Repo.Ef.CommentEntite;
using AppInfer.Data.Repo.Ef.ProvinceEntite;
using AppInfer.Data.Repo.Ef.RequestEntite;
using AppInfer.Data.Repo.Ef.SubCategoryEntite;
using AppInfer.Data.Repo.Ef.SuggestionEntite;
using AppInfer.Data.Repo.Ef.UserEntite;
using AppInfer.Db.Sql.Ef.Dbase;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
var siteSettings = configuration.GetSection("SiteSettings").Get<SiteSettings>();
builder.Services.AddSingleton(siteSettings);

builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(siteSettings.ConnectionStrings.SqlConnection));

// Add services to the container.
builder.Services.AddControllersWithViews();
//Admin 
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IAdminAppService, AdminAppService>();
builder.Services.AddScoped<IAdminService, AdminService>();


//Request
builder.Services.AddScoped<IRequestRepository, RequestRepository>();
builder.Services.AddScoped<IRequestAppService, RequestAppService>();
builder.Services.AddScoped<IRequestService, RequestService>();
//Address
builder.Services.AddScoped<IAddressRepository, AddressRepository>();


//Category
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryAppService, CategoryAppService>();
builder.Services.AddScoped<ICategoryService, CategoryServic>();
//Comment
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ICommentAppService, CommentAppService>();
builder.Services.AddScoped<ICommentService, CommentService>();
//Provice
builder.Services.AddScoped<IProvinceRepository, ProviceRepository>();
builder.Services.AddScoped<IProviceAppService, ProviceAppService>();
builder.Services.AddScoped<IProviceService, ProviceService>();
//SubCategory
builder.Services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();
builder.Services.AddScoped<ISubCategoryService, SubCategoryService>();
builder.Services.AddScoped<ISubCategoryAppService, SubCategoryAppService>();
//CategoryService
builder.Services.AddScoped<ICategoryServiceRepository, CategoryServiceRepository>();
builder.Services.AddScoped<ICategoryServiceAppService, CategoryServiceAppService>();
builder.Services.AddScoped<ICategoryServiceService, CategoryServiceService>();
//Suggestion
builder.Services.AddScoped<ISuggestionRepository, SuggestionRepository>();
builder.Services.AddScoped<ISuggestionAppService, SuggestionAppService>();
builder.Services.AddScoped<ISuggestionService, SuggestionService>();
//Expert
builder.Services.AddScoped<IExpertRepository, ExpertRepository>();
builder.Services.AddScoped<IExpertAppService, ExpertAppService>();
builder.Services.AddScoped<IExpertService, ExpertService>();
//Customer
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<ICustomerAppService, CustomerAppService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddScoped<IBaseService, BaseService>();
builder.Services.AddScoped<IBaseAppService, BaseAppService>();

builder.Services.AddScoped<IAccountAppService, AccountAppService>();


//builder.Services.AddScoped<IAccountAppServices, AccountAppServices>();

builder.Services.AddIdentity<ApplicationUser, IdentityRole<int>>
    (options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
    })
    .AddRoles<IdentityRole<int>>()
    .AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders(); 
    




var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "Areas",
    pattern: "{Area:exists}/{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
