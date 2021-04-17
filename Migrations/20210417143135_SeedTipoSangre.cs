using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Gestion_Alquiler_Vehiculos.Migrations
{
    public partial class SeedTipoSangre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TiposSangre",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 1, "O-" });

            migrationBuilder.InsertData(
                table: "TiposSangre",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 2, "O+" });

            migrationBuilder.InsertData(
                table: "TiposSangre",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 3, "A-" });

            migrationBuilder.InsertData(
                table: "TiposSangre",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 4, "A+" });

            migrationBuilder.InsertData(
                table: "TiposSangre",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 5, "B-" });

            migrationBuilder.InsertData(
                table: "TiposSangre",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 6, "B+" });

            migrationBuilder.InsertData(
                table: "TiposSangre",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 7, "AB-" });

            migrationBuilder.InsertData(
                table: "TiposSangre",
                columns: new[] { "ID", "Nombre" },
                values: new object[] { 8, "AB+" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TiposSangre",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TiposSangre",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TiposSangre",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TiposSangre",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TiposSangre",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TiposSangre",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TiposSangre",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TiposSangre",
                keyColumn: "ID",
                keyValue: 8);
        }
    }
}
