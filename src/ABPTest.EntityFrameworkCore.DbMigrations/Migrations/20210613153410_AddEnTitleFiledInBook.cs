using Microsoft.EntityFrameworkCore.Migrations;

namespace ABPTest.Migrations
{
    public partial class AddEnTitleFiledInBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EnTitle",
                table: "AppBook",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Family",
                table: "AppAuthor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnTitle",
                table: "AppBook");

            migrationBuilder.AlterColumn<string>(
                name: "Family",
                table: "AppAuthor",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
