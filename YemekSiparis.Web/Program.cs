using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using YemekSiparis.BLL.Services.Basket.Abstract;
using YemekSiparis.BLL.Services.Basket.Concrete;
using YemekSiparis.Core.Entities;
using YemekSiparis.Core.IRepositories;
using YemekSiparis.DAL.Context;
using YemekSiparis.DAL.Repositories;
using YemekSiparis.DAL.SeedData;

namespace YemekSiparis.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            
            //CONTEXT
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("conStr")));

            //IDENTÝTY
            builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();

            //MAPPER
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //DEPENDENCY INJECTION
            builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            builder.Services.AddTransient<IOrderDetailRepository, OrderDetailRepository>();
            builder.Services.AddTransient<IFoodRepository, FoodRepository>();
            builder.Services.AddTransient<IExtraRepository, ExtraRepository>();
            builder.Services.AddTransient<IBeverageRepository, BeverageRepository>();
            builder.Services.AddTransient<IOrderBagRepository, OrderBagRepository>();

            //SERVÝCE INJECTION
            builder.Services.AddScoped<ICreateOrderService,CreateOrderManager>();
            builder.Services.AddScoped<IOrderDetailService,OrderDetailManager>();
            builder.Services.AddScoped<IExtraService,ExtraManager>();
            builder.Services.AddScoped<IBeverageService,BeverageManager>();


            var app = builder.Build();


            var serviceScope = app.Services.CreateScope();
            
                AppDbContext _context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                UserManager<AppUser> userManager = serviceScope.ServiceProvider.GetService<UserManager<AppUser>>();
                RoleManager<IdentityRole> roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IdentityRole>>();

                AdminSeedData.Seed(userManager,roleManager,_context);

        

          


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
            app.UseAuthentication(); // EKLENDÝ
            app.UseAuthorization();

            

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}