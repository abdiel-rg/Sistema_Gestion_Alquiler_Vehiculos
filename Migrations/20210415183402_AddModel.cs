using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Gestion_Alquiler_Vehiculos.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposSangre",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposSangre", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TiposVehiculo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposVehiculo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Cedula = table.Column<string>(type: "TEXT", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Apellido = table.Column<string>(type: "TEXT", nullable: true),
                    Correo = table.Column<string>(type: "TEXT", nullable: true),
                    Licencia = table.Column<string>(type: "TEXT", nullable: true),
                    FotoLicencia = table.Column<string>(type: "TEXT", nullable: true),
                    Nacionalidad = table.Column<string>(type: "TEXT", nullable: true),
                    TipoSangreID = table.Column<int>(type: "INTEGER", nullable: false),
                    Foto = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Cedula);
                    table.ForeignKey(
                        name: "FK_Clientes_TiposSangre_TipoSangreID",
                        column: x => x.TipoSangreID,
                        principalTable: "TiposSangre",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Matricula = table.Column<string>(type: "TEXT", nullable: true),
                    Marca = table.Column<string>(type: "TEXT", nullable: true),
                    Modelo = table.Column<string>(type: "TEXT", nullable: true),
                    Anio = table.Column<string>(type: "TEXT", nullable: true),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    PrecioPorDia = table.Column<decimal>(type: "NUMERIC", nullable: false),
                    TipoID = table.Column<int>(type: "INTEGER", nullable: false),
                    CapacidadCarga = table.Column<decimal>(type: "NUMERIC", nullable: false),
                    Pasajeros = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroSeguro = table.Column<string>(type: "TEXT", nullable: true),
                    Foto = table.Column<string>(type: "TEXT", nullable: true),
                    Latitud = table.Column<string>(type: "TEXT", nullable: true),
                    Longitud = table.Column<string>(type: "TEXT", nullable: true),
                    Disponible = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vehiculos_TiposVehiculo_TipoID",
                        column: x => x.TipoID,
                        principalTable: "TiposVehiculo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VehiculoID = table.Column<int>(type: "INTEGER", nullable: false),
                    CedulaCliente = table.Column<string>(type: "TEXT", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FacturaID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reservas_Clientes_CedulaCliente",
                        column: x => x.CedulaCliente,
                        principalTable: "Clientes",
                        principalColumn: "Cedula",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservas_Vehiculos_VehiculoID",
                        column: x => x.VehiculoID,
                        principalTable: "Vehiculos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MontoPagado = table.Column<decimal>(type: "NUMERIC", nullable: false),
                    ReservaID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Facturas_Reservas_ReservaID",
                        column: x => x.ReservaID,
                        principalTable: "Reservas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TipoSangreID",
                table: "Clientes",
                column: "TipoSangreID");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ReservaID",
                table: "Facturas",
                column: "ReservaID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_CedulaCliente",
                table: "Reservas",
                column: "CedulaCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_FacturaID",
                table: "Reservas",
                column: "FacturaID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservas_VehiculoID",
                table: "Reservas",
                column: "VehiculoID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TipoID",
                table: "Vehiculos",
                column: "TipoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Facturas_FacturaID",
                table: "Reservas",
                column: "FacturaID",
                principalTable: "Facturas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_TiposSangre_TipoSangreID",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Reservas_ReservaID",
                table: "Facturas");

            migrationBuilder.DropTable(
                name: "TiposSangre");

            migrationBuilder.DropTable(
                name: "Reservas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "TiposVehiculo");
        }
    }
}
