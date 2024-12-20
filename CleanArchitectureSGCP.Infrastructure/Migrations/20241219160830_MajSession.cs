using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureSGCP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MajSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_DossiersMedicals_DossierMedicalId",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Sessions_SessionId",
                table: "Consultations");

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "Consultations",
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
                name: "FK_Consultations_Sessions_SessionId",
                table: "Consultations",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id");
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

            migrationBuilder.AlterColumn<int>(
                name: "SessionId",
                table: "Consultations",
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
        }
    }
}
