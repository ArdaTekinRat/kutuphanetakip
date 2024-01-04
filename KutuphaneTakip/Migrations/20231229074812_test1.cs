using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneTakip.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sokak = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bina = table.Column<int>(type: "int", nullable: false),
                    Kat = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_AdresId",
                table: "Kullanicis",
                column: "AdresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicis_Adres_AdresId",
                table: "Kullanicis",
                column: "AdresId",
                principalTable: "Adres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_Adres_AdresId",
                table: "Kullanicis");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicis_AdresId",
                table: "Kullanicis");
        }
    }
}
