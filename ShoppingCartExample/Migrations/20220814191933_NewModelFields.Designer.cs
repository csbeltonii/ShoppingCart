// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingCartExample.Data;

#nullable disable

namespace ShoppingCartExample.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20220814191933_NewModelFields")]
    partial class NewModelFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShoppingCartExample.Models.Domain.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ShoppingCartExample.Models.Domain.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFulfilled")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeModified")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShoppingCartExample.Models.Domain.OrderLineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderLineItem");
                });

            modelBuilder.Entity("ShoppingCartExample.Models.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastPurchased")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "IBANEZ RG655CBM (COBALT BLUE METALLIC)",
                            LastPurchased = new DateTime(2016, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Persephone",
                            Price = 1599.99m,
                            TimeCreated = new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9819),
                            TimeModified = new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9883),
                            UniqueIdentifier = "c1d7f3c0-7fe1-4011-bf19-a4720d34b51a"
                        },
                        new
                        {
                            Id = 2,
                            Description = "FENDER STRATOCASTER STANDARD (ARCTIC WHITE)",
                            LastPurchased = new DateTime(2010, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aphrodite",
                            Price = 549.99m,
                            TimeCreated = new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9927),
                            TimeModified = new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9931),
                            UniqueIdentifier = "e7f0ad02-5082-4e84-85c1-4774128e1f6c"
                        },
                        new
                        {
                            Id = 3,
                            Description = "IBANEZ S1070PBZ (CERULEAN BLUE BURST)",
                            LastPurchased = new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ceres",
                            Price = 1866.99m,
                            TimeCreated = new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9952),
                            TimeModified = new DateTime(2022, 8, 14, 15, 19, 32, 842, DateTimeKind.Local).AddTicks(9956),
                            UniqueIdentifier = "40a62f55-b3d5-4105-860b-61015f443f16"
                        });
                });

            modelBuilder.Entity("ShoppingCartExample.Models.Domain.OrderLineItem", b =>
                {
                    b.HasOne("ShoppingCartExample.Models.Domain.Order", null)
                        .WithMany("OrderLineItems")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("ShoppingCartExample.Models.Domain.Order", b =>
                {
                    b.Navigation("OrderLineItems");
                });
#pragma warning restore 612, 618
        }
    }
}
