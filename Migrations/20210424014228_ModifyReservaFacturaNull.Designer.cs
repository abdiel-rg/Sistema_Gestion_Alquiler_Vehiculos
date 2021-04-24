﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_Gestion_Alquiler_Vehiculos.Data;

namespace Sistema_Gestion_Alquiler_Vehiculos.Migrations
{
    [DbContext(typeof(SGAVContext))]
    [Migration("20210424014228_ModifyReservaFacturaNull")]
    partial class ModifyReservaFacturaNull
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Cliente", b =>
                {
                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Disponible")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FotoLicencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Licencia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nacionalidad")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoSangreID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Cedula");

                    b.HasIndex("TipoSangreID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Factura", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("MontoPagado")
                        .HasColumnType("NUMERIC");

                    b.Property<int>("ReservaID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("ReservaID");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Reserva", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CedulaCliente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("FacturaID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("TEXT");

                    b.Property<int>("VehiculoID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("CedulaCliente");

                    b.HasIndex("FacturaID");

                    b.HasIndex("VehiculoID");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.TipoSangre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("TiposSangre");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Nombre = "O-"
                        },
                        new
                        {
                            ID = 2,
                            Nombre = "O+"
                        },
                        new
                        {
                            ID = 3,
                            Nombre = "A-"
                        },
                        new
                        {
                            ID = 4,
                            Nombre = "A+"
                        },
                        new
                        {
                            ID = 5,
                            Nombre = "B-"
                        },
                        new
                        {
                            ID = 6,
                            Nombre = "B+"
                        },
                        new
                        {
                            ID = 7,
                            Nombre = "AB-"
                        },
                        new
                        {
                            ID = 8,
                            Nombre = "AB+"
                        });
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.TipoVehiculo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("TiposVehiculo");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Vehiculo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Anio")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CapacidadCarga")
                        .HasColumnType("NUMERIC");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Latitud")
                        .HasColumnType("REAL");

                    b.Property<double>("Longitud")
                        .HasColumnType("REAL");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumeroSeguro")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Pasajeros")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("PrecioPorDia")
                        .HasColumnType("NUMERIC");

                    b.Property<int>("TipoID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("TipoID");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Cliente", b =>
                {
                    b.HasOne("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.TipoSangre", "TipoSangre")
                        .WithMany("Clientes")
                        .HasForeignKey("TipoSangreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoSangre");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Factura", b =>
                {
                    b.HasOne("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Reserva", "Reserva")
                        .WithMany()
                        .HasForeignKey("ReservaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reserva");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Reserva", b =>
                {
                    b.HasOne("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Cliente", "Cliente")
                        .WithMany("Reservas")
                        .HasForeignKey("CedulaCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Factura", "Factura")
                        .WithMany()
                        .HasForeignKey("FacturaID");

                    b.HasOne("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Vehiculo", "Vehiculo")
                        .WithMany("Reservas")
                        .HasForeignKey("VehiculoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Factura");

                    b.Navigation("Vehiculo");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Vehiculo", b =>
                {
                    b.HasOne("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.TipoVehiculo", "Tipo")
                        .WithMany("Vehiculos")
                        .HasForeignKey("TipoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Cliente", b =>
                {
                    b.Navigation("Reservas");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.TipoSangre", b =>
                {
                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.TipoVehiculo", b =>
                {
                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("Sistema_Gestion_Alquiler_Vehiculos.Data.Models.Vehiculo", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
