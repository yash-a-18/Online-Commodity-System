using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecom_Project.Migrations
{
    public partial class ItemsOwnerAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerEmail",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerEmail",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "Item");
        }
    }
}
