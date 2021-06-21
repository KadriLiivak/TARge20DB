using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class TARge20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "haigusleheTyyp",
                columns: table => new
                {
                    haigusleheTyypId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haigusleheTyyp", x => x.haigusleheTyypId);
                });

            migrationBuilder.CreateTable(
                name: "harukontor",
                columns: table => new
                {
                    harukontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefoninr = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_harukontor", x => x.harukontorId);
                });

            migrationBuilder.CreateTable(
                name: "ligipaasuloaTyyp",
                columns: table => new
                {
                    ligipaasuloaTyypId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ligipaas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ligipaasuloaTyyp", x => x.ligipaasuloaTyypId);
                });

            migrationBuilder.CreateTable(
                name: "puhkuseTyyp",
                columns: table => new
                {
                    puhkuseTyypId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_puhkuseTyyp", x => x.puhkuseTyypId);
                });

            migrationBuilder.CreateTable(
                name: "tootaja",
                columns: table => new
                {
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perekonnanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isikukood = table.Column<int>(type: "int", nullable: false),
                    kontaktaadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kontakttelefon = table.Column<int>(type: "int", nullable: false),
                    kontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    harukontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tootaja", x => x.tootajaId);
                    table.ForeignKey(
                        name: "FK_tootaja_harukontor_harukontorId",
                        column: x => x.harukontorId,
                        principalTable: "harukontor",
                        principalColumn: "harukontorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ametinimetused",
                columns: table => new
                {
                    ametinimetusId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ametinimetused", x => x.ametinimetusId);
                    table.ForeignKey(
                        name: "FK_ametinimetused_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "haiguslehed",
                columns: table => new
                {
                    haigusleheId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    haigusleheTyypId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    haigusleheAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    haigusleheLopp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_haiguslehed", x => x.haigusleheId);
                    table.ForeignKey(
                        name: "FK_haiguslehed_haigusleheTyyp_haigusleheTyypId",
                        column: x => x.haigusleheTyypId,
                        principalTable: "haigusleheTyyp",
                        principalColumn: "haigusleheTyypId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_haiguslehed_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "laenutatavEse",
                columns: table => new
                {
                    laenutatavEseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    esemeNimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laenutatavEse", x => x.laenutatavEseId);
                    table.ForeignKey(
                        name: "FK_laenutatavEse_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ligipaasuluba",
                columns: table => new
                {
                    ligipaasulubaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ligipaasuloaTyypId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ligipaasuloaAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ligipaasuloaLopp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ligipaasuluba", x => x.ligipaasulubaId);
                    table.ForeignKey(
                        name: "FK_ligipaasuluba_ligipaasuloaTyyp_ligipaasuloaTyypId",
                        column: x => x.ligipaasuloaTyypId,
                        principalTable: "ligipaasuloaTyyp",
                        principalColumn: "ligipaasuloaTyypId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ligipaasuluba_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "palved",
                columns: table => new
                {
                    palveId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    kuupaev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_palved", x => x.palveId);
                    table.ForeignKey(
                        name: "FK_palved_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "puhkused",
                columns: table => new
                {
                    puhkuseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    puhkuseTyypId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    puhkuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    puhkuseLopp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_puhkused", x => x.puhkuseId);
                    table.ForeignKey(
                        name: "FK_puhkused_puhkuseTyyp_puhkuseTyypId",
                        column: x => x.puhkuseTyypId,
                        principalTable: "puhkuseTyyp",
                        principalColumn: "puhkuseTyypId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_puhkused_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tervisekontrollid",
                columns: table => new
                {
                    tervisekontrolliId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    kuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    kellaaeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    tulemus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tervisekontrollid", x => x.tervisekontrolliId);
                    table.ForeignKey(
                        name: "FK_tervisekontrollid_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tootajaLaps",
                columns: table => new
                {
                    tootajaLapsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    perekonnanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isikukood = table.Column<int>(type: "int", nullable: false),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kontaktaadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    kontakttelefon = table.Column<int>(type: "int", nullable: false),
                    kontaktEmail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tootajaLaps", x => x.tootajaLapsId);
                    table.ForeignKey(
                        name: "FK_tootajaLaps_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vihjed",
                columns: table => new
                {
                    vihjeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    kuupaev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vihjed", x => x.vihjeId);
                    table.ForeignKey(
                        name: "FK_vihjed_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "toosuhe",
                columns: table => new
                {
                    toosuheId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ametinimetusedametinimetusId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    toolAlates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    toolKuni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    koormus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toosuhe", x => x.toosuheId);
                    table.ForeignKey(
                        name: "FK_toosuhe_ametinimetused_ametinimetusedametinimetusId",
                        column: x => x.ametinimetusedametinimetusId,
                        principalTable: "ametinimetused",
                        principalColumn: "ametinimetusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_toosuhe_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "laenutukord",
                columns: table => new
                {
                    laenutuskordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    tootajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    laenutatavEseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    laenutuseAlgus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    laenutuseLopp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laenutukord", x => x.laenutuskordId);
                    table.ForeignKey(
                        name: "FK_laenutukord_laenutatavEse_laenutatavEseId",
                        column: x => x.laenutatavEseId,
                        principalTable: "laenutatavEse",
                        principalColumn: "laenutatavEseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_laenutukord_tootaja_tootajaId",
                        column: x => x.tootajaId,
                        principalTable: "tootaja",
                        principalColumn: "tootajaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ametinimetused_tootajaId",
                table: "ametinimetused",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_haiguslehed_haigusleheTyypId",
                table: "haiguslehed",
                column: "haigusleheTyypId");

            migrationBuilder.CreateIndex(
                name: "IX_haiguslehed_tootajaId",
                table: "haiguslehed",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_laenutatavEse_tootajaId",
                table: "laenutatavEse",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_laenutukord_laenutatavEseId",
                table: "laenutukord",
                column: "laenutatavEseId");

            migrationBuilder.CreateIndex(
                name: "IX_laenutukord_tootajaId",
                table: "laenutukord",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_ligipaasuluba_ligipaasuloaTyypId",
                table: "ligipaasuluba",
                column: "ligipaasuloaTyypId");

            migrationBuilder.CreateIndex(
                name: "IX_ligipaasuluba_tootajaId",
                table: "ligipaasuluba",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_palved_tootajaId",
                table: "palved",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_puhkused_puhkuseTyypId",
                table: "puhkused",
                column: "puhkuseTyypId");

            migrationBuilder.CreateIndex(
                name: "IX_puhkused_tootajaId",
                table: "puhkused",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_tervisekontrollid_tootajaId",
                table: "tervisekontrollid",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_toosuhe_ametinimetusedametinimetusId",
                table: "toosuhe",
                column: "ametinimetusedametinimetusId");

            migrationBuilder.CreateIndex(
                name: "IX_toosuhe_tootajaId",
                table: "toosuhe",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_tootaja_harukontorId",
                table: "tootaja",
                column: "harukontorId");

            migrationBuilder.CreateIndex(
                name: "IX_tootajaLaps_tootajaId",
                table: "tootajaLaps",
                column: "tootajaId");

            migrationBuilder.CreateIndex(
                name: "IX_vihjed_tootajaId",
                table: "vihjed",
                column: "tootajaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "haiguslehed");

            migrationBuilder.DropTable(
                name: "laenutukord");

            migrationBuilder.DropTable(
                name: "ligipaasuluba");

            migrationBuilder.DropTable(
                name: "palved");

            migrationBuilder.DropTable(
                name: "puhkused");

            migrationBuilder.DropTable(
                name: "tervisekontrollid");

            migrationBuilder.DropTable(
                name: "toosuhe");

            migrationBuilder.DropTable(
                name: "tootajaLaps");

            migrationBuilder.DropTable(
                name: "vihjed");

            migrationBuilder.DropTable(
                name: "haigusleheTyyp");

            migrationBuilder.DropTable(
                name: "laenutatavEse");

            migrationBuilder.DropTable(
                name: "ligipaasuloaTyyp");

            migrationBuilder.DropTable(
                name: "puhkuseTyyp");

            migrationBuilder.DropTable(
                name: "ametinimetused");

            migrationBuilder.DropTable(
                name: "tootaja");

            migrationBuilder.DropTable(
                name: "harukontor");
        }
    }
}
