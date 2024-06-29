using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations.WebApplication1
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "Cart",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "itemname",
                table: "Cart",
                newName: "ProductName");

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "ShippingDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "quantity",
                table: "ShippingDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Cart",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CartViewModelId",
                table: "Cart",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "Cart",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Cart",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CartViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrandTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartViewModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CartViewModelId",
                table: "Cart",
                column: "CartViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_CartViewModel_CartViewModelId",
                table: "Cart",
                column: "CartViewModelId",
                principalTable: "CartViewModel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_CartViewModel_CartViewModelId",
                table: "Cart");

            migrationBuilder.DropTable(
                name: "CartViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CartViewModelId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "ShippingDetails");

            migrationBuilder.DropColumn(
                name: "quantity",
                table: "ShippingDetails");

            migrationBuilder.DropColumn(
                name: "CartViewModelId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Cart");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Cart",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Cart",
                newName: "itemname");

            migrationBuilder.AlterColumn<int>(
                name: "price",
                table: "Cart",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
