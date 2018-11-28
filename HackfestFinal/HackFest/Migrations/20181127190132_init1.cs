using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HackFest.Migrations
{
    public partial class init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ID_Participant = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Prenom = table.Column<string>(nullable: false),
                    Nom = table.Column<string>(nullable: false),
                    Couriel = table.Column<string>(nullable: false),
                    Affiliation = table.Column<string>(nullable: false),
                    Date_inscription = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ID_Participant);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ID_Article = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_Participant = table.Column<int>(nullable: false),
                    TitreArticle = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ID_Article);
                    table.ForeignKey(
                        name: "FK_Articles_Participants_ID_Participant",
                        column: x => x.ID_Participant,
                        principalTable: "Participants",
                        principalColumn: "ID_Participant",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Membres",
                columns: table => new
                {
                    ID_Membre = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_Participant = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membres", x => x.ID_Membre);
                    table.ForeignKey(
                        name: "FK_Membres_Participants_ID_Participant",
                        column: x => x.ID_Participant,
                        principalTable: "Participants",
                        principalColumn: "ID_Participant",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organisateurs",
                columns: table => new
                {
                    ID_Organisateur = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_Participant = table.Column<int>(nullable: false),
                    MotDePasse = table.Column<string>(maxLength: 20, nullable: true),
                    RoleOrganisteur = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisateurs", x => x.ID_Organisateur);
                    table.ForeignKey(
                        name: "FK_Organisateurs_Participants_ID_Participant",
                        column: x => x.ID_Participant,
                        principalTable: "Participants",
                        principalColumn: "ID_Participant",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MembreArticles",
                columns: table => new
                {
                    ID_Article = table.Column<int>(nullable: false),
                    ID_Membre = table.Column<int>(nullable: false),
                    Note = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MembreArticles", x => x.ID_Article);
                    table.ForeignKey(
                        name: "FK_MembreArticles_Articles_ID_Article",
                        column: x => x.ID_Article,
                        principalTable: "Articles",
                        principalColumn: "ID_Article",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MembreArticles_Membres_ID_Membre",
                        column: x => x.ID_Membre,
                        principalTable: "Membres",
                        principalColumn: "ID_Membre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Specialites",
                columns: table => new
                {
                    ID_Specialite = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_Membre = table.Column<int>(nullable: false),
                    DescriptionSpecialite = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialites", x => x.ID_Specialite);
                    table.ForeignKey(
                        name: "FK_Specialites_Membres_ID_Membre",
                        column: x => x.ID_Membre,
                        principalTable: "Membres",
                        principalColumn: "ID_Membre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ID_Participant",
                table: "Articles",
                column: "ID_Participant");

            migrationBuilder.CreateIndex(
                name: "IX_MembreArticles_ID_Membre",
                table: "MembreArticles",
                column: "ID_Membre");

            migrationBuilder.CreateIndex(
                name: "IX_Membres_ID_Participant",
                table: "Membres",
                column: "ID_Participant");

            migrationBuilder.CreateIndex(
                name: "IX_Organisateurs_ID_Participant",
                table: "Organisateurs",
                column: "ID_Participant");

            migrationBuilder.CreateIndex(
                name: "IX_Specialites_ID_Membre",
                table: "Specialites",
                column: "ID_Membre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MembreArticles");

            migrationBuilder.DropTable(
                name: "Organisateurs");

            migrationBuilder.DropTable(
                name: "Specialites");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Membres");

            migrationBuilder.DropTable(
                name: "Participants");
        }
    }
}
