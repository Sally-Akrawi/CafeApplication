﻿// <auto-generated />
using DatabaseOperations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseOperations.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220803122416_fifteenth")]
    partial class fifteenth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseOperations.Models.FoodMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("DisableData")
                        .HasColumnType("bit");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FoodPrice")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("FoodTypes");
                });

            modelBuilder.Entity("DatabaseOperations.Models.MilkType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DisableData")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("MilkTypes");
                });

            modelBuilder.Entity("DatabaseOperations.Models.SyrupMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("DisableData")
                        .HasColumnType("bit");

                    b.Property<string>("SyrupDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SyrupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SyrupPrice")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("SyrupTypes");
                });

            modelBuilder.Entity("DatabaseOperations.Models.TeaMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("DisableData")
                        .HasColumnType("bit");

                    b.Property<string>("TeaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TeaPrice")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.ToTable("TeaTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
