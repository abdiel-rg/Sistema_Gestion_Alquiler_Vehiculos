using Microsoft.EntityFrameworkCore.Migrations;

namespace Sistema_Gestion_Alquiler_Vehiculos.Migrations
{
    public partial class ModifyReservaFacturaNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_CedulaCliente",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Facturas_FacturaID",
                table: "Reservas");

            migrationBuilder.AlterColumn<int>(
                name: "FacturaID",
                table: "Reservas",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "CedulaCliente",
                table: "Reservas",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_CedulaCliente",
                table: "Reservas",
                column: "CedulaCliente",
                principalTable: "Clientes",
                principalColumn: "Cedula",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Facturas_FacturaID",
                table: "Reservas",
                column: "FacturaID",
                principalTable: "Facturas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_CedulaCliente",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Facturas_FacturaID",
                table: "Reservas");

            migrationBuilder.AlterColumn<int>(
                name: "FacturaID",
                table: "Reservas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CedulaCliente",
                table: "Reservas",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_CedulaCliente",
                table: "Reservas",
                column: "CedulaCliente",
                principalTable: "Clientes",
                principalColumn: "Cedula",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Facturas_FacturaID",
                table: "Reservas",
                column: "FacturaID",
                principalTable: "Facturas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
