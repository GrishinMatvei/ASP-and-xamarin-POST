using AspXamarin.Models;
using Microsoft.EntityFrameworkCore;
using Services.Users.Models;

namespace AspXamarin;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        string con = "Server=localhost\\SQLEXPRESS;Database=EtoBaza;Trusted_Connection=True;";

        builder.Services.AddRazorPages();

        builder.Services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(con));
         
        var app = builder.Build();

        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();
        app.MapControllers();

        app.Run();
    }
}