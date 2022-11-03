using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Crud_Operation.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VenderDate",
                table: "venderMasters");

            migrationBuilder.DropColumn(
                name: "VenderId",
                table: "venderMasters");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "VenderDate",
                table: "venderMasters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "VenderId",
                table: "venderMasters",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
