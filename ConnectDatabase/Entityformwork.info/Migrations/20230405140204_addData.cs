using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entityformwork.info.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookType",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 1, "国语书籍" });

            migrationBuilder.InsertData(
                table: "BookType",
                columns: new[] { "Id", "TypeName" },
                values: new object[] { 2, "外语书籍" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "Author", "BookTypeId", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, "鲁迅", 1, new DateTime(2023, 4, 5, 22, 2, 4, 644, DateTimeKind.Local).AddTicks(1974), "百草集" },
                    { 2, "鲁迅", 1, new DateTime(2023, 4, 5, 22, 2, 4, 644, DateTimeKind.Local).AddTicks(1976), "彷徨" },
                    { 3, "余华", 1, new DateTime(2023, 4, 5, 22, 2, 4, 644, DateTimeKind.Local).AddTicks(1978), "活着" },
                    { 4, "海明威", 2, new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "老人与海" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookType",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
