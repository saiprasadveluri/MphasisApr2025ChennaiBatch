using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelEzeeeeee1.Migrations
{
    /// <inheritdoc />
    public partial class datasetup1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LocationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceTypes",
                columns: table => new
                {
                    STypeId = table.Column<long>(type: "bigint", nullable: false),
                    ServiceTypeName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PricePerKm = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTypes", x => x.STypeId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SerTypeId = table.Column<long>(type: "bigint", nullable: false),
                    SourceLocId = table.Column<long>(type: "bigint", nullable: false),
                    DestLocId = table.Column<long>(type: "bigint", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_Locations_DestLocId",
                        column: x => x.DestLocId,
                        principalTable: "Locations",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "FK_Services_Locations_SourceLocId",
                        column: x => x.SourceLocId,
                        principalTable: "Locations",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "FK_Services_ServiceTypes_SerTypeId",
                        column: x => x.SerTypeId,
                        principalTable: "ServiceTypes",
                        principalColumn: "STypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "booking",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<long>(type: "bigint", nullable: false),
                    TravelDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeatCount = table.Column<int>(type: "int", nullable: false),
                    BookBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_booking_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "LocationDescription", "LocationName" },
                values: new object[,]
                {
                    { 1L, null, "HYD" },
                    { 2L, null, "CHN" },
                    { 3L, null, "Mumbai" }
                });

            migrationBuilder.InsertData(
                table: "ServiceTypes",
                columns: new[] { "STypeId", "PricePerKm", "ServiceTypeName" },
                values: new object[,]
                {
                    { 1L, 12.5, "Express" },
                    { 2L, 18.5, "Luxury" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_booking_ServiceId",
                table: "booking",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_DestLocId",
                table: "Services",
                column: "DestLocId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_SerTypeId",
                table: "Services",
                column: "SerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_SourceLocId",
                table: "Services",
                column: "SourceLocId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceTypes_ServiceTypeName",
                table: "ServiceTypes",
                column: "ServiceTypeName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "ServiceTypes");
        }
    }
}
