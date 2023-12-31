﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiSample.Data;

#nullable disable

namespace WebApiSample.Migrations
{
    [DbContext(typeof(StudentDataContxt))]
    partial class StudentDataContxtModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApiSample.Models.Student", b =>
                {
                    b.Property<int>("StuID")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pin")
                        .HasColumnType("int");

                    b.Property<string>("StudName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StuID");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
