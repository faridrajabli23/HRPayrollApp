using Microsoft.EntityFrameworkCore.Migrations;

namespace PayrollApp.Migrations
{
    public partial class oldworkPosition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "WorkPlaces");

            migrationBuilder.DropColumn(
                name: "EndReason",
                table: "WorkPlaces");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OldWorkPlaces",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "EntryDate",
                table: "OldWorkPlaces",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "EndReason",
                table: "OldWorkPlaces",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "OldWorkPlaces",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "OldWorkPlaces",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "OldWorkPlaces");

            migrationBuilder.AddColumn<string>(
                name: "EndDate",
                table: "WorkPlaces",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EndReason",
                table: "WorkPlaces",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "OldWorkPlaces",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EntryDate",
                table: "OldWorkPlaces",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EndReason",
                table: "OldWorkPlaces",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EndDate",
                table: "OldWorkPlaces",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
