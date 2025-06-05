using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelEzeeEFConsole.Migrations
{
    /// <inheritdoc />
    public partial class Sloca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "LocationDescription", "LocationName" },
                values: new object[,]
                {
                    { 1L, null, "HYD" },
                    { 2L, null, "MLG" },
                    { 3L, null, "SRPT" }
                });

            migrationBuilder.InsertData(
                table: "Servicetypes",
                columns: new[] { "STypeId", "PricePerKm", "ServiceTypeName" },
                values: new object[,]
                {
                    { 1L, 12.5, "Express" },
                    { 2L, 12.9, "Luxury" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Servicetypes",
                keyColumn: "STypeId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Servicetypes",
                keyColumn: "STypeId",
                keyValue: 2L);
        }
    }
}
