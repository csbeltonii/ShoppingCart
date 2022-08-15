﻿// <auto-generated />
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
    [Migration("20220814130807_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
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

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("UniqueIdentifier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "IBANEZ RG655CBM (COBALT BLUE METALLIC)",
                            LastPurchased = new DateTime(2016, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Persephone",
                            TimeCreated = new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3555),
                            TimeModified = new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3597),
                            UniqueIdentifier = "55cc467d-0961-4dd5-9314-361067bf0a53"
                        },
                        new
                        {
                            Id = 2,
                            Description = "FENDER STRATOCASTER STANDARD (ARCTIC WHITE)",
                            LastPurchased = new DateTime(2010, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Aphrodite",
                            TimeCreated = new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3622),
                            TimeModified = new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3624),
                            UniqueIdentifier = "ac567375-69a4-4b19-a03e-5059b5619c65"
                        },
                        new
                        {
                            Id = 3,
                            Description = "IBANEZ S1070PBZ (CERULEAN BLUE BURST)",
                            LastPurchased = new DateTime(2022, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ceres",
                            TimeCreated = new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3635),
                            TimeModified = new DateTime(2022, 8, 14, 9, 8, 7, 393, DateTimeKind.Local).AddTicks(3637),
                            UniqueIdentifier = "46a8f352-5754-4acf-ba59-9024ba086139"
                        });
                });

            modelBuilder.Entity("ShoppingCartExample.Models.Domain.Product", b =>
                {
                    b.HasOne("ShoppingCartExample.Models.Domain.Order", null)
                        .WithMany("Products")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("ShoppingCartExample.Models.Domain.Order", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}