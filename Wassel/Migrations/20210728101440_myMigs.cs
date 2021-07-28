using Microsoft.EntityFrameworkCore.Migrations;

namespace Wassel.Migrations
{
    public partial class myMigs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PackageItems_Order_OrderID",
                table: "PackageItems");

            migrationBuilder.DropIndex(
                name: "IX_PackageItems_OrderID",
                table: "PackageItems");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "PackageItems");

            migrationBuilder.AddColumn<string>(
                name: "Stutus",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stutus",
                table: "Order");

            migrationBuilder.AddColumn<long>(
                name: "OrderID",
                table: "PackageItems",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PackageItems_OrderID",
                table: "PackageItems",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_PackageItems_Order_OrderID",
                table: "PackageItems",
                column: "OrderID",
                principalTable: "Order",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
