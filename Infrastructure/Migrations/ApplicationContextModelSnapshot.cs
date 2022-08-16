﻿// <auto-generated />
using System;
using Infrastructure.DBConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1e144519-01ea-4adf-9cf3-bd50a4949558"),
                            CreatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9782),
                            Day = 1,
                            Ingredients = "Spaghetti, olive oil, garlic",
                            Name = "Spaghetti aglio y oleo",
                            UpdatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9782)
                        },
                        new
                        {
                            Id = new Guid("1dc83e82-402d-4b4c-b7cd-33fe3add0f22"),
                            CreatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9841),
                            Day = 2,
                            Ingredients = "Spaghetti, olive oil, garlic, lentils",
                            Name = "Spaghetti with lentils",
                            UpdatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9841)
                        },
                        new
                        {
                            Id = new Guid("1153e59d-746b-4842-a364-5d9b941acb97"),
                            CreatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9849),
                            Day = 3,
                            Ingredients = "Spaghetti, olive oil, garlic, cauliflower, chickpeas",
                            Name = "Spaghetti with cauliflower sauce and chickpeas",
                            UpdatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9849)
                        },
                        new
                        {
                            Id = new Guid("b0f3852e-3a19-4d6a-83eb-452aa68ce15d"),
                            CreatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9855),
                            Day = 4,
                            Ingredients = "Rice, lentils, potato, peas,carrpts",
                            Name = "Risotto",
                            UpdatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9855)
                        },
                        new
                        {
                            Id = new Guid("7684803c-a4e6-4817-899a-91816a5b2783"),
                            CreatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9862),
                            Day = 5,
                            Ingredients = "Margherita or mussarela",
                            Name = "Pizza",
                            UpdatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9862)
                        },
                        new
                        {
                            Id = new Guid("d209f1a7-0730-4e0a-bb5f-75db00232db1"),
                            CreatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9870),
                            Day = 6,
                            Ingredients = "gohan, tofu, mushrooms,soy sauce, spring onion, fried eggplant, courgette ",
                            Name = "Donburi",
                            UpdatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9870)
                        },
                        new
                        {
                            Id = new Guid("79a66486-ae5c-45e8-8386-04227c2c228e"),
                            CreatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9877),
                            Day = 7,
                            Ingredients = "hamburger of chickpeas, lentils, beans, soy",
                            Name = "Hamburger",
                            UpdatedAt = new DateTime(2022, 8, 16, 17, 16, 12, 442, DateTimeKind.Local).AddTicks(9877)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
