using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ChangeFileLengthType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("54957ae1-a37a-46f4-96d2-5f796b8ca2a9"),
                column: "ConcurrencyStamp",
                value: "0aa5d861-7cb0-45f1-8da1-bb50bc451174");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a615e38c-bf5d-4008-bb9a-ffa3566ed932"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b20e175e-0d48-4893-a5f4-34642324d717", "AQAAAAEAACcQAAAAEDlfCz8S7uC6u/EsImh4uGPZjhfoEK1gu1Dgp1+Ot4mLTFT6dRQEMqBqE8ktD9Vw7Q==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 7, 0, 24, 54, 117, DateTimeKind.Local).AddTicks(6007));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("54957ae1-a37a-46f4-96d2-5f796b8ca2a9"),
                column: "ConcurrencyStamp",
                value: "66842df0-e4b9-4efd-aa68-17535cb3b375");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a615e38c-bf5d-4008-bb9a-ffa3566ed932"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c258af55-1367-441d-bfde-442287b836b3", "AQAAAAEAACcQAAAAEGdFlKTNrOSbuTW9bYdRcOz3MbHNs/Hts7Sg5YvRT/s5KqZ7OUg+nlS66u2sjqxgHA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 12, 6, 22, 56, 30, 694, DateTimeKind.Local).AddTicks(2204));
        }
    }
}
