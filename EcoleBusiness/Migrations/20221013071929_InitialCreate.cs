using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcoleBusiness.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ecoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ecoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fonctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fonctions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Matieres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Coefficient = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matieres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personne",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EcoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personne", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personne_Ecoles_EcoleId",
                        column: x => x.EcoleId,
                        principalTable: "Ecoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administratifs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FonctionId = table.Column<int>(type: "int", nullable: true),
                    Salaire = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administratifs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administratifs_Fonctions_FonctionId",
                        column: x => x.FonctionId,
                        principalTable: "Fonctions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Administratifs_Personne_Id",
                        column: x => x.Id,
                        principalTable: "Personne",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Eleves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Moyenne = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eleves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eleves_Personne_Id",
                        column: x => x.Id,
                        principalTable: "Personne",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Professeurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    MatiereId = table.Column<int>(type: "int", nullable: false),
                    Salaire = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professeurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Professeurs_Matieres_MatiereId",
                        column: x => x.MatiereId,
                        principalTable: "Matieres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Professeurs_Personne_Id",
                        column: x => x.Id,
                        principalTable: "Personne",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Ecoles",
                columns: new[] { "Id", "Nom" },
                values: new object[] { 1, "St Exupéry" });

            migrationBuilder.InsertData(
                table: "Fonctions",
                columns: new[] { "Id", "Libelle", "Service" },
                values: new object[,]
                {
                    { 1, "Secretaire", "Administration" },
                    { 2, "Educateur", "Equipe pedagogique" },
                    { 3, "Directeur", "Administration" },
                    { 4, "CPE", "Equipe pedagogique" }
                });

            migrationBuilder.InsertData(
                table: "Matieres",
                columns: new[] { "Id", "Coefficient", "Libelle" },
                values: new object[,]
                {
                    { 1, 8, "Mathematique" },
                    { 2, 9, "Francais" },
                    { 3, 2, "Sport" },
                    { 4, 7, "Science" }
                });

            migrationBuilder.InsertData(
                table: "Personne",
                columns: new[] { "Id", "DateNaissance", "EcoleId", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 5, new DateTime(1989, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sion", "Eva" },
                    { 1, new DateTime(2012, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Oumal", "Fabien" },
                    { 2, new DateTime(2009, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "DePoheur", "Agathe" },
                    { 3, new DateTime(1984, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Erie", "Yann" },
                    { 4, new DateTime(1978, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mobil", "Otto" }
                });

            migrationBuilder.InsertData(
                table: "Administratifs",
                columns: new[] { "Id", "FonctionId", "Salaire" },
                values: new object[] { 5, 3, 0m });

            migrationBuilder.InsertData(
                table: "Eleves",
                columns: new[] { "Id", "Moyenne" },
                values: new object[,]
                {
                    { 1, 12 },
                    { 2, 15 }
                });

            migrationBuilder.InsertData(
                table: "Professeurs",
                columns: new[] { "Id", "MatiereId", "Salaire" },
                values: new object[,]
                {
                    { 3, 4, 0m },
                    { 4, 3, 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administratifs_FonctionId",
                table: "Administratifs",
                column: "FonctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Personne_EcoleId",
                table: "Personne",
                column: "EcoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Professeurs_MatiereId",
                table: "Professeurs",
                column: "MatiereId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Administratifs");

            migrationBuilder.DropTable(
                name: "Eleves");

            migrationBuilder.DropTable(
                name: "Professeurs");

            migrationBuilder.DropTable(
                name: "Fonctions");

            migrationBuilder.DropTable(
                name: "Matieres");

            migrationBuilder.DropTable(
                name: "Personne");

            migrationBuilder.DropTable(
                name: "Ecoles");
        }
    }
}
