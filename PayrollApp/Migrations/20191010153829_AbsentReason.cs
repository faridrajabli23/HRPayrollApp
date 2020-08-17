using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollApp.Migrations
{
    public partial class AbsentReason : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExcusableOrExcusable",
                table: "AbsentReasons",
                newName: "ExcusableOrInExcusable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExcusableOrInExcusable",
                table: "AbsentReasons",
                newName: "ExcusableOrExcusable");
        }
    }
}
