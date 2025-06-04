using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelEzeeEFCoreConsole.Migrations
{
    /// <inheritdoc />
    public partial class DbSetup1 : Migration
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
                name: "ServiceType",
                columns: table => new
                {
                    STypeId = table.Column<long>(type: "bigint", nullable: false),
                    ServiceTypeName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PricePerKm = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceType", x => x.STypeId);
                });

            migrationBuilder.CreateTable(
                name: "services",
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
                    table.PrimaryKey("PK_services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_services_ServiceType_SerTypeId",
                        column: x => x.SerTypeId,
                        principalTable: "ServiceType",
                        principalColumn: "STypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_services_locations_DestLocId",
                        column: x => x.DestLocId,
                        principalTable: "locations",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "FK_services_locations_SourceLocId",
                        column: x => x.SourceLocId,
                        principalTable: "locations",
                        principalColumn: "LocationId");
                });

            migrationBuilder.CreateTable(
                name: "bookings",
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
                    table.PrimaryKey("PK_bookings", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_bookings_services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_services_SerTypeId",
                table: "services",
                column: "SerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_services_SourceLocId",
                table: "services",
                column: "SourceLocId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceType_ServiceTypeName",
                table: "ServiceType",
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
                name: "ServiceType");

            migrationBuilder.DropTable(
                name: "locations");
        }
    }
}
