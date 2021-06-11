using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "COM", "Comida" },
                    { "SSS", "Otros" },
                    { "BBB", "Basura" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "2624bb48-f9e2-4dbb-8bcc-1b81708ae701", "Una calle 334", "Bodega Central" },
                    { "09fd1d11-e3e4-440c-ba32-70b0a5109b6d", "Una calle 334", "Bodega Merlo" },
                    { "dcd0bc4a-775f-4b87-bd4e-daf4095f09c9", "Una calle 334", "Bodega Moron" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "BBB");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "COM");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "SSS");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "09fd1d11-e3e4-440c-ba32-70b0a5109b6d");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "2624bb48-f9e2-4dbb-8bcc-1b81708ae701");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "dcd0bc4a-775f-4b87-bd4e-daf4095f09c9");
        }
    }
}
