﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreMagementApi.Data;

#nullable disable

namespace StoreMagementApi.Migrations
{
    [DbContext(typeof(StoreContxt))]
    partial class StoreContxtModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StoreMagementApi.Models.StoreManagement", b =>
                {
                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Product_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity_available")
                        .HasColumnType("int");

                    b.HasKey("Product_id");

                    b.ToTable("storeManagements");
                });
#pragma warning restore 612, 618
        }
    }
}
