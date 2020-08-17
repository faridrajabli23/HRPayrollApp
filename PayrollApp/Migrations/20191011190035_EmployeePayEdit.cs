using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollApp.Migrations
{
    public partial class EmployeePayEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "EmployeePays",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeePays_PositionId",
                table: "EmployeePays",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeePays_Positions_PositionId",
                table: "EmployeePays",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeePays_Positions_PositionId",
                table: "EmployeePays");

            migrationBuilder.DropIndex(
                name: "IX_EmployeePays_PositionId",
                table: "EmployeePays");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "EmployeePays");
        }
    }
}
