using Microservice.Framework.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.Entities
{
    public class VendorApplicationEndpointParameter : Entity<VendorApplicationEndpointParameterId>
    {
        #region Properties

        public string ParameterName { get; set; }

        public string ParameterDescription { get; set; }

        public int? ParameterPosition { get; set; }

        #endregion
    }
}
