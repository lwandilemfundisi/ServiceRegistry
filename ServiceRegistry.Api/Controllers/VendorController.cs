using AutoMapper;
using Microservice.Framework.Domain.Commands;
using Microsoft.AspNetCore.Mvc;
using ServiceRegistry.Api.Models.RequestModels;
using ServiceRegistry.Domain.DomainModel.Aggregates;
using ServiceRegistry.Domain.DomainModel.Commands;
using ServiceRegistry.Domain.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceRegistry.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendorController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICommandBus _commandBus;

        public VendorController(
            IMapper mapper,
            ICommandBus commandBus)
        {
            _mapper = mapper;
            _commandBus = commandBus;
        }

        [HttpPost("addvendor")]
        public async Task<IActionResult> AddVendor(VendorRequestModel model)
        {
            if (ModelState.IsValid)
            {
                var vendorId = VendorId.New;

                var command = new AddVendorCommand(
                    vendorId, 
                    model.VendorName, 
                    _mapper.Map<IList<VendorApplication>>(model.VendorApplications));

                var addVendorResult = await _commandBus
                    .PublishAsync(command, CancellationToken.None);

                if (addVendorResult.IsSuccess)
                    return Ok(vendorId);
                else
                    return BadRequest(addVendorResult);
            }
            else
            {
                return BadRequest(ModelState.Values);
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            var testData = new VendorRequestModel
            {
                VendorName = "TestVendor",
                VendorApplications = new List<VendorApplicationRequestModel>
                    {
                        new VendorApplicationRequestModel
                        {
                            Id = VendorApplicationId.New,
                            VendorApplicationUrl = @"Https://localhost:8001",
                            VendorApplicationName = "TestVendorApplicationName",
                            VendorApplicationEndpoints = new List<VendorApplicationEndpointRequestModel>
                            {
                                new VendorApplicationEndpointRequestModel
                                {
                                    Id = VendorApplicationEndpointId.New,
                                    VendorApplicationEndpointDescription = "TestApplicationEndpointDescription",
                                    VendorApplicationEndpointName = "TestApplicationEndpointName",
                                    VendorApplicationEndpointRoute = @"\TestApplicationEndpointName\TestApplicationEndpointNameMethod",
                                    Cost = 1.451M,
                                    IsActive = true,
                                    VendorApplicationEndpointParameters = new List<VendorApplicationEndpointParameterRequestModel>
                                    {
                                        new VendorApplicationEndpointParameterRequestModel
                                        {
                                            Id = VendorApplicationEndpointParameterId.New,
                                            ParameterDescription = "TestParameterDescription",
                                            ParameterName = "TestParameterName",
                                            ParameterPosition = 0,
                                        },
                                        new VendorApplicationEndpointParameterRequestModel
                                        {
                                            Id = VendorApplicationEndpointParameterId.New,
                                            ParameterDescription = "TestParameterDescription2",
                                            ParameterName = "TestParameterName2",
                                            ParameterPosition = 1,
                                        }
                                    }
                                }
                            }
                        }
                    }
            };

            return Ok(testData);
        }
    }
}
