using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using YemekSiparis.BLL.Abstract;
using YemekSiparis.BLL.Concrete;
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
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

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

            app.UseSession(); //Eklendi

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Login}/{action=Index}/{id?}");

            app.Run();
        }
    }
}