using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pausal.DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Adresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Grad = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostanskiBroj = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ulica = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresa", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cenovnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DatumVazenja = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cenovnik", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Preduzece",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PIB = table.Column<int>(type: "int", nullable: false),
                    MIB = table.Column<int>(type: "int", nullable: false),
                    AdresaId = table.Column<int>(type: "int", nullable: true),
                    Telefon = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preduzece", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preduzece_Adresa_AdresaId",
                        column: x => x.AdresaId,
                        principalTable: "Adresa",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Delatnost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sifra = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Primarna = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PreduzeceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delatnost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Delatnost_Preduzece_PreduzeceId",
                        column: x => x.PreduzeceId,
                        principalTable: "Preduzece",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dobavljac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PIB = table.Column<int>(type: "int", nullable: false),
                    MIB = table.Column<int>(type: "int", nullable: false),
                    AdresaId = table.Column<int>(type: "int", nullable: true),
                    PreduzeceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dobavljac_Adresa_AdresaId",
                        column: x => x.AdresaId,
                        principalTable: "Adresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Dobavljac_Preduzece_PreduzeceId",
                        column: x => x.PreduzeceId,
                        principalTable: "Preduzece",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Prezime = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    KorisnickoIme = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sifra = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PreduzeceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korisnik_Preduzece_PreduzeceId",
                        column: x => x.PreduzeceId,
                        principalTable: "Preduzece",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Kupac",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PIB = table.Column<int>(type: "int", nullable: false),
                    MIB = table.Column<int>(type: "int", nullable: false),
                    AdresaId = table.Column<int>(type: "int", nullable: true),
                    PreduzeceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kupac_Adresa_AdresaId",
                        column: x => x.AdresaId,
                        principalTable: "Adresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Kupac_Preduzece_PreduzeceId",
                        column: x => x.PreduzeceId,
                        principalTable: "Preduzece",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PoslovnaGodina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Godina = table.Column<int>(type: "int", nullable: false),
                    Zakljucena = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PreduzeceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoslovnaGodina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PoslovnaGodina_Preduzece_PreduzeceId",
                        column: x => x.PreduzeceId,
                        principalTable: "Preduzece",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BrojRacuna = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valuta = table.Column<int>(type: "int", nullable: false),
                    Aktivan = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DobavljacId = table.Column<int>(type: "int", nullable: true),
                    KupacId = table.Column<int>(type: "int", nullable: true),
                    PreduzeceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racun_Dobavljac_DobavljacId",
                        column: x => x.DobavljacId,
                        principalTable: "Dobavljac",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Racun_Kupac_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupac",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Racun_Preduzece_PreduzeceId",
                        column: x => x.PreduzeceId,
                        principalTable: "Preduzece",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Doprinosi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PIO = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Zdravstveno = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PorezNaDobit = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Nezaposlenost = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PoslovnaGodinaId = table.Column<int>(type: "int", nullable: true),
                    PreduzeceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doprinosi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doprinosi_PoslovnaGodina_PoslovnaGodinaId",
                        column: x => x.PoslovnaGodinaId,
                        principalTable: "PoslovnaGodina",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Doprinosi_Preduzece_PreduzeceId",
                        column: x => x.PreduzeceId,
                        principalTable: "Preduzece",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KPOKnjiga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PreduzeceId = table.Column<int>(type: "int", nullable: true),
                    PoslovnaGodinaId = table.Column<int>(type: "int", nullable: true),
                    Ukupno = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KPOKnjiga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KPOKnjiga_PoslovnaGodina_PoslovnaGodinaId",
                        column: x => x.PoslovnaGodinaId,
                        principalTable: "PoslovnaGodina",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_KPOKnjiga_Preduzece_PreduzeceId",
                        column: x => x.PreduzeceId,
                        principalTable: "Preduzece",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Nalog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Duznik = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Poverilac = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SvrhaPlacanja = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Datum = table.Column<DateOnly>(type: "date", nullable: true),
                    SifraPlacanja = table.Column<int>(type: "int", nullable: false),
                    PozivNaBroj = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Iznos = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    RacunPrimaocaId = table.Column<int>(type: "int", nullable: true),
                    RacunUplatiocaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nalog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nalog_Racun_RacunPrimaocaId",
                        column: x => x.RacunPrimaocaId,
                        principalTable: "Racun",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Nalog_Racun_RacunUplatiocaId",
                        column: x => x.RacunUplatiocaId,
                        principalTable: "Racun",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Faktura",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BrojFakture = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DatumIzdavanja = table.Column<DateOnly>(type: "date", nullable: false),
                    DatumValute = table.Column<DateOnly>(type: "date", nullable: false),
                    UkupanRabat = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    UkupnaOsnovica = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    UkupanPDV = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    UkupanIznos = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PreduzeceId = table.Column<int>(type: "int", nullable: true),
                    KupacId = table.Column<int>(type: "int", nullable: true),
                    KPOKnjigaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faktura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faktura_KPOKnjiga_KPOKnjigaId",
                        column: x => x.KPOKnjigaId,
                        principalTable: "KPOKnjiga",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Faktura_Kupac_KupacId",
                        column: x => x.KupacId,
                        principalTable: "Kupac",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Faktura_Preduzece_PreduzeceId",
                        column: x => x.PreduzeceId,
                        principalTable: "Preduzece",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StavkaFakture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Kolicina = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Rabat = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    JedinicnaCena = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Osnovica = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    UkupnaCena = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    FakturaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaFakture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StavkaFakture_Faktura_FakturaId",
                        column: x => x.FakturaId,
                        principalTable: "Faktura",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RobaUsluga",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StavkaFaktureId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RobaUsluga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RobaUsluga_StavkaFakture_StavkaFaktureId",
                        column: x => x.StavkaFaktureId,
                        principalTable: "StavkaFakture",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "StavkaCenovnika",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cena = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    RobaUslugaId = table.Column<int>(type: "int", nullable: true),
                    CenovnikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkaCenovnika", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StavkaCenovnika_Cenovnik_CenovnikId",
                        column: x => x.CenovnikId,
                        principalTable: "Cenovnik",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StavkaCenovnika_RobaUsluga_RobaUslugaId",
                        column: x => x.RobaUslugaId,
                        principalTable: "RobaUsluga",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Delatnost_PreduzeceId",
                table: "Delatnost",
                column: "PreduzeceId");

            migrationBuilder.CreateIndex(
                name: "IX_Dobavljac_AdresaId",
                table: "Dobavljac",
                column: "AdresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Dobavljac_PreduzeceId",
                table: "Dobavljac",
                column: "PreduzeceId");

            migrationBuilder.CreateIndex(
                name: "IX_Doprinosi_PoslovnaGodinaId",
                table: "Doprinosi",
                column: "PoslovnaGodinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Doprinosi_PreduzeceId",
                table: "Doprinosi",
                column: "PreduzeceId");

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_KPOKnjigaId",
                table: "Faktura",
                column: "KPOKnjigaId");

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_KupacId",
                table: "Faktura",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Faktura_PreduzeceId",
                table: "Faktura",
                column: "PreduzeceId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_PreduzeceId",
                table: "Korisnik",
                column: "PreduzeceId");

            migrationBuilder.CreateIndex(
                name: "IX_KPOKnjiga_PoslovnaGodinaId",
                table: "KPOKnjiga",
                column: "PoslovnaGodinaId");

            migrationBuilder.CreateIndex(
                name: "IX_KPOKnjiga_PreduzeceId",
                table: "KPOKnjiga",
                column: "PreduzeceId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_AdresaId",
                table: "Kupac",
                column: "AdresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupac_PreduzeceId",
                table: "Kupac",
                column: "PreduzeceId");

            migrationBuilder.CreateIndex(
                name: "IX_Nalog_RacunPrimaocaId",
                table: "Nalog",
                column: "RacunPrimaocaId");

            migrationBuilder.CreateIndex(
                name: "IX_Nalog_RacunUplatiocaId",
                table: "Nalog",
                column: "RacunUplatiocaId");

            migrationBuilder.CreateIndex(
                name: "IX_PoslovnaGodina_PreduzeceId",
                table: "PoslovnaGodina",
                column: "PreduzeceId");

            migrationBuilder.CreateIndex(
                name: "IX_Preduzece_AdresaId",
                table: "Preduzece",
                column: "AdresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_DobavljacId",
                table: "Racun",
                column: "DobavljacId");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_KupacId",
                table: "Racun",
                column: "KupacId");

            migrationBuilder.CreateIndex(
                name: "IX_Racun_PreduzeceId",
                table: "Racun",
                column: "PreduzeceId");

            migrationBuilder.CreateIndex(
                name: "IX_RobaUsluga_StavkaFaktureId",
                table: "RobaUsluga",
                column: "StavkaFaktureId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaCenovnika_CenovnikId",
                table: "StavkaCenovnika",
                column: "CenovnikId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaCenovnika_RobaUslugaId",
                table: "StavkaCenovnika",
                column: "RobaUslugaId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkaFakture_FakturaId",
                table: "StavkaFakture",
                column: "FakturaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delatnost");

            migrationBuilder.DropTable(
                name: "Doprinosi");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "Nalog");

            migrationBuilder.DropTable(
                name: "StavkaCenovnika");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "Cenovnik");

            migrationBuilder.DropTable(
                name: "RobaUsluga");

            migrationBuilder.DropTable(
                name: "Dobavljac");

            migrationBuilder.DropTable(
                name: "StavkaFakture");

            migrationBuilder.DropTable(
                name: "Faktura");

            migrationBuilder.DropTable(
                name: "KPOKnjiga");

            migrationBuilder.DropTable(
                name: "Kupac");

            migrationBuilder.DropTable(
                name: "PoslovnaGodina");

            migrationBuilder.DropTable(
                name: "Preduzece");

            migrationBuilder.DropTable(
                name: "Adresa");
        }
    }
}
