using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureSGCP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MiseAjourDesClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_DossiersMedicals_DossierMedicalId",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Utilisateurs_MedecinId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Consultations_ConsultationId",
                table: "Prescriptions");

            migrationBuilder.RenameColumn(
                name: "MedecinId",
                table: "Patients",
                newName: "medecinId");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_MedecinId",
                table: "Patients",
                newName: "IX_Patients_medecinId");

            migrationBuilder.AlterColumn<int>(
                name: "ConsultationId",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "etat",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "medecinId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalId",
                table: "Consultations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SessionId",
                table: "Consultations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_SessionId",
                table: "Consultations",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_DossiersMedicals_DossierMedicalId",
                table: "Consultations",
                column: "DossierMedicalId",
                principalTable: "DossiersMedicals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Sessions_SessionId",
                table: "Consultations",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Utilisateurs_medecinId",
                table: "Patients",
                column: "medecinId",
                principalTable: "Utilisateurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Consultations_ConsultationId",
                table: "Prescriptions",
                column: "ConsultationId",
                principalTable: "Consultations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_DossiersMedicals_DossierMedicalId",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Sessions_SessionId",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Utilisateurs_medecinId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Consultations_ConsultationId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_Consultations_SessionId",
                table: "Consultations");

            migrationBuilder.DropColumn(
                name: "etat",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "Consultations");

            migrationBuilder.RenameColumn(
                name: "medecinId",
                table: "Patients",
                newName: "MedecinId");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_medecinId",
                table: "Patients",
                newName: "IX_Patients_MedecinId");

            migrationBuilder.AlterColumn<int>(
                name: "ConsultationId",
                table: "Prescriptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MedecinId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DossierMedicalId",
                table: "Consultations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_DossiersMedicals_DossierMedicalId",
                table: "Consultations",
                column: "DossierMedicalId",
                principalTable: "DossiersMedicals",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Utilisateurs_MedecinId",
                table: "Patients",
                column: "MedecinId",
                principalTable: "Utilisateurs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Consultations_ConsultationId",
                table: "Prescriptions",
                column: "ConsultationId",
                principalTable: "Consultations",
                principalColumn: "Id");
        }
    }
}
