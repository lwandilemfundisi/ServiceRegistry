using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Persistence
{
    public class VendorContextFactory : IDesignTimeDbContextFactory<VendorContext>
    {
        public VendorContext CreateDbContext(string[] args)
        {
            var envName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile($"appsettings.{envName}.json", optional: false)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<VendorContext>();
            optionsBuilder.UseSqlServer(configuration["DataConnection:Database"]);

            return new VendorContext(optionsBuilder.Options);
        }
    }
}
