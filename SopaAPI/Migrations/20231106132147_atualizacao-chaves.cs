using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SopaAPI.Migrations
{
    /// <inheritdoc />
    public partial class atualizacaochaves : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Departaments_DepartmentId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_DepartmentId",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Positions");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DepartamentId",
                table: "Positions",
                column: "DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Departaments_DepartamentId",
                table: "Positions",
                column: "DepartamentId",
                principalTable: "Departaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Departaments_DepartamentId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Positions_DepartamentId",
                table: "Positions");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DepartmentId",
                table: "Positions",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Departaments_DepartmentId",
                table: "Positions",
                column: "DepartmentId",
                principalTable: "Departaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
