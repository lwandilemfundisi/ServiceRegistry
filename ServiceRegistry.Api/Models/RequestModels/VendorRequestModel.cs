using ServiceRegistry.Domain.DomainModel.Aggregates;
using ServiceRegistry.Domain.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceRegistry.Api.Models.RequestModels
{
    public class VendorRequestModel
    {
        public string VendorName { get; set; }

        public IList<VendorApplicationRequestModel> VendorApplications { get; set; }
    }

    public class VendorApplicationRequestModel
    {
        public VendorApplicationId Id { get; set; }

        public string VendorApplicationName { get; set; }

        public string VendorApplicationUrl { get; set; }

        public IList<VendorApplicationEndpointRequestModel> VendorApplicationEndpoints { get; set; }
    }

    public class VendorApplicationEndpointRequestModel
    {
        public VendorApplicationEndpointId Id { get; set; }

        public string VendorApplicationEndpointName { get; set; }

        public string VendorApplicationEndpointDescription { get; set; }

        public string VendorApplicationEndpointRoute { get; set; }

        public decimal Cost { get; set; }

        public bool IsActive { get; set; }

        public IList<VendorApplicationEndpointParameterRequestModel> VendorApplicationEndpointParameters { get; set; }
    }

    public class VendorApplicationEndpointParameterRequestModel
    {
        public VendorApplicationEndpointParameterId Id { get; set; }

        public string ParameterName { get; set; }

        public string ParameterDescription { get; set; }

        public int? ParameterPosition { get; set; }
    }
}
