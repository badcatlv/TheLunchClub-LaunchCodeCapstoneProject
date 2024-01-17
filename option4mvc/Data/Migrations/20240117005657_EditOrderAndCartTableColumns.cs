using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace option4mvc.Data.Migrations
{
    public partial class EditOrderAndCartTableColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartDetail_Cart_CartId1",
                table: "CartDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_CartDetail_CartId1",
                table: "CartDetail");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "CartDetail");

            migrationBuilder.DropColumn(
                name: "CartId1",
                table: "CartDetail");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CartDetailId",
                table: "Cart",
                column: "CartDetailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_CartDetail_CartDetailId",
                table: "Cart",
                column: "CartDetailId",
                principalTable: "CartDetail",
                principalColumn: "CartDetailId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_CartDetail_CartDetailId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CartDetailId",
                table: "Cart");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "CartDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CartId1",
                table: "CartDetail",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartDetail_CartId1",
                table: "CartDetail",
                column: "CartId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CartDetail_Cart_CartId1",
                table: "CartDetail",
                column: "CartId1",
                principalTable: "Cart",
                principalColumn: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_Order_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
