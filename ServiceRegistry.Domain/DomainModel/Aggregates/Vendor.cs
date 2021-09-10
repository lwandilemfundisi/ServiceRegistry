using Microservice.Framework.Domain.Aggregates;
using Microservice.Framework.Domain.Extensions;
using ServiceRegistry.Domain.DomainModel.Entities;
using ServiceRegistry.Domain.DomainModel.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.Aggregates
{
    public class Vendor : AggregateRoot<Vendor, VendorId>
    {
        #region Constructors

        public Vendor()
            : this(null)
        {

        }

        public Vendor(VendorId id)
            : base(id)
        {

        }

        #endregion

        #region Properties

        public string VendorName { get; set; }

        public IList<VendorApplication> VendorApplications { get; set; }

        #endregion

        #region Methods

        public void AddVendor(
            string vendorName,
            IList<VendorApplication> vendorApplications)
        {
            Specs.AggregateIsNew.ThrowDomainErrorIfNotSatisfied(this);

            VendorName = vendorName;
            VendorApplications = vendorApplications;

            Emit(new AddedVendorEvent(vendorName , vendorApplications));
        }

        public void UpdateVendor(
            string vendorName,
            IList<VendorApplication> vendorApplications)
        {
            Specs.AggregateIsCreated.ThrowDomainErrorIfNotSatisfied(this);

            VendorName = vendorName;
            VendorApplications = vendorApplications;

            Emit(new AddedVendorEvent(vendorName, vendorApplications));
        }

        #endregion
    }
}
