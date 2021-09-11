using Microservice.Framework.Domain;
using ServiceRegistry.Domain.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.Entities
{
    public class VendorApplicationEndpoint : Entity<VendorApplicationEndpointId>
    {
        #region Properties

        public string VendorApplicationEndpointName { get; set; }

        public string VendorApplicationEndpointDescription { get; set; }

        public string VendorApplicationEndpointRoute { get; set; }

        public VendorApplicationEndpointRouteHttpMethodType VendorApplicationEndpointRouteHttpMethod { get; set; }

        public decimal Cost { get; set; }

        public bool IsActive { get; set; }

        public IList<VendorApplicationEndpointParameter> VendorApplicationEndpointParameters { get; set; }

        #endregion
    }
}
