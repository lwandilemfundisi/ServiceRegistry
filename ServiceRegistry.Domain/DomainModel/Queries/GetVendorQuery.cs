using Microservice.Framework.Domain.Queries;
using Microservice.Framework.Persistence;
using Microservice.Framework.Persistence.EFCore.Queries.CriteriaQueries;
using Microservice.Framework.Persistence.EFCore.Queries.Filtering;
using Microservice.Framework.Persistence.Extensions;
using Microservice.Framework.Persistence.Queries.Filtering;
using ServiceRegistry.Domain.DomainModel.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServiceRegistry.Domain.DomainModel.Queries
{
    public class GetVendorQuery 
        : EFCoreCriteriaDomainQuery<Vendor>, IQuery<Vendor>
    {
        #region Constructors

        public GetVendorQuery(VendorId vendorId)
        {
            Id = vendorId;
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        #endregion

        #region Virtual Methods

        protected override void OnBuildDomainCriteria(EFCoreDomainCriteria domainCriteria)
        {
            domainCriteria.SafeAnd(new EqualityFilter("VendorName", Name, FilterType.Equal));
        }

        #endregion
    }

    public class GetVendorQueryHandler
        : EFCoreCriteriaDomainQueryHandler<Vendor>, IQueryHandler<GetVendorQuery, Vendor>
    {
        #region Constructors

        public GetVendorQueryHandler(IPersistenceFactory persistenceFactory)
            : base(persistenceFactory)
        {
        }

        #endregion

        #region IQueryHandler Members

        public Task<Vendor> ExecuteQueryAsync(GetVendorQuery query, CancellationToken cancellationToken)
        {
            return Find(query);
        }

        #endregion
    }
}
