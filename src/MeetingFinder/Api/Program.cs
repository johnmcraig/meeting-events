using System;
using Domain;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
           var host = CreateHostBuilder(args).Build();
           
           using(var scope = host.Services.CreateScope())
           {
               var services = scope.ServiceProvider;

               try
               {
                    var dbContext = services.GetRequiredService<DataDbContext>();
                    var userManager = services.GetRequiredService<UserManager<AppUser>>();
                    dbContext.Database.Migrate();
                    Seed.SeedData(dbContext, userManager).Wait();
               }
               catch(Exception ex)
               {
                   var logger = services.GetRequiredService<ILogger<Program>>();
                   logger.LogError($"Could not create or migrate database, see full error: {ex}");
               }
           }

           host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
