using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelEzeeEFCoreConsole.Migrations
{
    /// <inheritdoc />
    public partial class DbDataSeed1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ServiceType",
                columns: new[] { "STypeId", "PricePerKm", "ServiceTypeName" },
                values: new object[,]
                {
                    { 1L, 12.5, "Express" },
                    { 2L, 18.5, "Luxary" }
                });

            migrationBuilder.InsertData(
                table: "locations",
                columns: new[] { "LocationId", "LocationDescription", "LocationName" },
                values: new object[,]
                {
                    { 1L, null, "HYD" },
                    { 2L, null, "CHN" },
                    { 3L, null, "Mumbai" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceType",
                keyColumn: "STypeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ServiceType",
                keyColumn: "STypeId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "locations",
                keyColumn: "LocationId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "locations",
                keyColumn: "LocationId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "locations",
                keyColumn: "LocationId",
                keyValue: 3L);
        }
    }
}
