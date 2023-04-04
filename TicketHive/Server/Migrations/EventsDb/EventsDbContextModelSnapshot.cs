﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketHive.Server.Data;

#nullable disable

namespace TicketHive.Server.Migrations.EventsDb
{
    [DbContext(typeof(EventsDbContext))]
    partial class EventsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventModelUserModel", b =>
                {
                    b.Property<int>("EventUsersId")
                        .HasColumnType("int");

                    b.Property<int>("UserEventsId")
                        .HasColumnType("int");

                    b.HasKey("EventUsersId", "UserEventsId");

                    b.HasIndex("UserEventsId");

                    b.ToTable("EventModelUserModel");
                });

            modelBuilder.Entity("TicketHive.Shared.Models.EventModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSoldOut")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Venue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 3000,
                            Date = new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "images/event/img1.avif",
                            IsSoldOut = false,
                            Name = "Justin Bieber",
                            Price = 800,
                            Type = 1,
                            Venue = "Malmö Arena"
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 22000,
                            Date = new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "images/event/img2.avif",
                            IsSoldOut = false,
                            Name = "Malmö FF - IFK Göteborg",
                            Price = 230,
                            Type = 0,
                            Venue = "Eleda Stadion"
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 550,
                            Date = new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "images/event/img3.avif",
                            IsSoldOut = false,
                            Name = "Johan Glans Tour",
                            Price = 400,
                            Type = 3,
                            Venue = "Palladium"
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 13000,
                            Date = new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "images/event/img4.avif",
                            IsSoldOut = false,
                            Name = "Big Slap",
                            Price = 700,
                            Type = 2,
                            Venue = "Pildammsparken"
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 60,
                            Date = new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "images/event/img5.avif",
                            IsSoldOut = false,
                            Name = "Doris & Knäckebröderna",
                            Price = 100,
                            Type = 4,
                            Venue = "Stadsbiblioteket Malmö"
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 26000,
                            Date = new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "images/event/img6.avif",
                            IsSoldOut = false,
                            Name = "Tom Jones",
                            Price = 800,
                            Type = 1,
                            Venue = "Parken Copenhagen"
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 34,
                            Date = new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "images/event/img7.avif",
                            IsSoldOut = false,
                            Name = "World Padel Tour",
                            Price = 40,
                            Type = 0,
                            Venue = "Helsingborg"
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 26000,
                            Date = new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "images/event/img8.avif",
                            IsSoldOut = false,
                            Name = "Flashback Forever Live Pod",
                            Price = 200,
                            Type = 3,
                            Venue = "Globen"
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 300,
                            Date = new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "images/event/img9.avif",
                            IsSoldOut = false,
                            Name = "Babblarna The Musical",
                            Price = 120,
                            Type = 4,
                            Venue = "Malmö Live"
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 12000,
                            Date = new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "images/event/img10.avif",
                            IsSoldOut = false,
                            Name = "Sweden Rock",
                            Price = 500,
                            Type = 2,
                            Venue = "Norje"
                        });
                });

            modelBuilder.Entity("TicketHive.Shared.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Username = "user"
                        });
                });

            modelBuilder.Entity("EventModelUserModel", b =>
                {
                    b.HasOne("TicketHive.Shared.Models.UserModel", null)
                        .WithMany()
                        .HasForeignKey("EventUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketHive.Shared.Models.EventModel", null)
                        .WithMany()
                        .HasForeignKey("UserEventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
