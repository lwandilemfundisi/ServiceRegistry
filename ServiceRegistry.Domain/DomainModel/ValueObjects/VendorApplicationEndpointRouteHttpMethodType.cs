using Microservice.Framework.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.ValueObjects
{
    [ValueObjectResourcePath("ServiceRegistry.Domain.DomainModel.ValueObjects.Mappings.VendorApplicationEndpointRouteHttpMethodType.xml")]
    public class VendorApplicationEndpointRouteHttpMethodType : XmlValueObject
    {
    }

    public class VendorApplicationEndpointRouteHttpMethodTypes 
        : XmlValueObjectLookup<VendorApplicationEndpointRouteHttpMethodType, VendorApplicationEndpointRouteHttpMethodTypes>
    {
        public VendorApplicationEndpointRouteHttpMethodType Get { get { return FindValueObject("Get"); } }

        public VendorApplicationEndpointRouteHttpMethodType Post { get { return FindValueObject("Post"); } }

        public VendorApplicationEndpointRouteHttpMethodType Put { get { return FindValueObject("Put"); } }

        public VendorApplicationEndpointRouteHttpMethodType Delete { get { return FindValueObject("Delete"); } }
    }
}
