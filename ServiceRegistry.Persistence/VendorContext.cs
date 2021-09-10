using Microsoft.EntityFrameworkCore;
using ServiceRegistry.Persistence.Mappings.ServiceMonitoringDomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Persistence
{
    public class VendorContext : DbContext
    {
        public VendorContext(DbContextOptions<VendorContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.VendorModelMap();
        }
    }
}
