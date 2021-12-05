using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "AppUsers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "AppUsers",
                newName: "FirstName");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 5, 23, 21, 42, 360, DateTimeKind.Local).AddTicks(2720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 5, 23, 5, 1, 610, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("54957ae1-a37a-46f4-96d2-5f796b8ca2a9"), "ecb593d9-ca43-4eb1-b8bc-a455dce29ecd", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("a615e38c-bf5d-4008-bb9a-ffa3566ed932"), new Guid("54957ae1-a37a-46f4-96d2-5f796b8ca2a9") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a615e38c-bf5d-4008-bb9a-ffa3566ed932"), 0, "0db85501-66f0-4a32-8ff2-f520353003e1", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", true, "Tuan", "Dinh", false, null, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEACYII04M31k39+kNxCMPcJLBS5HQzXRWUNp02Zhc1laeRjSkj/5o7vCMc3dfleLYQ==", null, false, "", false, "admin" });

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
                value: new DateTime(2021, 12, 5, 23, 21, 42, 396, DateTimeKind.Local).AddTicks(4059));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("54957ae1-a37a-46f4-96d2-5f796b8ca2a9"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("a615e38c-bf5d-4008-bb9a-ffa3566ed932"), new Guid("54957ae1-a37a-46f4-96d2-5f796b8ca2a9") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a615e38c-bf5d-4008-bb9a-ffa3566ed932"));

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AppUsers",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AppUsers",
                newName: "Firstname");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 5, 23, 5, 1, 610, DateTimeKind.Local).AddTicks(2887),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 12, 5, 23, 21, 42, 360, DateTimeKind.Local).AddTicks(2720));

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
                value: new DateTime(2021, 12, 5, 23, 5, 1, 628, DateTimeKind.Local).AddTicks(5053));
        }
    }
}
