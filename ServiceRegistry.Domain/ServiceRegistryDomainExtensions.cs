using Microservice.Framework.Domain;
using Microservice.Framework.Domain.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain
{
    public static class ServiceRegistryDomainExtensions
    {
        public static Assembly Assembly { get; }
            = typeof(ServiceRegistryDomainExtensions).Assembly;

        public static IDomainContainer ConfigureVendorDomain(
            this IServiceCollection services,
            IConfiguration configuration = null)
        {
            return DomainContainer.New(services)
                .AddDefaults(Assembly);
        }
    }
}
