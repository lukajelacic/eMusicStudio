using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eMuzickiStudio.WebAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradId);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false),
                    Opis = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Uloge__DCAB23CB99CF9853", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Vrsta",
                columns: table => new
                {
                    VrstaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vrsta", x => x.VrstaId);
                });

            migrationBuilder.CreateTable(
                name: "Klijenti",
                columns: table => new
                {
                    KlijentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(maxLength: 50, nullable: true),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 50, nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    GradId = table.Column<int>(nullable: false),
                    Banovan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Klijenti__5F05D8AEEDF14F69", x => x.KlijentId);
                    table.ForeignKey(
                        name: "FK_GradId",
                        column: x => x.GradId,
                        principalTable: "Grad",
                        principalColumn: "GradId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Telefon = table.Column<string>(maxLength: 50, nullable: true),
                    KorisnickoIme = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaHash = table.Column<string>(maxLength: 50, nullable: false),
                    LozinkaSalt = table.Column<string>(maxLength: 50, nullable: false),
                    UlogaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Korisnic__80B06D41F5FF910E", x => x.KorisnikId);
                    table.ForeignKey(
                        name: "FK_UlogaId_Korisnici",
                        column: x => x.UlogaId,
                        principalTable: "Uloge",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MuzickaOprema",
                columns: table => new
                {
                    MuzickaOpremaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(maxLength: 100, nullable: false),
                    VrstaId = table.Column<int>(nullable: false),
                    NaStanju = table.Column<int>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    Cijena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuzickaOprema", x => x.MuzickaOpremaId);
                    table.ForeignKey(
                        name: "FK_VrstaId",
                        column: x => x.VrstaId,
                        principalTable: "Vrsta",
                        principalColumn: "VrstaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RezervacijeGluveSobe",
                columns: table => new
                {
                    RezervacijeGluveSobeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    VrijemeOd = table.Column<TimeSpan>(nullable: false),
                    VrijemeDo = table.Column<TimeSpan>(nullable: false),
                    KlijentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervacijeGluveSobe", x => x.RezervacijeGluveSobeId);
                    table.ForeignKey(
                        name: "FK_KlijentId_GluvaSoba",
                        column: x => x.KlijentId,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacije",
                columns: table => new
                {
                    RezervacijaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojRezervacije = table.Column<int>(maxLength: 20, nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    DatumRezervacije = table.Column<DateTime>(nullable: false),
                    Otkazano = table.Column<bool>(nullable: true),
                    KlijentId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Cijena = table.Column<decimal>(nullable: true),
                    Arhivirana = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rezervac__CABA44DD90634C31", x => x.RezervacijaId);
                    table.ForeignKey(
                        name: "FK_KlijentId_Rezervacije",
                        column: x => x.KlijentId,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KorisnikId_Rezervacije",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Termini",
                columns: table => new
                {
                    TerminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    VrijemeOd = table.Column<TimeSpan>(nullable: false),
                    VrijemeDo = table.Column<TimeSpan>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    Aktivan = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Termini__42126C95AD36833F", x => x.TerminId);
                    table.ForeignKey(
                        name: "FK_KorisnikId_Termin",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ocjena = table.Column<int>(nullable: false),
                    KlijentId = table.Column<int>(nullable: false),
                    MuzickaOpremaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Ocjene__E6FC7B49A040F860", x => x.OcjenaID);
                    table.ForeignKey(
                        name: "FK_KlijentId_Ocjena",
                        column: x => x.KlijentId,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MuzickaOprema_Ocjena",
                        column: x => x.MuzickaOpremaId,
                        principalTable: "MuzickaOprema",
                        principalColumn: "MuzickaOpremaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RezervacijaStavke",
                columns: table => new
                {
                    RezervacijaStavkaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RezervacijaId = table.Column<int>(nullable: false),
                    MuzickaOpremaId = table.Column<int>(nullable: false),
                    Kolicina = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rezervac__D11E50DFFFF545FF", x => x.RezervacijaStavkaId);
                    table.ForeignKey(
                        name: "FK_MuzickaOprema",
                        column: x => x.MuzickaOpremaId,
                        principalTable: "MuzickaOprema",
                        principalColumn: "MuzickaOpremaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rezervacija",
                        column: x => x.RezervacijaId,
                        principalTable: "Rezervacije",
                        principalColumn: "RezervacijaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Klijenti_GradId",
                table: "Klijenti",
                column: "GradId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_UlogaId",
                table: "Korisnici",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_MuzickaOprema_VrstaId",
                table: "MuzickaOprema",
                column: "VrstaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KlijentId",
                table: "Ocjene",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_MuzickaOpremaId",
                table: "Ocjene",
                column: "MuzickaOpremaId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaStavke_MuzickaOpremaId",
                table: "RezervacijaStavke",
                column: "MuzickaOpremaId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaStavke_RezervacijaId",
                table: "RezervacijaStavke",
                column: "RezervacijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KlijentId",
                table: "Rezervacije",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacije_KorisnikId",
                table: "Rezervacije",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijeGluveSobe_KlijentId",
                table: "RezervacijeGluveSobe",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Termini_KorisnikId",
                table: "Termini",
                column: "KorisnikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "RezervacijaStavke");

            migrationBuilder.DropTable(
                name: "RezervacijeGluveSobe");

            migrationBuilder.DropTable(
                name: "Termini");

            migrationBuilder.DropTable(
                name: "MuzickaOprema");

            migrationBuilder.DropTable(
                name: "Rezervacije");

            migrationBuilder.DropTable(
                name: "Vrsta");

            migrationBuilder.DropTable(
                name: "Klijenti");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Uloge");
        }
    }
}
