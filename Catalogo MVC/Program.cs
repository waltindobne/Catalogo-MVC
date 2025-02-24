using Catalogo_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Catalogo_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<Contexto>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            if (builder == null)
            {
                throw new NullReferenceException("builder está nulo!");
            }

            if (app == null)
            {
                throw new NullReferenceException("app está nulo!");
            }


            if (!app.Environment.IsDevelopment())
            {
                Console.WriteLine("Entrando no modo de produção...");
            }

        app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Produtos}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
