using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp_API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUsersandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "065e7ba5-dbcd-4cbf-8ca8-4732a9dbc6b5", null, "User", "USER" },
                    { "fc8c6ed3-0711-47f3-a0b4-bdcf238cbbb4", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ada97a5f-ac38-4293-be16-cacdc1be232f", 0, "4d3430e1-3af6-4a1b-9b3c-3b7759001379", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEHqA/VQxG1p2K/FwLRK4u48O7qm/Ebqvn+nmqoeyf1MaLSwJJFkoOtN+UJhowKtvvQ==", null, false, "3202f4cc-4a04-4101-b9ce-e6466e6764bc", false, "user@bookstore.com" },
                    { "c6f0d893-d703-47d9-b80d-0a70f26875af", 0, "b8348836-0855-4972-8cad-90f6c852e4ed", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEMwSUIMlazqGi0QvooWDW6Olo2aYLTx8S4ZMIh6WjJQ6RPRfXmvNpM6vSLncuUPNxw==", null, false, "4e94f2c1-2353-4535-b8d1-7f31e9279581", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "065e7ba5-dbcd-4cbf-8ca8-4732a9dbc6b5", "ada97a5f-ac38-4293-be16-cacdc1be232f" },
                    { "fc8c6ed3-0711-47f3-a0b4-bdcf238cbbb4", "c6f0d893-d703-47d9-b80d-0a70f26875af" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "065e7ba5-dbcd-4cbf-8ca8-4732a9dbc6b5", "ada97a5f-ac38-4293-be16-cacdc1be232f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fc8c6ed3-0711-47f3-a0b4-bdcf238cbbb4", "c6f0d893-d703-47d9-b80d-0a70f26875af" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "065e7ba5-dbcd-4cbf-8ca8-4732a9dbc6b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc8c6ed3-0711-47f3-a0b4-bdcf238cbbb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ada97a5f-ac38-4293-be16-cacdc1be232f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6f0d893-d703-47d9-b80d-0a70f26875af");
        }
    }
}
