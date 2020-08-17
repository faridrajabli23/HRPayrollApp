using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollApp.Migrations
{
    public partial class AbsentReasonExcuable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExcusableOrInExcusable",
                table: "AbsentReasons",
                newName: "ExcusableOrInexcusable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExcusableOrInexcusable",
                table: "AbsentReasons",
                newName: "ExcusableOrInExcusable");
        }
    }
}
