using CompanySystem.BLL.Interface;
using CompanySystem.BLL.Repository;
using CompanySystem.DAL.Context;
using CompanySystem.PL.ProfileMapper;
using Microsoft.EntityFrameworkCore;

namespace CompanySystem;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        builder.Services.AddDbContext<ApplicationDbContext>(
            options =>
            options.UseSqlServer(builder
            .Configuration.GetConnectionString("defaultConnection")
            ));

        builder.Services.AddAutoMapper(m => m.AddProfile(new EmployeeProfile()));
        builder.Services.AddAutoMapper(m => m.AddProfile(new DepartmentProfile()));

        builder.Services.AddScoped<IUnitofWork, UnitofWork>();
        //builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        //builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        var app = builder.Build();

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

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
