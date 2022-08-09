﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RFQManagement.DbaseContext;

namespace RFQManagement.Migrations
{
    [DbContext(typeof(RFQDbContext))]
    partial class RFQDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RFQManagement.Models.Rfq", b =>
                {
                    b.Property<int>("rfqId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Part_Id")
                        .HasColumnType("int");

                    b.Property<string>("Quantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("demandid")
                        .HasColumnType("int");

                    b.Property<string>("partName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("timetoSupply")
                        .HasColumnType("datetime2");

                    b.HasKey("rfqId");

                    b.ToTable("Rfq");
                });

            modelBuilder.Entity("RFQManagement.Models.Supplier", b =>
                {
                    b.Property<int>("Part_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Feedback")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supplier_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Supplier_id")
                        .HasColumnType("int");

                    b.HasKey("Part_id");

                    b.ToTable("SUPPLIER");
                });
#pragma warning restore 612, 618
        }
    }
}
