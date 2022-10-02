﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Workshops.Infrastructure;

#nullable disable

namespace Workshops.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Workshops.Entities.Workshop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Workshops", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("258492ae-0133-47fc-b3f1-75c0ac33a291"),
                            Date = new DateTime(2022, 10, 9, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1498),
                            Name = "Workshop Azure Network"
                        },
                        new
                        {
                            Id = new Guid("f55add9c-350a-4b14-bd1d-f13aca067846"),
                            Date = new DateTime(2022, 10, 24, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1510),
                            Name = "Workshop Terraform"
                        },
                        new
                        {
                            Id = new Guid("e867c517-ce35-4fe5-8cae-b944dbfd9d54"),
                            Date = new DateTime(2022, 11, 8, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1512),
                            Name = "Workshop Azure Kubernetes Service"
                        },
                        new
                        {
                            Id = new Guid("f2b16552-389a-442c-a176-ee46b3ce53a7"),
                            Date = new DateTime(2022, 11, 23, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1514),
                            Name = "Workshop Azyre Container Instance"
                        },
                        new
                        {
                            Id = new Guid("952347f8-11af-4bf3-ab62-91e9794d56ec"),
                            Date = new DateTime(2022, 12, 8, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1515),
                            Name = "Workshop Azure Firewall"
                        },
                        new
                        {
                            Id = new Guid("59d1e381-5484-4580-9eb4-8fc364075225"),
                            Date = new DateTime(2022, 12, 23, 17, 17, 7, 376, DateTimeKind.Local).AddTicks(1516),
                            Name = "Workshop Azure Cognitive Services"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}