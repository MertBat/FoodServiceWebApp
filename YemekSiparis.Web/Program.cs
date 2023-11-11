using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using YemekSiparis.BLL.Abstract;
using YemekSiparis.BLL.Concrete;
using YemekSiparis.BLL.AutoMapper;
using YemekSiparis.BLL.Services.Admin.Bevarage;
using YemekSiparis.BLL.Services.Admin.Beverage;
using YemekSiparis.BLL.Services.Admin.Category;
using YemekSiparis.BLL.Services.Admin.CustomerDetail;
using YemekSiparis.BLL.Services.Admin.Employee;
using YemekSiparis.BLL.Services.Admin.Extra;
using YemekSiparis.BLL.Services.Admin.Giro;
using YemekSiparis.BLL.Services.Admin.Product;
using YemekSiparis.BLL.Services.Admin.Stock;
using YemekSiparis.Core.Entities;
using YemekSiparis.Core.IRepositories;
using YemekSiparis.DAL.Context;
using YemekSiparis.DAL.Repositories;
using YemekSiparis.DAL.SeedData;
using YemekSiparis.Web.Models;

namespace YemekSiparis.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
            });



            //Session
            builder.Services.AddSession();
            

            //CONTEXT
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conStr")));

            //IDENTÝTY
            builder.Services.AddIdentity<AppUser, IdentityRole>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<AppDbContext>().AddErrorDescriber<CustomIdentityValidation>();//AddErrorDescriber eklendi

			builder.Services.Configure<IdentityOptions>(options =>
			{
				options.User.RequireUniqueEmail = true; // Email adýnýn benzersiz olmasý için
				
			});

			//MAPPER
			builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //Dependency Injection 
            builder.Services.AddTransient<ICustomerRepository,CustomerRepository>();
            builder.Services.AddScoped<ICustomerService,CustomerManager>();



            //Repo
            builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            builder.Services.AddTransient(typeof(IFoodDietRepository), typeof(FoodDietRepository));
            builder.Services.AddTransient(typeof(ICustomerDetailRepository), typeof(CustomerDetailRepository));
            builder.Services.AddTransient(typeof(ICategoryRepository), typeof(CategoryRepository));

            //Services
            builder.Services.AddScoped<IProductService, ProductService>();
            builder.Services.AddScoped<IExtraService, ExtraService>();
            builder.Services.AddScoped<IBeverageService, BeverageService>();
            builder.Services.AddScoped<IStockService, StockService>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICustomerDetailService, CustomerDetailService>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();
            builder.Services.AddScoped<IGiroService, GiroService>();

            //Automapper
            builder.Services.AddAutoMapper(typeof(MappingProfile));


            var app = builder.Build();
            var serviceScope = app.Services.CreateScope();

            AppDbContext _context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            UserManager<AppUser> userManager = serviceScope.ServiceProvider.GetService<UserManager<AppUser>>();
            RoleManager<IdentityRole> roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

            AdminSeedData.Seed(userManager, roleManager, _context);


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication(); 
            app.UseAuthorization();


            app.UseSession(); //Eklendi

            app.MapAreaControllerRoute(
                areaName: "Admin",
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Index}/{id?}");

            app.Run();
        }
    }
}