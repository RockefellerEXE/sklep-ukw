using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SklepUKW2024.Migrations
{
    public partial class Dane2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 21,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 22,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2020, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 23,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 24,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2024, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 21.0 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 25,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.0 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 26,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14.0 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 27,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { new DateTime(2019, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 9.0 });
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

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 24,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 25,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 26,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 27,
                columns: new[] { "AddDate", "Price" },
                values: new object[] { null, null });
        }
    }
}
