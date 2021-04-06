﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentAPI1.Model;

namespace PaymentAPI1.Migrations
{
    [DbContext(typeof(PaymentDetailContext))]
    [Migration("20210406075338_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PaymentAPI1.Model.PaymentDetail", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CardHName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Securitycode")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("cardNo")
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("expireDate")
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("CardId");

                    b.ToTable("MyPayment");
                });
#pragma warning restore 612, 618
        }
    }
}
