using Microservice.Framework.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.Entities
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class VendorApplicationEndpointParameterId : Identity<VendorApplicationEndpointParameterId>
    {
        public VendorApplicationEndpointParameterId(string value)
            : base(value)
        {
        }
    }
}
