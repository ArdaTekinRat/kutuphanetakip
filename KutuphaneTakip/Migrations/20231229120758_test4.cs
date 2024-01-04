using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneTakip.Migrations
{
    /// <inheritdoc />
    public partial class test4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kutuphane",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KutuphaneAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kutuphane", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_KutuphaneId",
                table: "Rezervasyons",
                column: "KutuphaneId");

            migrationBuilder.CreateIndex(
                name: "IX_OduncVerilenAyars_KutuphaneId",
                table: "OduncVerilenAyars",
                column: "KutuphaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Odalars_KutuphaneId",
                table: "Odalars",
                column: "KutuphaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplars_KutuphaneId",
                table: "Kitaplars",
                column: "KutuphaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Departmanlar_KutuphaneId",
                table: "Departmanlar",
                column: "KutuphaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departmanlar_Kutuphane_KutuphaneId",
                table: "Departmanlar",
                column: "KutuphaneId",
                principalTable: "Kutuphane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplars_Kutuphane_KutuphaneId",
                table: "Kitaplars",
                column: "KutuphaneId",
                principalTable: "Kutuphane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Odalars_Kutuphane_KutuphaneId",
                table: "Odalars",
                column: "KutuphaneId",
                principalTable: "Kutuphane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OduncVerilenAyars_Kutuphane_KutuphaneId",
                table: "OduncVerilenAyars",
                column: "KutuphaneId",
                principalTable: "Kutuphane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyons_Kutuphane_KutuphaneId",
                table: "Rezervasyons",
                column: "KutuphaneId",
                principalTable: "Kutuphane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departmanlar_Kutuphane_KutuphaneId",
                table: "Departmanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplars_Kutuphane_KutuphaneId",
                table: "Kitaplars");

            migrationBuilder.DropForeignKey(
                name: "FK_Odalars_Kutuphane_KutuphaneId",
                table: "Odalars");

            migrationBuilder.DropForeignKey(
                name: "FK_OduncVerilenAyars_Kutuphane_KutuphaneId",
                table: "OduncVerilenAyars");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyons_Kutuphane_KutuphaneId",
                table: "Rezervasyons");

            migrationBuilder.DropTable(
                name: "Kutuphane");

            migrationBuilder.DropIndex(
                name: "IX_Rezervasyons_KutuphaneId",
                table: "Rezervasyons");

            migrationBuilder.DropIndex(
                name: "IX_OduncVerilenAyars_KutuphaneId",
                table: "OduncVerilenAyars");

            migrationBuilder.DropIndex(
                name: "IX_Odalars_KutuphaneId",
                table: "Odalars");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplars_KutuphaneId",
                table: "Kitaplars");

            migrationBuilder.DropIndex(
                name: "IX_Departmanlar_KutuphaneId",
                table: "Departmanlar");
        }
    }
}
