using HotelLibrary.DBContex;
using Microsoft.EntityFrameworkCore;

namespace CustomerWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            // Configure session services
            builder.Services.AddDistributedMemoryCache();  // Add in-memory cache for sessions
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);  // Set session timeout
                options.Cookie.HttpOnly = true;  // Make sure cookies are only accessible via HTTP
                options.Cookie.IsEssential = true;  // Make the cookie essential for the app to function
            });

            // Configure the database context
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            // Add session middleware before authorization
            app.UseSession();  // Ensure sessions are available

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapRazorPages()
               .WithStaticAssets();

            app.Run();
        }
    }
}
