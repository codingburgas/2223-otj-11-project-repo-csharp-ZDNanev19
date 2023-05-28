using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kepillik.Migrations
{
    /// <inheritdoc />
    public partial class CorrectProductentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductStore_Product_ProductsId",
                table: "ProductStore");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStore_Store_StoresId",
                table: "ProductStore");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreUser_Store_StoresId",
                table: "StoreUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Warranties_Product_ProductId",
                table: "Warranties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Store",
                table: "Store");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "Store",
                newName: "Stores");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStore_Products_ProductsId",
                table: "ProductStore",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStore_Stores_StoresId",
                table: "ProductStore",
                column: "StoresId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreUser_Stores_StoresId",
                table: "StoreUser",
                column: "StoresId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warranties_Products_ProductId",
                table: "Warranties",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductStore_Products_ProductsId",
                table: "ProductStore");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductStore_Stores_StoresId",
                table: "ProductStore");

            migrationBuilder.DropForeignKey(
                name: "FK_StoreUser_Stores_StoresId",
                table: "StoreUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Warranties_Products_ProductId",
                table: "Warranties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "Store");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Store",
                table: "Store",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStore_Product_ProductsId",
                table: "ProductStore",
                column: "ProductsId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductStore_Store_StoresId",
                table: "ProductStore",
                column: "StoresId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StoreUser_Store_StoresId",
                table: "StoreUser",
                column: "StoresId",
                principalTable: "Store",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Warranties_Product_ProductId",
                table: "Warranties",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
