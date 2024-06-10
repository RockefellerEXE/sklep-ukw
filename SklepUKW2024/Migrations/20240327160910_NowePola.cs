using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SklepUKW2024.Migrations
{
    public partial class NowePola : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddDate",
                table: "Films",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Films",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddDate",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Films");
        }
    }
}
