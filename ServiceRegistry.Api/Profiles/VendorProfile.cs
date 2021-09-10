using AutoMapper;
using ServiceRegistry.Api.Models.RequestModels;
using ServiceRegistry.Domain.DomainModel.Aggregates;
using ServiceRegistry.Domain.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceRegistry.Api.Profiles
{
    public class VendorProfile : Profile
    {
        public VendorProfile()
        {
            CreateMap<VendorRequestModel, Vendor>().ReverseMap();
            CreateMap<VendorApplicationRequestModel, VendorApplication>().ReverseMap();
            CreateMap<VendorApplicationEndpointRequestModel, VendorApplicationEndpoint>().ReverseMap();
            CreateMap<VendorApplicationEndpointParameterRequestModel, VendorApplicationEndpointParameter>().ReverseMap();
        }
    }
}
