using Microservice.Framework.Persistence.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Persistence
{
    public class VendorContextProvider : IDbContextProvider<VendorContext>, IDisposable
    {
        private readonly DbContextOptions<VendorContext> _options;

        public VendorContextProvider(IConfiguration configuration)
        {
            _options = new DbContextOptionsBuilder<VendorContext>()
                .UseSqlServer(configuration["DataConnection:Database"])
                .Options;
        }

        public VendorContext CreateContext()
        {
            return new VendorContext(_options);
        }

        public void Dispose()
        {
        }
    }
}
