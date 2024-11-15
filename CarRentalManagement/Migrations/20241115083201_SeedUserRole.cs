using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b1849497-111b-4ee0-abe5-b71cba4c30fe", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEGjfGIsfDbuEovMhTEfM+/uMdXZ5OChbFlc7xxTxR9XUSsaeE0ixD8QuLv2PTf9yyw==", null, false, "346f2610-7c02-420f-8ceb-f42d71552ecd", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7169), new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7329), new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7331), new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7398), new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7401), new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7402), new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 11, 15, 16, 32, 1, 112, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4265), new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4276) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4279), new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4436), new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4437) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4438), new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4503), new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4506), new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4509), new DateTime(2024, 11, 15, 14, 35, 41, 43, DateTimeKind.Local).AddTicks(4509) });
        }
    }
}
