using Microsoft.EntityFrameworkCore.Migrations;

namespace TransportWorkshopCore.Migrations
{
    public partial class normafueldouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutoCar_Tire_TireId",
                table: "AutoCar");

            migrationBuilder.DropForeignKey(
                name: "FK_Device_Tire_TireId",
                table: "Device");

            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_Tire_TireId",
                table: "Trailer");

            migrationBuilder.AlterColumn<double>(
                name: "Winter",
                table: "NormaFuel",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Summer",
                table: "NormaFuel",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Linear",
                table: "NormaFuel",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AutoCar_Tire_TireId",
                table: "AutoCar",
                column: "TireId",
                principalTable: "Tire",
                principalColumn: "TireId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Device_Tire_TireId",
                table: "Device",
                column: "TireId",
                principalTable: "Tire",
                principalColumn: "TireId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_Tire_TireId",
                table: "Trailer",
                column: "TireId",
                principalTable: "Tire",
                principalColumn: "TireId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutoCar_Tire_TireId",
                table: "AutoCar");

            migrationBuilder.DropForeignKey(
                name: "FK_Device_Tire_TireId",
                table: "Device");

            migrationBuilder.DropForeignKey(
                name: "FK_Trailer_Tire_TireId",
                table: "Trailer");

            migrationBuilder.AlterColumn<int>(
                name: "Winter",
                table: "NormaFuel",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Summer",
                table: "NormaFuel",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Linear",
                table: "NormaFuel",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddForeignKey(
                name: "FK_AutoCar_Tire_TireId",
                table: "AutoCar",
                column: "TireId",
                principalTable: "Tire",
                principalColumn: "TireId");

            migrationBuilder.AddForeignKey(
                name: "FK_Device_Tire_TireId",
                table: "Device",
                column: "TireId",
                principalTable: "Tire",
                principalColumn: "TireId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trailer_Tire_TireId",
                table: "Trailer",
                column: "TireId",
                principalTable: "Tire",
                principalColumn: "TireId");
        }
    }
}
