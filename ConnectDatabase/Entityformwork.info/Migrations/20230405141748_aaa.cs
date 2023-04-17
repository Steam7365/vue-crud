using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entityformwork.info.Migrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 5, 22, 17, 48, 143, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 5, 22, 17, 48, 143, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 5, 22, 17, 48, 143, DateTimeKind.Local).AddTicks(8058));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 5, 22, 2, 4, 644, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 5, 22, 2, 4, 644, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 4, 5, 22, 2, 4, 644, DateTimeKind.Local).AddTicks(1978));
        }
    }
}
