using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlueSquareBugTracker.Data.Migrations
{
    public partial class TicketState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TicketStateId",
                table: "Ticket",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TicketState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketState", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 10, 12, 47, 11, 785, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 10, 12, 47, 11, 800, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 10, 12, 47, 11, 813, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_TicketStateId",
                table: "Ticket",
                column: "TicketStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TicketState_TicketStateId",
                table: "Ticket",
                column: "TicketStateId",
                principalTable: "TicketState",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TicketState_TicketStateId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "TicketState");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_TicketStateId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TicketStateId",
                table: "Ticket");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 10, 11, 48, 49, 179, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 10, 11, 48, 49, 192, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 10, 11, 48, 49, 205, DateTimeKind.Local).AddTicks(7823));
        }
    }
}
