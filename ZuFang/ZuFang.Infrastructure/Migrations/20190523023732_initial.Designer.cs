﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZuFang.Infrastructure.DataBase;

namespace ZuFang.Infrastructure.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20190523023732_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("ZuFang.Core.entities.CashFlow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("CleanCharge");

                    b.Property<DateTime>("CreationDate");

                    b.Property<float>("Electricity1");

                    b.Property<float>("Electricity2");

                    b.Property<decimal>("ElectricityCharge");

                    b.Property<int>("HouseId");

                    b.Property<decimal>("ManageCharge");

                    b.Property<decimal>("NetCharge");

                    b.Property<decimal>("Rent");

                    b.Property<int>("RoomId");

                    b.Property<float>("Water1");

                    b.Property<float>("Water2");

                    b.Property<decimal>("WaterCharge");

                    b.HasKey("Id");

                    b.ToTable("CashFlows");
                });

            modelBuilder.Entity("ZuFang.Core.entities.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Card1Charge");

                    b.Property<decimal>("Card2Charge");

                    b.Property<decimal>("CleanCharge");

                    b.Property<DateTime>("ContractDate");

                    b.Property<DateTime>("CreationDate");

                    b.Property<decimal>("Deposit");

                    b.Property<decimal>("ElectricityCharge");

                    b.Property<int>("GuestId");

                    b.Property<int>("HouseId");

                    b.Property<decimal>("KeyCharge");

                    b.Property<decimal>("ManageCharge");

                    b.Property<int>("Months");

                    b.Property<decimal>("NetCharge");

                    b.Property<string>("Remark");

                    b.Property<decimal>("Rent");

                    b.Property<string>("RoomNo");

                    b.Property<decimal>("WaterCharge");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("HouseId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("ZuFang.Core.entities.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("MobilePhone");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Guest");
                });

            modelBuilder.Entity("ZuFang.Core.entities.House", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("HouseName");

                    b.HasKey("Id");

                    b.ToTable("Houses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2019, 5, 23, 10, 37, 31, 928, DateTimeKind.Local).AddTicks(4169),
                            HouseName = "1号公寓"
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2019, 5, 23, 10, 37, 31, 928, DateTimeKind.Local).AddTicks(9152),
                            HouseName = "青年公寓"
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2019, 5, 23, 10, 37, 31, 928, DateTimeKind.Local).AddTicks(9158),
                            HouseName = "柠檬公寓"
                        });
                });

            modelBuilder.Entity("ZuFang.Core.entities.Contract", b =>
                {
                    b.HasOne("ZuFang.Core.entities.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ZuFang.Core.entities.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}