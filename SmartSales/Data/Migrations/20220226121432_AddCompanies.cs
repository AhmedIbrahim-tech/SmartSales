using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartSales.Data.Migrations
{
    public partial class AddCompanies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campany",
                columns: table => new
                {
                    Campany_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Campany_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Campany_Owner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Campany_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Campany_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Campany_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Campany_Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campany", x => x.Campany_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campany");
        }
    }
}
