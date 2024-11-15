using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(3983), new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(3996), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(3998), new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(3999), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4181), new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4182), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4183), new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4184), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4257), new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4257), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4259), new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4259), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4260), new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4261), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4262), new DateTime(2024, 11, 15, 10, 33, 43, 245, DateTimeKind.Local).AddTicks(4263), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
