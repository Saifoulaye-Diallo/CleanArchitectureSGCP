using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureSGCP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MAJ_DossierMedical : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Consultations_ConsultationId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_DossiersMedicals_PatientId",
                table: "DossiersMedicals");

            migrationBuilder.AlterColumn<int>(
                name: "ConsultationId",
                table: "Prescriptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_DossiersMedicals_PatientId",
                table: "DossiersMedicals",
                column: "PatientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Consultations_ConsultationId",
                table: "Prescriptions",
                column: "ConsultationId",
                principalTable: "Consultations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Consultations_ConsultationId",
                table: "Prescriptions");

            migrationBuilder.DropIndex(
                name: "IX_DossiersMedicals_PatientId",
                table: "DossiersMedicals");

            migrationBuilder.AlterColumn<int>(
                name: "ConsultationId",
                table: "Prescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DossiersMedicals_PatientId",
                table: "DossiersMedicals",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Consultations_ConsultationId",
                table: "Prescriptions",
                column: "ConsultationId",
                principalTable: "Consultations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
