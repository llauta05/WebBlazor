using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseId",
                table: "Warehouses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseId",
                table: "Storages",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "9ed05a4c-929d-4470-b4da-ad11fb22c251", "Una calle 334", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "2c5d92d4-62af-48df-935b-2dc8f6f7cff4", "Una calle 334", "Bodega Merlo" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "e4a5269f-eeda-4c42-b25f-7a6709b54719", "Una calle 334", "Bodega Moron" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "2c5d92d4-62af-48df-935b-2dc8f6f7cff4");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "9ed05a4c-929d-4470-b4da-ad11fb22c251");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "e4a5269f-eeda-4c42-b25f-7a6709b54719");

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseId",
                table: "Warehouses",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "WarehouseId",
                table: "Storages",
                type: "nvarchar(10)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "2624bb48-f9e2-4dbb-8bcc-1b81708ae701", "Una calle 334", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "09fd1d11-e3e4-440c-ba32-70b0a5109b6d", "Una calle 334", "Bodega Merlo" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "dcd0bc4a-775f-4b87-bd4e-daf4095f09c9", "Una calle 334", "Bodega Moron" });
        }
    }
}
