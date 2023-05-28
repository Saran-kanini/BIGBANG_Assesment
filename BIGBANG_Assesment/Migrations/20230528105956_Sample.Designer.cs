﻿// <auto-generated />
using System;
using BIGBANG_Assesment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BIGBANG_Assesment.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20230528105956_Sample")]
    partial class Sample
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BIGBANG_Assesment.Models.Customer", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BIGBANG_Assesment.Models.Hotel", b =>
                {
                    b.Property<int>("Hotel_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Hotel_Id"), 1L, 1);

                    b.Property<string>("Hotel_Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hotel_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Hotel_Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("BIGBANG_Assesment.Models.Reservation", b =>
                {
                    b.Property<int>("Reservation_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Reservation_Id"), 1L, 1);

                    b.Property<int?>("CustomerUserId")
                        .HasColumnType("int");

                    b.Property<string>("Hotel_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Reservation_Id");

                    b.HasIndex("CustomerUserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("BIGBANG_Assesment.Models.Room", b =>
                {
                    b.Property<int?>("Room_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Room_Id"), 1L, 1);

                    b.Property<string>("Availability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("Hotel_Id")
                        .HasColumnType("int");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Room_Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Room_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Room_Id");

                    b.HasIndex("Hotel_Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("BIGBANG_Assesment.Models.Reservation", b =>
                {
                    b.HasOne("BIGBANG_Assesment.Models.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerUserId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BIGBANG_Assesment.Models.Room", b =>
                {
                    b.HasOne("BIGBANG_Assesment.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("Hotel_Id");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("BIGBANG_Assesment.Models.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("BIGBANG_Assesment.Models.Hotel", b =>
                {
                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
