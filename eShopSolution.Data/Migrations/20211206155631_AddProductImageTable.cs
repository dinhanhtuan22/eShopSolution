using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductID",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Carts",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_ProductID",
                table: "Carts",
                newName: "IX_Carts_ProductId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 12, 5, 23, 21, 42, 360, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Products_ProductId",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Carts",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_ProductId",
                table: "Carts",
                newName: "IX_Carts_ProductID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 12, 5, 23, 21, 42, 360, DateTimeKind.Local).AddTicks(2720),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("54957ae1-a37a-46f4-96d2-5f796b8ca2a9"),
                column: "ConcurrencyStamp",
                value: "ecb593d9-ca43-4eb1-b8bc-a455dce29ecd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("a615e38c-bf5d-4008-bb9a-ffa3566ed932"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0db85501-66f0-4a32-8ff2-f520353003e1", "AQAAAAEAACcQAAAAEACYII04M31k39+kNxCMPcJLBS5HQzXRWUNp02Zhc1laeRjSkj/5o7vCMc3dfleLYQ==" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Products_ProductID",
                table: "Carts",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
