using Microsoft.EntityFrameworkCore.Migrations;

namespace Wassel.Migrations
{
    public partial class myMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemPackage");

            migrationBuilder.CreateTable(
                name: "PackageItems",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IID = table.Column<long>(type: "bigint", nullable: false),
                    PID = table.Column<long>(type: "bigint", nullable: false),
                    OrderID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PackageItems_Item_IID",
                        column: x => x.IID,
                        principalTable: "Item",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageItems_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PackageItems_Package_PID",
                        column: x => x.PID,
                        principalTable: "Package",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PackageItems_IID",
                table: "PackageItems",
                column: "IID");

            migrationBuilder.CreateIndex(
                name: "IX_PackageItems_OrderID",
                table: "PackageItems",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_PackageItems_PID",
                table: "PackageItems",
                column: "PID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PackageItems");

            migrationBuilder.CreateTable(
                name: "ItemPackage",
                columns: table => new
                {
                    ItemsID = table.Column<long>(type: "bigint", nullable: false),
                    PackagesID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemPackage", x => new { x.ItemsID, x.PackagesID });
                    table.ForeignKey(
                        name: "FK_ItemPackage_Item_ItemsID",
                        column: x => x.ItemsID,
                        principalTable: "Item",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemPackage_Package_PackagesID",
                        column: x => x.PackagesID,
                        principalTable: "Package",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemPackage_PackagesID",
                table: "ItemPackage",
                column: "PackagesID");
        }
    }
}
