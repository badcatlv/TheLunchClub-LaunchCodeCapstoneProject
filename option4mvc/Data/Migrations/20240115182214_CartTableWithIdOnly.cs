using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace option4mvc.Data.Migrations
{
    public partial class CartTableWithIdOnly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemDescription",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "Cart");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemDescription",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ItemPrice",
                table: "Cart",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
