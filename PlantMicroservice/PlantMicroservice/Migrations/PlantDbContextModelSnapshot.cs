﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlantMicroservice.DbaseContext;

namespace PlantMicroservice.Migrations
{
    [DbContext(typeof(PlantDbContext))]
    partial class PlantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlantMicroservice.Models.Demand", b =>
                {
                    b.Property<int>("DemandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DemandCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("DemandRaisedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.HasKey("DemandId");

                    b.ToTable("Demands");
                });

            modelBuilder.Entity("PlantMicroservice.Models.Part", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PartDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartSpecification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockInHand")
                        .HasColumnType("int");

                    b.HasKey("PartId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("PlantMicroservice.Models.PlantReorderDetails", b =>
                {
                    b.Property<int>("PlantReorderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PartDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReorderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReorderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlantReorderId");

                    b.ToTable("PlantReoDetail");
                });

            modelBuilder.Entity("PlantMicroservice.Models.ReorderRules", b =>
                {
                    b.Property<int>("ReorderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DemandId")
                        .HasColumnType("int");

                    b.Property<int>("MaxQuantity")
                        .HasColumnType("int");

                    b.Property<int>("MinQuantity")
                        .HasColumnType("int");

                    b.Property<int>("PartId")
                        .HasColumnType("int");

                    b.Property<int>("ReorderFrequency")
                        .HasColumnType("int");

                    b.HasKey("ReorderId");

                    b.ToTable("ReoRule");
                });

            modelBuilder.Entity("PlantMicroservice.Models.updateobj", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("max")
                        .HasColumnType("int");

                    b.Property<int>("min")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("UpdateMinMax");
                });
#pragma warning restore 612, 618
        }
    }
}
