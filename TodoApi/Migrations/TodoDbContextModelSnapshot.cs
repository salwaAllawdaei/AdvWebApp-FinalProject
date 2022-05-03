﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApi.Model;

#nullable disable

namespace TodoApi.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    partial class TodoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TodoApi.Model.ToDoAppointment", b =>
                {
                    b.Property<uint>("ToDoAppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<DateTime?>("AppointmentDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Comments")
                        .HasColumnType("longtext");

                    b.Property<int?>("Contact")
                        .HasColumnType("int");

                    b.Property<string>("CustomerNm")
                        .HasColumnType("longtext");

                    b.Property<string>("Details")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("ToDoAppointmentId");

                    b.ToTable("ToDoAppointments");
                });
#pragma warning restore 612, 618
        }
    }
}
