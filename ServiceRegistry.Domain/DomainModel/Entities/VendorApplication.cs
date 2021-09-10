using Microservice.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.Entities
{
    public class VendorApplication : Entity<VendorApplicationId>
    {
        #region Properties

        public string VendorApplicationName { get; set; }

        public string VendorApplicationUrl { get; set; }

        public IList<VendorApplicationEndpoint> VendorApplicationEndpoints { get; set; }

        #endregion
    }
}
