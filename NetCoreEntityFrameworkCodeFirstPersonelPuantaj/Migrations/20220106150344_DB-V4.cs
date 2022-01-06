using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Migrations
{
    public partial class DBV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarsambaId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "CumaId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "CumartesiId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "PazarId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "PazartesiId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "PersembeId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "SaliId",
                table: "Personel");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CarsambaId",
                table: "Personel",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CumaId",
                table: "Personel",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CumartesiId",
                table: "Personel",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PazarId",
                table: "Personel",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PazartesiId",
                table: "Personel",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersembeId",
                table: "Personel",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaliId",
                table: "Personel",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
