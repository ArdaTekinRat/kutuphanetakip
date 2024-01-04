using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneTakip.Migrations
{
    /// <inheritdoc />
    public partial class test5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departmanlar_Kutuphane_KutuphaneId",
                table: "Departmanlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplars_Kutuphane_KutuphaneId",
                table: "Kitaplars");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_Departmanlar_DepartmanlarId",
                table: "Kullanicis");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_KullaniciTipi_KullaniciTipiId",
                table: "Kullanicis");

            migrationBuilder.DropForeignKey(
                name: "FK_Odalars_Kutuphane_KutuphaneId",
                table: "Odalars");

            migrationBuilder.DropForeignKey(
                name: "FK_Odalars_OdaTipi_OdaTipiId",
                table: "Odalars");

            migrationBuilder.DropForeignKey(
                name: "FK_OduncVerilenAyars_Kutuphane_KutuphaneId",
                table: "OduncVerilenAyars");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyons_Kutuphane_KutuphaneId",
                table: "Rezervasyons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OdaTipi",
                table: "OdaTipi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kutuphane",
                table: "Kutuphane");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KullaniciTipi",
                table: "KullaniciTipi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departmanlar",
                table: "Departmanlar");

            migrationBuilder.RenameTable(
                name: "OdaTipi",
                newName: "OdaTipis");

            migrationBuilder.RenameTable(
                name: "Kutuphane",
                newName: "Kutuphanes");

            migrationBuilder.RenameTable(
                name: "KullaniciTipi",
                newName: "KullaniciTipis");

            migrationBuilder.RenameTable(
                name: "Departmanlar",
                newName: "Departmanlars");

            migrationBuilder.RenameIndex(
                name: "IX_Departmanlar_KutuphaneId",
                table: "Departmanlars",
                newName: "IX_Departmanlars_KutuphaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OdaTipis",
                table: "OdaTipis",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kutuphanes",
                table: "Kutuphanes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KullaniciTipis",
                table: "KullaniciTipis",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departmanlars",
                table: "Departmanlars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departmanlars_Kutuphanes_KutuphaneId",
                table: "Departmanlars",
                column: "KutuphaneId",
                principalTable: "Kutuphanes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplars_Kutuphanes_KutuphaneId",
                table: "Kitaplars",
                column: "KutuphaneId",
                principalTable: "Kutuphanes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicis_Departmanlars_DepartmanlarId",
                table: "Kullanicis",
                column: "DepartmanlarId",
                principalTable: "Departmanlars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicis_KullaniciTipis_KullaniciTipiId",
                table: "Kullanicis",
                column: "KullaniciTipiId",
                principalTable: "KullaniciTipis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Odalars_Kutuphanes_KutuphaneId",
                table: "Odalars",
                column: "KutuphaneId",
                principalTable: "Kutuphanes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Odalars_OdaTipis_OdaTipiId",
                table: "Odalars",
                column: "OdaTipiId",
                principalTable: "OdaTipis",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OduncVerilenAyars_Kutuphanes_KutuphaneId",
                table: "OduncVerilenAyars",
                column: "KutuphaneId",
                principalTable: "Kutuphanes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervasyons_Kutuphanes_KutuphaneId",
                table: "Rezervasyons",
                column: "KutuphaneId",
                principalTable: "Kutuphanes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departmanlars_Kutuphanes_KutuphaneId",
                table: "Departmanlars");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplars_Kutuphanes_KutuphaneId",
                table: "Kitaplars");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_Departmanlars_DepartmanlarId",
                table: "Kullanicis");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_KullaniciTipis_KullaniciTipiId",
                table: "Kullanicis");

            migrationBuilder.DropForeignKey(
                name: "FK_Odalars_Kutuphanes_KutuphaneId",
                table: "Odalars");

            migrationBuilder.DropForeignKey(
                name: "FK_Odalars_OdaTipis_OdaTipiId",
                table: "Odalars");

            migrationBuilder.DropForeignKey(
                name: "FK_OduncVerilenAyars_Kutuphanes_KutuphaneId",
                table: "OduncVerilenAyars");

            migrationBuilder.DropForeignKey(
                name: "FK_Rezervasyons_Kutuphanes_KutuphaneId",
                table: "Rezervasyons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OdaTipis",
                table: "OdaTipis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kutuphanes",
                table: "Kutuphanes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_KullaniciTipis",
                table: "KullaniciTipis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departmanlars",
                table: "Departmanlars");

            migrationBuilder.RenameTable(
                name: "OdaTipis",
                newName: "OdaTipi");

            migrationBuilder.RenameTable(
                name: "Kutuphanes",
                newName: "Kutuphane");

            migrationBuilder.RenameTable(
                name: "KullaniciTipis",
                newName: "KullaniciTipi");

            migrationBuilder.RenameTable(
                name: "Departmanlars",
                newName: "Departmanlar");

            migrationBuilder.RenameIndex(
                name: "IX_Departmanlars_KutuphaneId",
                table: "Departmanlar",
                newName: "IX_Departmanlar_KutuphaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OdaTipi",
                table: "OdaTipi",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kutuphane",
                table: "Kutuphane",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_KullaniciTipi",
                table: "KullaniciTipi",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departmanlar",
                table: "Departmanlar",
                column: "Id");

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
                name: "FK_Odalars_Kutuphane_KutuphaneId",
                table: "Odalars",
                column: "KutuphaneId",
                principalTable: "Kutuphane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Odalars_OdaTipi_OdaTipiId",
                table: "Odalars",
                column: "OdaTipiId",
                principalTable: "OdaTipi",
                principalColumn: "Id");

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
    }
}
