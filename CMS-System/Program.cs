using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
// //DESKTOP-RBQBMMC\SQLEXPRESS
// dotnet ef dbcontext scaffold "Server=DESKTOP-RBQBMMC\SQLEXPRESS;Database=IBS CMS;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Model
namespace CMS_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
