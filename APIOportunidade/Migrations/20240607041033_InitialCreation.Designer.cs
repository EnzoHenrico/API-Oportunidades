﻿// <auto-generated />
using System;
using APIOportunidade.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIOportunidade.Migrations
{
    [DbContext(typeof(APIOportunidadeContext))]
    [Migration("20240607041033_InitialCreation")]
    partial class InitialCreation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Oportunidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("AprendizadoNivel")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DataEntrega")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("HorasDeSono")
                        .HasColumnType("bigint");

                    b.Property<int>("HorasFolga")
                        .HasColumnType("int");

                    b.Property<string>("NivelSurto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("QtdErros")
                        .HasColumnType("bigint");

                    b.Property<int>("QtdHoras")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Oportunidade");
                });
#pragma warning restore 612, 618
        }
    }
}