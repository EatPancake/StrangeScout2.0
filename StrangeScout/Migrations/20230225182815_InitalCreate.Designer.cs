﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StrangeScout.Data;

#nullable disable

namespace StrangeScout.Migrations
{
    [DbContext(typeof(StrangeScoutContext))]
    [Migration("20230225182815_InitalCreate")]
    partial class InitalCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("StrangeScout.Models.Matches", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bot")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bot_A")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bot_E")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BotsEngaged")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Center")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Center_A")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Center_E")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cones")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cones_A")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cones_E")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cubes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cubes_A")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cubes_E")
                        .HasColumnType("INTEGER");

                    b.Property<float>("CycleTime")
                        .HasColumnType("REAL");

                    b.Property<int>("DoubleSubstation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoubleSubstation_A")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoubleSubstation_E")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Engaged")
                        .HasColumnType("TEXT");

                    b.Property<string>("Engaged_A")
                        .HasColumnType("TEXT");

                    b.Property<string>("Event")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Mid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mid_A")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mid_E")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mobility")
                        .HasColumnType("TEXT");

                    b.Property<string>("Parked")
                        .HasColumnType("TEXT");

                    b.Property<int>("Points")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Round")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SingleSubstation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SingleSubstation_A")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SingleSubstation_E")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeamNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Top")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Top_A")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Top_E")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}