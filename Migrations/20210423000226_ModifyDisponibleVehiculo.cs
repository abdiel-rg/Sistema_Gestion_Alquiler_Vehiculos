using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Gestion_Alquiler_Vehiculos.Migrations
{
    public partial class ModifyDisponibleVehiculo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponible",
                table: "Vehiculos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Disponible",
                table: "Vehiculos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
