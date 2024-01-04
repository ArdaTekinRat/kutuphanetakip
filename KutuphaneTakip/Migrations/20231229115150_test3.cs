using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneTakip.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OdaTipiId",
                table: "Odalars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartmanId",
                table: "Kullanicis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmanlarId",
                table: "Kullanicis",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciTipiId",
                table: "Kullanicis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KutuphaneId = table.Column<int>(type: "int", nullable: false),
                    Departman = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciTipi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciTipi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OdaTipi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdaTipi", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Odalars_OdaTipiId",
                table: "Odalars",
                column: "OdaTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_DepartmanlarId",
                table: "Kullanicis",
                column: "DepartmanlarId");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_KullaniciTipiId",
                table: "Kullanicis",
                column: "KullaniciTipiId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicis_Departmanlar_DepartmanlarId",
                table: "Kullanicis",
                column: "DepartmanlarId",
                principalTable: "Departmanlar",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicis_KullaniciTipi_KullaniciTipiId",
                table: "Kullanicis",
                column: "KullaniciTipiId",
                principalTable: "KullaniciTipi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Odalars_OdaTipi_OdaTipiId",
                table: "Odalars",
                column: "OdaTipiId",
                principalTable: "OdaTipi",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_Departmanlar_DepartmanlarId",
                table: "Kullanicis");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_KullaniciTipi_KullaniciTipiId",
                table: "Kullanicis");

            migrationBuilder.DropForeignKey(
                name: "FK_Odalars_OdaTipi_OdaTipiId",
                table: "Odalars");

            migrationBuilder.DropTable(
                name: "Departmanlar");

            migrationBuilder.DropTable(
                name: "KullaniciTipi");

            migrationBuilder.DropTable(
                name: "OdaTipi");

            migrationBuilder.DropIndex(
                name: "IX_Odalars_OdaTipiId",
                table: "Odalars");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicis_DepartmanlarId",
                table: "Kullanicis");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicis_KullaniciTipiId",
                table: "Kullanicis");

            migrationBuilder.DropColumn(
                name: "OdaTipiId",
                table: "Odalars");

            migrationBuilder.DropColumn(
                name: "DepartmanId",
                table: "Kullanicis");

            migrationBuilder.DropColumn(
                name: "DepartmanlarId",
                table: "Kullanicis");

            migrationBuilder.DropColumn(
                name: "KullaniciTipiId",
                table: "Kullanicis");
        }
    }
}
