﻿// <auto-generated />
using System;
using Exchange.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace RateApi.Migrations
{
    [DbContext(typeof(ExchangeDBContext))]
    [Migration("20240421122421_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("Exchange.Data.Entity.ExchangeProvaidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Types")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Update")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("ExchangeProvaidors");
                });

            modelBuilder.Entity("Exchange.Data.Entity.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Buy")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Currecny")
                        .HasColumnType("numeric");

                    b.Property<int>("ExchangeProvaidorId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Sell")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ExchangeProvaidorId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("Exchange.Data.Entity.Rate", b =>
                {
                    b.HasOne("Exchange.Data.Entity.ExchangeProvaidor", "ExchangeProvaidor")
                        .WithMany("Rates")
                        .HasForeignKey("ExchangeProvaidorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExchangeProvaidor");
                });

            modelBuilder.Entity("Exchange.Data.Entity.ExchangeProvaidor", b =>
                {
                    b.Navigation("Rates");
                });
#pragma warning restore 612, 618
        }
    }
}
