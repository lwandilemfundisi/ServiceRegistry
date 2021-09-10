using Microservice.Framework.Domain.Events;
using Microservice.Framework.Domain.Events.AggregateEvents;
using ServiceRegistry.Domain.DomainModel.Aggregates;
using ServiceRegistry.Domain.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.Events
{
    [EventVersion("UpdatedVendorEvent", 1)]
    public class UpdatedVendorEvent : AggregateEvent<Vendor, VendorId>
    {
        public UpdatedVendorEvent(
            string vendorName,
            IList<VendorApplication> vendorApplications)
        {
            VendorName = vendorName;
            VendorApplications = vendorApplications;
        }

        public string VendorName { get; }

        public IList<VendorApplication> VendorApplications { get; }
    }
}
