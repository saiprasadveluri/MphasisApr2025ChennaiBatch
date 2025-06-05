using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelEzeeEFConsole.Migrations
{
    /// <inheritdoc />
    public partial class Location : Migration
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
                name: "Servicetypes",
                columns: table => new
                {
                    STypeId = table.Column<long>(type: "bigint", nullable: false),
                    ServiceTypeName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PricePerKm = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicetypes", x => x.STypeId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
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
                        name: "FK_Services_Servicetypes_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "Servicetypes",
                        principalColumn: "STypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
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
                    table.PrimaryKey("PK_Bookings", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Bookings_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_ServiceId",
                table: "Bookings",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_DestLocId",
                table: "Services",
                column: "DestLocId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_ServiceTypeId",
                table: "Services",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_SourceLocId",
                table: "Services",
                column: "SourceLocId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicetypes_ServiceTypeName",
                table: "Servicetypes",
                column: "ServiceTypeName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Servicetypes");
        }
    }
}
