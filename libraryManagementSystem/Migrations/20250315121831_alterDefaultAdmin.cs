using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace libraryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class alterDefaultAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 100);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "PasswordHash", "PhoneNumber", "Role", "Username" },
                values: new object[] { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@library.com", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", "12345678978", 3, "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "PasswordHash", "PhoneNumber", "Role", "Username" },
                values: new object[] { 100, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@library.com", "6G94qKPK8LYNjnTllCqm2G3BUM08AzOK7yW30tfjrMc=", "12345678978", 3, "admin" });
        }
    }
}
