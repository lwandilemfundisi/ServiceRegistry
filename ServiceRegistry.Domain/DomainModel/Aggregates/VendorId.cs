using Microservice.Framework.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.Aggregates
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class VendorId : Identity<VendorId>
    {
        public VendorId(string value)
            : base(value)
        {

        }
    }
}
