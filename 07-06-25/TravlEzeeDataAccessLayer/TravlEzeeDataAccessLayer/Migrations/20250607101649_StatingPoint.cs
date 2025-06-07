using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravlEzeeDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class StatingPoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "locations",
                columns: table => new
                {
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LocationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "servicetypes",
                columns: table => new
                {
                    STypeId = table.Column<long>(type: "bigint", nullable: false),
                    ServiceTypeName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PricePerKm = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicetypes", x => x.STypeId);
                });

            migrationBuilder.CreateTable(
                name: "services",
                columns: table => new
                {
                    ServiceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceTypeId = table.Column<long>(type: "bigint", nullable: false),
                    SourceLocId = table.Column<long>(type: "bigint", nullable: false),
                    DestLocId = table.Column<long>(type: "bigint", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_services_locations_DestLocId",
                        column: x => x.DestLocId,
                        principalTable: "locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_services_locations_SourceLocId",
                        column: x => x.SourceLocId,
                        principalTable: "locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_services_servicetypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "servicetypes",
                        principalColumn: "STypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<long>(type: "bigint", nullable: false),
                    TravelData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeatCount = table.Column<int>(type: "int", nullable: false),
                    BookBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_bookings_services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "locations",
                columns: new[] { "LocationId", "LocationDescription", "LocationName" },
                values: new object[,]
                {
                    { 1L, null, "chennai" },
                    { 2L, null, "hyd" },
                    { 3L, null, "kurnool" }
                });

            migrationBuilder.InsertData(
                table: "servicetypes",
                columns: new[] { "STypeId", "PricePerKm", "ServiceTypeName" },
                values: new object[,]
                {
                    { 101L, 23.199999999999999, "Express" },
                    { 102L, 10.199999999999999, "Ordinary" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookings_ServiceId",
                table: "bookings",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_services_DestLocId",
                table: "services",
                column: "DestLocId");

            migrationBuilder.CreateIndex(
                name: "IX_services_ServiceTypeId",
                table: "services",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_services_SourceLocId",
                table: "services",
                column: "SourceLocId");

            migrationBuilder.CreateIndex(
                name: "IX_servicetypes_ServiceTypeName",
                table: "servicetypes",
                column: "ServiceTypeName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "services");

            migrationBuilder.DropTable(
                name: "locations");

            migrationBuilder.DropTable(
                name: "servicetypes");
        }
    }
}
