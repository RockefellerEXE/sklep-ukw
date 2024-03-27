using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SklepUKW.Migrations
{
    public partial class addDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 21,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2010, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 22,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2012, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 35.0 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 23,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2010, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 21,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 22,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 23,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { null, null });
        }
    }
}
