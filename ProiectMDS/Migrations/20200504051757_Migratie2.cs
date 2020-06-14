using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectMDS.Migrations
{
    public partial class Migratie2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorie",
                columns: table => new
                {
                    CategorieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeCategorie = table.Column<string>(nullable: true),
                    Specificatii = table.Column<string>(nullable: true),
                    Descriere = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorie", x => x.CategorieId);
                });

            migrationBuilder.CreateTable(
                name: "Magazin",
                columns: table => new
                {
                    MagazinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nume = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazin", x => x.MagazinId);
                });

            migrationBuilder.CreateTable(
                name: "Producator",
                columns: table => new
                {
                    ProducatorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NumeProducator = table.Column<string>(nullable: true),
                    TaraOrigine = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producator", x => x.ProducatorId);
                });

            migrationBuilder.CreateTable(
                name: "TipClient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descriere = table.Column<string>(nullable: true),
                    Discount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipClient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Echipament",
                columns: table => new
                {
                    EchipamentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdProducator = table.Column<int>(nullable: false),
                    NumeEchipament = table.Column<string>(nullable: true),
                    Pret = table.Column<float>(nullable: false),
                    Descriere = table.Column<string>(nullable: true),
                    AnAparitie = table.Column<int>(nullable: false),
                    Specificatii = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true),
                    ProducatorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Echipament", x => x.EchipamentId);
                    table.ForeignKey(
                        name: "FK_Echipament_Producator_ProducatorId",
                        column: x => x.ProducatorId,
                        principalTable: "Producator",
                        principalColumn: "ProducatorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdTip = table.Column<int>(nullable: false),
                    Nume = table.Column<string>(nullable: true),
                    DataNasterii = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Parola = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    TipClientId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                    table.ForeignKey(
                        name: "FK_Client_TipClient_TipClientId",
                        column: x => x.TipClientId,
                        principalTable: "TipClient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EchipamentCategorie",
                columns: table => new
                {
                    EchipamentCategorieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdEchipament = table.Column<int>(nullable: false),
                    IdCategorie = table.Column<int>(nullable: false),
                    CategorieId = table.Column<int>(nullable: true),
                    EchipamentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EchipamentCategorie", x => x.EchipamentCategorieId);
                    table.ForeignKey(
                        name: "FK_EchipamentCategorie_Categorie_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categorie",
                        principalColumn: "CategorieId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EchipamentCategorie_Echipament_EchipamentId",
                        column: x => x.EchipamentId,
                        principalTable: "Echipament",
                        principalColumn: "EchipamentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MagazinEchipament",
                columns: table => new
                {
                    MagazinEchipamentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdMagazin = table.Column<int>(nullable: false),
                    IdEchipament = table.Column<int>(nullable: false),
                    Stoc = table.Column<float>(nullable: false),
                    MagazinId = table.Column<int>(nullable: true),
                    EchipamentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagazinEchipament", x => x.MagazinEchipamentId);
                    table.ForeignKey(
                        name: "FK_MagazinEchipament_Echipament_EchipamentId",
                        column: x => x.EchipamentId,
                        principalTable: "Echipament",
                        principalColumn: "EchipamentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MagazinEchipament_Magazin_MagazinId",
                        column: x => x.MagazinId,
                        principalTable: "Magazin",
                        principalColumn: "MagazinId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Comenzi",
                columns: table => new
                {
                    ComenziId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdMagazin = table.Column<int>(nullable: false),
                    IdClient = table.Column<int>(nullable: false),
                    SumaTotala = table.Column<float>(nullable: false),
                    ClientId = table.Column<int>(nullable: true),
                    MagazinId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comenzi", x => x.ComenziId);
                    table.ForeignKey(
                        name: "FK_Comenzi_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comenzi_Magazin_MagazinId",
                        column: x => x.MagazinId,
                        principalTable: "Magazin",
                        principalColumn: "MagazinId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComandaEchipament",
                columns: table => new
                {
                    ComandaEchipamentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdComenzi = table.Column<int>(nullable: false),
                    IdEchipament = table.Column<int>(nullable: false),
                    Cantitate = table.Column<int>(nullable: false),
                    ComenziId = table.Column<int>(nullable: true),
                    EchipamentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandaEchipament", x => x.ComandaEchipamentId);
                    table.ForeignKey(
                        name: "FK_ComandaEchipament_Comenzi_ComenziId",
                        column: x => x.ComenziId,
                        principalTable: "Comenzi",
                        principalColumn: "ComenziId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComandaEchipament_Echipament_EchipamentId",
                        column: x => x.EchipamentId,
                        principalTable: "Echipament",
                        principalColumn: "EchipamentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_TipClientId",
                table: "Client",
                column: "TipClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaEchipament_ComenziId",
                table: "ComandaEchipament",
                column: "ComenziId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaEchipament_EchipamentId",
                table: "ComandaEchipament",
                column: "EchipamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comenzi_ClientId",
                table: "Comenzi",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Comenzi_MagazinId",
                table: "Comenzi",
                column: "MagazinId");

            migrationBuilder.CreateIndex(
                name: "IX_Echipament_ProducatorId",
                table: "Echipament",
                column: "ProducatorId");

            migrationBuilder.CreateIndex(
                name: "IX_EchipamentCategorie_CategorieId",
                table: "EchipamentCategorie",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_EchipamentCategorie_EchipamentId",
                table: "EchipamentCategorie",
                column: "EchipamentId");

            migrationBuilder.CreateIndex(
                name: "IX_MagazinEchipament_EchipamentId",
                table: "MagazinEchipament",
                column: "EchipamentId");

            migrationBuilder.CreateIndex(
                name: "IX_MagazinEchipament_MagazinId",
                table: "MagazinEchipament",
                column: "MagazinId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComandaEchipament");

            migrationBuilder.DropTable(
                name: "EchipamentCategorie");

            migrationBuilder.DropTable(
                name: "MagazinEchipament");

            migrationBuilder.DropTable(
                name: "Comenzi");

            migrationBuilder.DropTable(
                name: "Categorie");

            migrationBuilder.DropTable(
                name: "Echipament");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Magazin");

            migrationBuilder.DropTable(
                name: "Producator");

            migrationBuilder.DropTable(
                name: "TipClient");
        }
    }
}
