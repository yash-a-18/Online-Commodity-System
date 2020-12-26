using Microsoft.EntityFrameworkCore.Migrations;

namespace Ecom_Project.Migrations
{
    public partial class OrderDetailsUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "username",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "username",
                table: "OrderDetails");
        }
    }
}
