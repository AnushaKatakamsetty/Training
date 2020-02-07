﻿// <auto-generated />
using EMartCaseStudyMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMartCaseStudyMVC.Migrations.Seller
{
    [DbContext(typeof(SellerContext))]
    partial class SellerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMartCaseStudyMVC.Models.Seller", b =>
                {
                    b.Property<int>("sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("saboucompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("saddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scompanyname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("semailid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sgstin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("smobileno")
                        .HasColumnType("bigint");

                    b.Property<string>("sname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("spassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("swebsite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("sid");

                    b.ToTable("Seller");
                });
#pragma warning restore 612, 618
        }
    }
}