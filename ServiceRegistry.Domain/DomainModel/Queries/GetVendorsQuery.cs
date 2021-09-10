using Microservice.Framework.Domain.Queries;
using Microservice.Framework.Persistence;
using Microservice.Framework.Persistence.EFCore.Queries.CriteriaQueries;
using Microservice.Framework.Persistence.EFCore.Queries.Filtering;
using ServiceRegistry.Domain.DomainModel.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.Queries
{
    public class GetVendorsQuery
        : EFCoreCriteriaDomainQuery<Vendor>, IQuery<IEnumerable<Vendor>>
    {
        #region Constructors

        public GetVendorsQuery(IList<VendorId> vendorIds)
        {
            Ids = vendorIds;
        }

        #endregion

        #region Properties

        #endregion

        #region Virtual Methods

        #endregion
    }

    public class GetVendorsQueryHandler
        : EFCoreCriteriaDomainQueryHandler<Vendor>, IQueryHandler<GetVendorsQuery, IEnumerable<Vendor>>
    {
        #region Constructors

        public GetVendorsQueryHandler(IPersistenceFactory persistenceFactory)
            : base(persistenceFactory)
        {
        }

        #endregion

        #region IQueryHandler Members

        public Task<IEnumerable<Vendor>> ExecuteQueryAsync(GetVendorsQuery query, CancellationToken cancellationToken)
        {
            return FindAll(query);
        }

        #endregion
    }
}
