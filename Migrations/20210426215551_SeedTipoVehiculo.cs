using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Gestion_Alquiler_Vehiculos.Migrations
{
    public partial class SeedTipoVehiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TiposVehiculo",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 1, "Automóvil" });

            migrationBuilder.InsertData(
                table: "TiposVehiculo",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 2, "Camioneta" });

            migrationBuilder.InsertData(
                table: "TiposVehiculo",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 3, "Motocicleta" });

            migrationBuilder.InsertData(
                table: "TiposVehiculo",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 4, "Barco" });

            migrationBuilder.InsertData(
                table: "TiposVehiculo",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 5, "Avión" });

            migrationBuilder.InsertData(
                table: "TiposVehiculo",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 6, "Cohete" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TiposVehiculo",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposVehiculo",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposVehiculo",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposVehiculo",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TiposVehiculo",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TiposVehiculo",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
