﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceRegistry.Persistence;

namespace ServiceRegistry.Persistence.Migrations
{
    [DbContext(typeof(VendorContext))]
    [Migration("20210911100227_AddProperty_VendorApplicationEndpointRouteHttpMethod")]
    partial class AddProperty_VendorApplicationEndpointRouteHttpMethod
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServiceRegistry.Domain.DomainModel.Aggregates.Vendor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VendorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vendor");
                });

            modelBuilder.Entity("ServiceRegistry.Domain.DomainModel.Entities.VendorApplication", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VendorApplicationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorApplicationUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("VendorApplication");
                });

            modelBuilder.Entity("ServiceRegistry.Domain.DomainModel.Entities.VendorApplicationEndpoint", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("VendorApplicationEndpointDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorApplicationEndpointName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorApplicationEndpointRoute")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorApplicationEndpointRouteHttpMethod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorApplicationId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("VendorApplicationId");

                    b.ToTable("VendorApplicationEndpoint");
                });

            modelBuilder.Entity("ServiceRegistry.Domain.DomainModel.Entities.VendorApplicationEndpointParameter", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ParameterDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParameterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParameterPosition")
                        .HasColumnType("int");

                    b.Property<string>("VendorApplicationEndpointId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("VendorApplicationEndpointId");

                    b.ToTable("VendorApplicationEndpointParameter");
                });

            modelBuilder.Entity("ServiceRegistry.Domain.DomainModel.Entities.VendorApplication", b =>
                {
                    b.HasOne("ServiceRegistry.Domain.DomainModel.Aggregates.Vendor", null)
                        .WithMany("VendorApplications")
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("ServiceRegistry.Domain.DomainModel.Entities.VendorApplicationEndpoint", b =>
                {
                    b.HasOne("ServiceRegistry.Domain.DomainModel.Entities.VendorApplication", null)
                        .WithMany("VendorApplicationEndpoints")
                        .HasForeignKey("VendorApplicationId");
                });

            modelBuilder.Entity("ServiceRegistry.Domain.DomainModel.Entities.VendorApplicationEndpointParameter", b =>
                {
                    b.HasOne("ServiceRegistry.Domain.DomainModel.Entities.VendorApplicationEndpoint", null)
                        .WithMany("VendorApplicationEndpointParameters")
                        .HasForeignKey("VendorApplicationEndpointId");
                });

            modelBuilder.Entity("ServiceRegistry.Domain.DomainModel.Aggregates.Vendor", b =>
                {
                    b.Navigation("VendorApplications");
                });

            modelBuilder.Entity("ServiceRegistry.Domain.DomainModel.Entities.VendorApplication", b =>
                {
                    b.Navigation("VendorApplicationEndpoints");
                });

            modelBuilder.Entity("ServiceRegistry.Domain.DomainModel.Entities.VendorApplicationEndpoint", b =>
                {
                    b.Navigation("VendorApplicationEndpointParameters");
                });
#pragma warning restore 612, 618
        }
    }
}
