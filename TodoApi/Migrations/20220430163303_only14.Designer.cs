﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoApi.Model;

#nullable disable

namespace TodoApi.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20220430163303_only14")]
    partial class only14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Appointment")
                        .HasColumnType("longtext");

                    b.Property<int?>("Cont")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("details")
                        .HasColumnType("longtext");

                    b.HasKey("ToDoAppointmentId");

                    b.ToTable("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
