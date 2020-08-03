﻿// <auto-generated />
using System;
using AppleStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppleStore.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200803090256_DiscountAdding")]
    partial class DiscountAdding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppleStore.Models.AirPods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AirPodsModel");

                    b.Property<int>("AmountOfProduct");

                    b.Property<string>("Description");

                    b.Property<float>("Price");

                    b.Property<string>("WirelessCharging");

                    b.Property<int>("YearOfProduction");

                    b.HasKey("Id");

                    b.ToTable("AirPodses");
                });

            modelBuilder.Entity("AppleStore.Models.AppleWatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountOfProduct");

                    b.Property<string>("AppleWatchModel");

                    b.Property<string>("Cellular");

                    b.Property<string>("Color");

                    b.Property<string>("Description");

                    b.Property<string>("Gps");

                    b.Property<string>("HousingMaterial");

                    b.Property<float>("Price");

                    b.Property<int>("ScreenSize");

                    b.Property<string>("StrapType");

                    b.HasKey("Id");

                    b.ToTable("AppleWatches");
                });

            modelBuilder.Entity("AppleStore.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount");

                    b.Property<DateTime>("AvailableTill");

                    b.Property<string>("Code");

                    b.Property<bool>("IsUsed");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("AppleStore.Models.IPad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountOfProduct");

                    b.Property<string>("Color");

                    b.Property<string>("Description");

                    b.Property<int>("FrontCamera");

                    b.Property<string>("IPadModel");

                    b.Property<string>("MainCamera");

                    b.Property<string>("Memory");

                    b.Property<float>("Price");

                    b.Property<string>("Processor");

                    b.Property<int>("Ram");

                    b.Property<float>("ScreenSize");

                    b.Property<string>("ScreenType");

                    b.Property<string>("Type");

                    b.Property<string>("TypeOfModel");

                    b.Property<int>("YearOfProduction");

                    b.HasKey("Id");

                    b.ToTable("IPads");
                });

            modelBuilder.Entity("AppleStore.Models.IPhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountOfProduct");

                    b.Property<int>("BatteryCapacity");

                    b.Property<string>("Color");

                    b.Property<string>("Description");

                    b.Property<int>("FrontCamera");

                    b.Property<string>("IPhoneModel");

                    b.Property<string>("MainCamera");

                    b.Property<string>("Memory");

                    b.Property<float>("Price");

                    b.Property<string>("Processor");

                    b.Property<int>("Ram");

                    b.Property<float>("ScreenSize");

                    b.Property<string>("ScreenType");

                    b.Property<string>("UhdRecording");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("IPhones");
                });

            modelBuilder.Entity("AppleStore.Models.Mac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountOfProduct");

                    b.Property<string>("Color");

                    b.Property<string>("Description");

                    b.Property<string>("DriveCapacity");

                    b.Property<int>("KernelsAmount");

                    b.Property<string>("MacModel");

                    b.Property<string>("Memory");

                    b.Property<float>("Price");

                    b.Property<string>("Processor");

                    b.Property<int>("Ram");

                    b.Property<float>("ScreenSize");

                    b.Property<string>("SsdCapacity");

                    b.Property<string>("Type");

                    b.Property<string>("VideoCard");

                    b.Property<int>("YearOfProduction");

                    b.HasKey("Id");

                    b.ToTable("Macs");
                });

            modelBuilder.Entity("AppleStore.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BoughtProds");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<float>("TotalPrice");

                    b.HasKey("Id");

                    b.ToTable("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}
