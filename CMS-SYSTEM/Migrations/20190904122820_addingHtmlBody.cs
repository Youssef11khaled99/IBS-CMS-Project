using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS_SYSTEM.Migrations
{
    public partial class addingHtmlBody : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HtmlBody",
                table: "Widget",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HtmlBody",
                table: "Widget");
        }
    }
}
