﻿// <auto-generated />
using System;
using Exercice01Personnage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exercice01Personnage.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240118153306_Exercice01Personnage")]
    partial class Exercice01Personnage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Exercice01Personnage.Models.Personnage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Armure")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<int>("Degats")
                        .HasColumnType("int");

                    b.Property<int>("NombrePersonneTues")
                        .HasColumnType("int");

                    b.Property<int>("PointsDeVie")
                        .HasColumnType("int");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personnages");
                });
#pragma warning restore 612, 618
        }
    }
}
