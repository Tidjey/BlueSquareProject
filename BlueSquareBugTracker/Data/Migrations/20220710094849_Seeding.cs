using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueSquareBugTracker.Data.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TicketPriority",
                columns: new[] { "Id", "Name", "Priority" },
                values: new object[,]
                {
                    { 1, "Basse", 1 },
                    { 2, "Moyenne", 2 },
                    { 3, "Haute", 3 }
                });

            migrationBuilder.InsertData(
                table: "TicketType",
                columns: new[] { "Id", "Name", "Order" },
                values: new object[,]
                {
                    { 1, "Problème technique", 0 },
                    { 2, "Réclamation", 0 },
                    { 3, "Demande de développement", 0 }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "Id", "RoleName" },
                values: new object[,]
                {
                    { 1, "Client" },
                    { 2, "Opérateur" },
                    { 3, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AvatarUrl", "Created", "Mail", "Password", "UserRoleId" },
                values: new object[] { 1, "", new DateTime(2022, 7, 10, 11, 48, 49, 179, DateTimeKind.Local).AddTicks(5350), "client@xxx.yyy", "LPvaio5Lqv2pDPGbHc5tTbKSOfJxJ/8uDW2QvO29D1A=", 1 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AvatarUrl", "Created", "Mail", "Password", "UserRoleId" },
                values: new object[] { 2, "", new DateTime(2022, 7, 10, 11, 48, 49, 192, DateTimeKind.Local).AddTicks(6654), "operator@xxx.yyy", "LPvaio5Lqv2pDPGbHc5tTbKSOfJxJ/8uDW2QvO29D1A=", 2 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AvatarUrl", "Created", "Mail", "Password", "UserRoleId" },
                values: new object[] { 3, "", new DateTime(2022, 7, 10, 11, 48, 49, 205, DateTimeKind.Local).AddTicks(7823), "admin@xxx.yyy", "LPvaio5Lqv2pDPGbHc5tTbKSOfJxJ/8uDW2QvO29D1A=", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TicketPriority",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TicketPriority",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TicketPriority",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TicketType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
