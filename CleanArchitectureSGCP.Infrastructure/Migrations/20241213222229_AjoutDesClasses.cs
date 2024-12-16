using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureSGCP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AjoutDesClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Consultations");

            migrationBuilder.AddColumn<int>(
                name: "DossierMedicalId",
                table: "Prescriptions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DossierMedicalId",
                table: "Consultations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Utilisateurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomUtilisateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    NumeroLicence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Addresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddresseCourriel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Addresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroTelephones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddresseCourriel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedecinId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Utilisateurs_MedecinId",
                        column: x => x.MedecinId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateConnexion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDeconnexion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedecinId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Utilisateurs_MedecinId",
                        column: x => x.MedecinId,
                        principalTable: "Utilisateurs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DossiersMedicals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DossiersMedicals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DossiersMedicals_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_DossierMedicalId",
                table: "Prescriptions",
                column: "DossierMedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_DossierMedicalId",
                table: "Consultations",
                column: "DossierMedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_DossiersMedicals_PatientId",
                table: "DossiersMedicals",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_MedecinId",
                table: "Patients",
                column: "MedecinId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_MedecinId",
                table: "Sessions",
                column: "MedecinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_DossiersMedicals_DossierMedicalId",
                table: "Consultations",
                column: "DossierMedicalId",
                principalTable: "DossiersMedicals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_DossiersMedicals_DossierMedicalId",
                table: "Prescriptions",
                column: "DossierMedicalId",
                principalTable: "DossiersMedicals",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_DossiersMedicals_DossierMedicalId",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_DossiersMedicals_DossierMedicalId",
                table: "Prescriptions");

            migrationBuilder.DropTable(
                name: "DossiersMedicals");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Utilisateurs");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_DossierMedicalId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Consultations_DossierMedicalId",
                table: "Consultations");

            migrationBuilder.DropColumn(
                name: "DossierMedicalId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "DossierMedicalId",
                table: "Consultations");

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Numero",
                table: "Consultations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
