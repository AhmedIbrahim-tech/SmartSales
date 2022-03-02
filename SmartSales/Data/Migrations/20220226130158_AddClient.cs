using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartSales.Data.Migrations
{
    public partial class AddClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Client_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client_Phone = table.Column<int>(type: "int", nullable: false),
                    Client_IDCard = table.Column<int>(type: "int", nullable: false),
                    Client_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Client_Address_Work = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Client_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");
        }
    }
}
