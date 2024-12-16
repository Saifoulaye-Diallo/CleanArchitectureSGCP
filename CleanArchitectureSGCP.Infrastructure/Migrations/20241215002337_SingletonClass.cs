using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureSGCP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SingletonClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Utilisateurs_MedecinId",
                table: "Sessions");

            migrationBuilder.AlterColumn<int>(
                name: "MedecinId",
                table: "Sessions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Utilisateurs_MedecinId",
                table: "Sessions",
                column: "MedecinId",
                principalTable: "Utilisateurs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessions_Utilisateurs_MedecinId",
                table: "Sessions");

            migrationBuilder.AlterColumn<int>(
                name: "MedecinId",
                table: "Sessions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessions_Utilisateurs_MedecinId",
                table: "Sessions",
                column: "MedecinId",
                principalTable: "Utilisateurs",
                principalColumn: "Id");
        }
    }
}
