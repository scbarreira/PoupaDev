﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoupaDev.API.Persistence;

#nullable disable

namespace PoupaDev.API.Migrations
{
    [DbContext(typeof(PoupaDevContext))]
    [Migration("20220808005811_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PoupaDev.API.Entities.ObjetivoFinanceiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ValorObjetivo")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("Objetivos");
                });

            modelBuilder.Entity("PoupaDev.API.Entities.Operacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataOperacao")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdObjetivo")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.HasIndex("IdObjetivo");

                    b.ToTable("Operacao");
                });

            modelBuilder.Entity("PoupaDev.API.Entities.Operacao", b =>
                {
                    b.HasOne("PoupaDev.API.Entities.ObjetivoFinanceiro", null)
                        .WithMany("Operacoes")
                        .HasForeignKey("IdObjetivo")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("PoupaDev.API.Entities.ObjetivoFinanceiro", b =>
                {
                    b.Navigation("Operacoes");
                });
#pragma warning restore 612, 618
        }
    }
}
