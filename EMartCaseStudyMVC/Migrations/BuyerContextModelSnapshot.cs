﻿// <auto-generated />
using EMartCaseStudyMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMartCaseStudyMVC.Migrations
{
    [DbContext(typeof(BuyerContext))]
    partial class BuyerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMartCaseStudyMVC.Models.Buyer", b =>
                {
                    b.Property<int>("bId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mailid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobileno")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bUname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("bId");

                    b.ToTable("Buyers");
                });
#pragma warning restore 612, 618
        }
    }
}
