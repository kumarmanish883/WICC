﻿// <auto-generated />
using AjaxMVCCoreCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AjaxMVCCoreCRUD.Migrations
{
    [DbContext(typeof(AjaxDbContext))]
    [Migration("20220305025128_CreateDatabae")]
    partial class CreateDatabae
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AjaxMVCCoreCRUD.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Category")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Code")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
