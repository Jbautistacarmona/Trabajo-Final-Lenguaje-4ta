﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PRIMERA_API.Data;

#nullable disable

namespace PRIMERA_API.Migrations
{
    [DbContext(typeof(PARCIAL1Context))]
    [Migration("20231204015623_mssql.local_migration_931")]
    partial class mssqllocal_migration_931
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PRIMERA_API.Data.Models.Alquiler", b =>
                {
                    b.Property<int>("AlquilerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AlquilerID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlquilerID"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int")
                        .HasColumnName("ClienteID");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MontoCobro")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("TipoVehiculoID")
                        .HasColumnType("int")
                        .HasColumnName("TipoVehiculoID");

                    b.HasKey("AlquilerID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("TipoVehiculoID");

                    b.ToTable("Alquiler");
                });

            modelBuilder.Entity("PRIMERA_API.Data.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ClienteID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Email");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Nombre");

                    b.Property<string>("Telefono")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Telefono");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("PRIMERA_API.Data.Models.Tipovehiculo", b =>
                {
                    b.Property<int>("TipoVehiculoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TipoVehiculoID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoVehiculoID"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Nombre");

                    b.Property<decimal>("TarifaPorDia")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("TarifaPorDia");

                    b.HasKey("TipoVehiculoID");

                    b.ToTable("TipoVehiculo");
                });

            modelBuilder.Entity("PRIMERA_API.Data.Models.Alquiler", b =>
                {
                    b.HasOne("PRIMERA_API.Data.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("PRIMERA_API.Data.Models.Tipovehiculo", "Tipovehiculo")
                        .WithMany()
                        .HasForeignKey("TipoVehiculoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Tipovehiculo");
                });
#pragma warning restore 612, 618
        }
    }
}
