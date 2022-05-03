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
    [Migration("20220430030409_on")]
    partial class on
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TodoApi.Model.TodoItem", b =>
                {
                    b.Property<uint>("TodoItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<DateTime?>("Deadline")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Instructions")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Reward")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Task")
                        .HasColumnType("longtext");

                    b.HasKey("TodoItemId");

                    b.ToTable("TodoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
