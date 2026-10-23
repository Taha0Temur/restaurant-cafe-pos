using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LokantaAdisyon.Migrations
{
    /// <inheritdoc />
    public partial class IlkOlusturma : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Garsonlar",
                columns: table => new
                {
                    GarsonId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GarsonAd = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garsonlar", x => x.GarsonId);
                });

            migrationBuilder.CreateTable(
                name: "Giderler",
                columns: table => new
                {
                    GiderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Aciklama = table.Column<string>(type: "TEXT", nullable: false),
                    Tutar = table.Column<decimal>(type: "TEXT", nullable: false),
                    Tarih = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Giderler", x => x.GiderId);
                });

            migrationBuilder.CreateTable(
                name: "Masalar",
                columns: table => new
                {
                    MasaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Durum = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masalar", x => x.MasaId);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UrunAd = table.Column<string>(type: "TEXT", nullable: false),
                    SatisFiyati = table.Column<decimal>(type: "TEXT", nullable: false),
                    Maliyet = table.Column<decimal>(type: "TEXT", nullable: false),
                    Stok = table.Column<int>(type: "INTEGER", nullable: false),
                    Kategori = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunId);
                });

            migrationBuilder.CreateTable(
                name: "Adisyonlar",
                columns: table => new
                {
                    AdisyonId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AcilisZaman = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KapanisZaman = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Bahsis = table.Column<decimal>(type: "TEXT", nullable: false),
                    MasaId = table.Column<int>(type: "INTEGER", nullable: false),
                    GarsonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adisyonlar", x => x.AdisyonId);
                    table.ForeignKey(
                        name: "FK_Adisyonlar_Masalar_MasaId",
                        column: x => x.MasaId,
                        principalTable: "Masalar",
                        principalColumn: "MasaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiparisKalemleri",
                columns: table => new
                {
                    SiparisKalemiId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AdisyonId = table.Column<int>(type: "INTEGER", nullable: false),
                    UrunId = table.Column<int>(type: "INTEGER", nullable: false),
                    Adet = table.Column<int>(type: "INTEGER", nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "TEXT", nullable: false),
                    BirimMaliyet = table.Column<decimal>(type: "TEXT", nullable: false),
                    UrunAdi = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisKalemleri", x => x.SiparisKalemiId);
                    table.ForeignKey(
                        name: "FK_SiparisKalemleri_Adisyonlar_AdisyonId",
                        column: x => x.AdisyonId,
                        principalTable: "Adisyonlar",
                        principalColumn: "AdisyonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adisyonlar_MasaId",
                table: "Adisyonlar",
                column: "MasaId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisKalemleri_AdisyonId",
                table: "SiparisKalemleri",
                column: "AdisyonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garsonlar");

            migrationBuilder.DropTable(
                name: "Giderler");

            migrationBuilder.DropTable(
                name: "SiparisKalemleri");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Adisyonlar");

            migrationBuilder.DropTable(
                name: "Masalar");
        }
    }
}
