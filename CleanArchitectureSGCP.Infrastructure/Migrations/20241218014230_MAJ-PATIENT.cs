using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureSGCP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MAJPATIENT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Utilisateurs_medecinId",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "medecinId",
                table: "Patients",
                newName: "MedecinId");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_medecinId",
                table: "Patients",
                newName: "IX_Patients_MedecinId");

            migrationBuilder.AlterColumn<int>(
                name: "MedecinId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Utilisateurs_MedecinId",
                table: "Patients",
                column: "MedecinId",
                principalTable: "Utilisateurs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Utilisateurs_MedecinId",
                table: "Patients");

            migrationBuilder.RenameColumn(
                name: "MedecinId",
                table: "Patients",
                newName: "medecinId");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_MedecinId",
                table: "Patients",
                newName: "IX_Patients_medecinId");

            migrationBuilder.AlterColumn<int>(
                name: "medecinId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Utilisateurs_medecinId",
                table: "Patients",
                column: "medecinId",
                principalTable: "Utilisateurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
