using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Going for a Drive with my friends", new DateTime(2024, 4, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Driving" },
                    { 2, "Shopping and enjoying the day !", new DateTime(2024, 4, 11, 14, 30, 0, 0, DateTimeKind.Unspecified), "Went Shopping" },
                    { 3, "Playing makes the day better !", new DateTime(2024, 4, 12, 17, 15, 0, 0, DateTimeKind.Unspecified), "Went Playing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
