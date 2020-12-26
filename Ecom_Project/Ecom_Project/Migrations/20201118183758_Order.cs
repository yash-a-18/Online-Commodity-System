using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecom_Project.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Order",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Order",
                newName: "Username");

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
