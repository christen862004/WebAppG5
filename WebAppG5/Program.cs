using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using WebAppG5.Models;
using WebAppG5.Repository;

namespace WebAppG5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container. //service Day8 inject
            //1) Built in service , already register (interface ,Class)
            //2) Built in service , need to  register (interface ,Class) (optional Service)

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<StepsContext>(option => { //options & StepsContext
                option.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            }); 
            //3) Custom Service ,need To Register
            builder.Services.AddScoped<IService, Service>();//register using sigletone
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();//register
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRespository>();


            var app = builder.Build();

            // Configure the HTTP request pipeline. middleware
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
