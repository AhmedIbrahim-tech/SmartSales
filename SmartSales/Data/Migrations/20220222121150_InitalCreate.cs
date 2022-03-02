using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartSales.Data.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Category_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Category_Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category_ID = table.Column<int>(type: "int", nullable: false),
                    Stock_ID = table.Column<int>(type: "int", nullable: false),
                    Product_BuyPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_SellPrice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Limited_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Product_ID);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    Stock_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stock_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock_Official = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.Stock_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Stock");
        }
    }
}
