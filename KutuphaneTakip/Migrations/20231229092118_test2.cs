using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KutuphaneTakip.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_Adres_AdresId",
                table: "Kullanicis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adres",
                table: "Adres");

            migrationBuilder.RenameTable(
                name: "Adres",
                newName: "Adress");

            migrationBuilder.RenameColumn(
                name: "Erisebilirlik",
                table: "Kullanicis",
                newName: "ErisebilirlikId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adress",
                table: "Adress",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "DilTurleris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dil = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DilTurleris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Erisebilirliks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yetki = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Erisebilirliks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeriBildirims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sms = table.Column<int>(type: "int", nullable: false),
                    Bildiri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tarih = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeriBildirims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeriBildirims_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KitapTurleris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turler = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KitapTurleris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Odalars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KutuphaneId = table.Column<int>(type: "int", nullable: false),
                    OdatipId = table.Column<int>(type: "int", nullable: false),
                    OdaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odalars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OduncDurumlaris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OduncDurumlaris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OduncVerilenAyars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UzatmaSiniri = table.Column<int>(type: "int", nullable: false),
                    GetirmeSiniri = table.Column<int>(type: "int", nullable: false),
                    KutuphaneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OduncVerilenAyars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rezervasyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KutuphaneId = table.Column<int>(type: "int", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<int>(type: "int", nullable: false),
                    Gun = table.Column<int>(type: "int", nullable: false),
                    Saat = table.Column<int>(type: "int", nullable: false),
                    Masa = table.Column<int>(type: "int", nullable: false),
                    Oda = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervasyons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rezervasyons_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yayinevis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayineviAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yayinevis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yazars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KutuphaneId = table.Column<int>(type: "int", nullable: false),
                    KitapAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KitapTuruId = table.Column<int>(type: "int", nullable: false),
                    KitapTurleriId = table.Column<int>(type: "int", nullable: true),
                    SayfaSayisi = table.Column<int>(type: "int", nullable: false),
                    BasimTarihi = table.Column<int>(type: "int", nullable: false),
                    DilId = table.Column<int>(type: "int", nullable: false),
                    DilTurleriId = table.Column<int>(type: "int", nullable: true),
                    YazarId = table.Column<int>(type: "int", nullable: false),
                    YayinEviId = table.Column<int>(type: "int", nullable: false),
                    KitapNo = table.Column<int>(type: "int", nullable: false),
                    RafNo = table.Column<int>(type: "int", nullable: false),
                    Stok = table.Column<int>(type: "int", nullable: false),
                    Guvenligi = table.Column<bool>(type: "bit", nullable: false),
                    QRKod = table.Column<int>(type: "int", nullable: false),
                    ErisebilirlikId = table.Column<int>(type: "int", nullable: false),
                    GelisTarihi = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kitaplars_DilTurleris_DilTurleriId",
                        column: x => x.DilTurleriId,
                        principalTable: "DilTurleris",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kitaplars_Erisebilirliks_ErisebilirlikId",
                        column: x => x.ErisebilirlikId,
                        principalTable: "Erisebilirliks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplars_KitapTurleris_KitapTurleriId",
                        column: x => x.KitapTurleriId,
                        principalTable: "KitapTurleris",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kitaplars_Yayinevis_YayinEviId",
                        column: x => x.YayinEviId,
                        principalTable: "Yayinevis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplars_Yazars_YazarId",
                        column: x => x.YazarId,
                        principalTable: "Yazars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OduncVerilenKitaplars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KıtapId = table.Column<int>(type: "int", nullable: false),
                    KitaplarId = table.Column<int>(type: "int", nullable: true),
                    DurumId = table.Column<int>(type: "int", nullable: false),
                    OduncDurumlariId = table.Column<int>(type: "int", nullable: true),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    KalanZaman = table.Column<int>(type: "int", nullable: false),
                    KitapAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlindigiTarih = table.Column<int>(type: "int", nullable: false),
                    VerilecegiTarih = table.Column<int>(type: "int", nullable: false),
                    Guvenlik = table.Column<bool>(type: "bit", nullable: false),
                    Cezasi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OduncVerilenKitaplars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OduncVerilenKitaplars_Kitaplars_KitaplarId",
                        column: x => x.KitaplarId,
                        principalTable: "Kitaplars",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OduncVerilenKitaplars_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OduncVerilenKitaplars_OduncDurumlaris_OduncDurumlariId",
                        column: x => x.OduncDurumlariId,
                        principalTable: "OduncDurumlaris",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicis_ErisebilirlikId",
                table: "Kullanicis",
                column: "ErisebilirlikId");

            migrationBuilder.CreateIndex(
                name: "IX_GeriBildirims_KullaniciId",
                table: "GeriBildirims",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplars_DilTurleriId",
                table: "Kitaplars",
                column: "DilTurleriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplars_ErisebilirlikId",
                table: "Kitaplars",
                column: "ErisebilirlikId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplars_KitapTurleriId",
                table: "Kitaplars",
                column: "KitapTurleriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplars_YayinEviId",
                table: "Kitaplars",
                column: "YayinEviId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplars_YazarId",
                table: "Kitaplars",
                column: "YazarId");

            migrationBuilder.CreateIndex(
                name: "IX_OduncVerilenKitaplars_KitaplarId",
                table: "OduncVerilenKitaplars",
                column: "KitaplarId");

            migrationBuilder.CreateIndex(
                name: "IX_OduncVerilenKitaplars_KullaniciId",
                table: "OduncVerilenKitaplars",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_OduncVerilenKitaplars_OduncDurumlariId",
                table: "OduncVerilenKitaplars",
                column: "OduncDurumlariId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyons_KullaniciId",
                table: "Rezervasyons",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicis_Adress_AdresId",
                table: "Kullanicis",
                column: "AdresId",
                principalTable: "Adress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicis_Erisebilirliks_ErisebilirlikId",
                table: "Kullanicis",
                column: "ErisebilirlikId",
                principalTable: "Erisebilirliks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_Adress_AdresId",
                table: "Kullanicis");

            migrationBuilder.DropForeignKey(
                name: "FK_Kullanicis_Erisebilirliks_ErisebilirlikId",
                table: "Kullanicis");

            migrationBuilder.DropTable(
                name: "GeriBildirims");

            migrationBuilder.DropTable(
                name: "Odalars");

            migrationBuilder.DropTable(
                name: "OduncVerilenAyars");

            migrationBuilder.DropTable(
                name: "OduncVerilenKitaplars");

            migrationBuilder.DropTable(
                name: "Rezervasyons");

            migrationBuilder.DropTable(
                name: "Kitaplars");

            migrationBuilder.DropTable(
                name: "OduncDurumlaris");

            migrationBuilder.DropTable(
                name: "DilTurleris");

            migrationBuilder.DropTable(
                name: "Erisebilirliks");

            migrationBuilder.DropTable(
                name: "KitapTurleris");

            migrationBuilder.DropTable(
                name: "Yayinevis");

            migrationBuilder.DropTable(
                name: "Yazars");

            migrationBuilder.DropIndex(
                name: "IX_Kullanicis_ErisebilirlikId",
                table: "Kullanicis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adress",
                table: "Adress");

            migrationBuilder.RenameTable(
                name: "Adress",
                newName: "Adres");

            migrationBuilder.RenameColumn(
                name: "ErisebilirlikId",
                table: "Kullanicis",
                newName: "Erisebilirlik");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adres",
                table: "Adres",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kullanicis_Adres_AdresId",
                table: "Kullanicis",
                column: "AdresId",
                principalTable: "Adres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
