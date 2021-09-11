using Microsoft.EntityFrameworkCore;
using ServiceRegistry.Domain.DomainModel.Aggregates;
using ServiceRegistry.Domain.DomainModel.Entities;
using ServiceRegistry.Domain.DomainModel.ValueObjects;
using ServiceRegistry.Persistence.ValueObjectConverters;

namespace ServiceRegistry.Persistence.Mappings.ServiceMonitoringDomainModel
{
    public static class VendorModelMapping
    {
        public static ModelBuilder VendorModelMap(this ModelBuilder modelBuilder)
        {
            #region Id Configurations

            modelBuilder
                .Entity<Vendor>()
                .Property(o => o.Id)
                .HasConversion(new SingleValueObjectIdentityValueConverter<VendorId>());

            modelBuilder
                .Entity<VendorApplication>()
                .Property(o => o.Id)
                .HasConversion(new SingleValueObjectIdentityValueConverter<VendorApplicationId>());

            modelBuilder
                .Entity<VendorApplicationEndpoint>()
                .Property(o => o.Id)
                .HasConversion(new SingleValueObjectIdentityValueConverter<VendorApplicationEndpointId>());

            modelBuilder
                .Entity<VendorApplicationEndpoint>()
                .Property(o => o.VendorApplicationEndpointRouteHttpMethod)
                .HasConversion(new ValueObjectValueConverter<VendorApplicationEndpointRouteHttpMethodType, VendorApplicationEndpointRouteHttpMethodTypes>());

            modelBuilder
                .Entity<VendorApplicationEndpointParameter>()
                .Property(o => o.Id)
                .HasConversion(new SingleValueObjectIdentityValueConverter<VendorApplicationEndpointParameterId>());

            #endregion

            #region Relationship Configuration

            modelBuilder
                .Entity<VendorApplication>()
                .HasOne<Vendor>()
                .WithMany(v => v.VendorApplications);

            modelBuilder
                .Entity<VendorApplicationEndpoint>()
                .HasOne<VendorApplication>()
                .WithMany(va => va.VendorApplicationEndpoints);

            modelBuilder
                .Entity<VendorApplicationEndpointParameter>()
                .HasOne<VendorApplicationEndpoint>()
                .WithMany(vae => vae.VendorApplicationEndpointParameters);

            #endregion

            return modelBuilder;
        }
    }

}
