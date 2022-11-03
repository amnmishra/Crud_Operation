using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_Operation.Migrations
{
    public partial class Initial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "venderMasters");

            migrationBuilder.DropColumn(
                name: "State",
                table: "venderMasters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "venderMasters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "venderMasters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
