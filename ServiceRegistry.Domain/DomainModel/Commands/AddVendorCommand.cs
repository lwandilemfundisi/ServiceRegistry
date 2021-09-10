using Microservice.Framework.Domain.Commands;
using Microservice.Framework.Domain.ExecutionResults;
using ServiceRegistry.Domain.DomainModel.Aggregates;
using ServiceRegistry.Domain.DomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.Commands
{
    public class AddVendorCommand : Command<Vendor, VendorId>
    {
        #region Constructors

        public AddVendorCommand(VendorId id)
            : base(id)
        {

        }

        public AddVendorCommand(VendorId id, string vendorName, IList<VendorApplication> vendorApplications) : this(id)
        {
            VendorName = vendorName;
            VendorApplications = vendorApplications;
        }

        public string VendorName { get; }
        public IList<VendorApplication> VendorApplications { get; }

        #endregion

        #region Properties



        #endregion
    }

    public class AddVendorCommandHandler : CommandHandler<Vendor, VendorId, AddVendorCommand>
    {
        public override Task<IExecutionResult> ExecuteAsync(
            Vendor aggregate, 
            AddVendorCommand command, 
            CancellationToken cancellationToken)
        {
            aggregate.AddVendor(command.VendorName, command.VendorApplications);
            return Task.FromResult(ExecutionResult.Success());
        }
    }
}
