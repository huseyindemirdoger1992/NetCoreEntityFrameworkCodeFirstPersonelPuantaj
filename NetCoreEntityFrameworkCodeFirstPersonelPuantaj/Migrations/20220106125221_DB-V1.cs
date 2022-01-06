using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreEntityFrameworkCodeFirstPersonelPuantaj.Migrations
{
    public partial class DBV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departman",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(nullable: true),
                    Aciklama = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departman", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Pazartesi = table.Column<string>(nullable: true),
                    PazartesiId = table.Column<string>(nullable: true),
                    Sali = table.Column<string>(nullable: true),
                    SaliId = table.Column<string>(nullable: true),
                    Carsamba = table.Column<string>(nullable: true),
                    CarsambaId = table.Column<string>(nullable: true),
                    Persembe = table.Column<string>(nullable: true),
                    PersembeId = table.Column<string>(nullable: true),
                    Cuma = table.Column<string>(nullable: true),
                    CumaId = table.Column<string>(nullable: true),
                    Cumartesi = table.Column<string>(nullable: true),
                    CumartesiId = table.Column<string>(nullable: true),
                    Pazar = table.Column<string>(nullable: true),
                    PazarId = table.Column<string>(nullable: true),
                    DepatmanId = table.Column<int>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vardiya",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vardiya", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departman");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "Vardiya");
        }
    }
}
