using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravlEzeeDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class StatingPoint1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_services_locations_DestLocId",
                table: "services");

            migrationBuilder.DropForeignKey(
                name: "FK_services_locations_SourceLocId",
                table: "services");

            migrationBuilder.AddForeignKey(
                name: "FK_services_locations_DestLocId",
                table: "services",
                column: "DestLocId",
                principalTable: "locations",
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_services_locations_SourceLocId",
                table: "services",
                column: "SourceLocId",
                principalTable: "locations",
                principalColumn: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_services_locations_DestLocId",
                table: "services");

            migrationBuilder.DropForeignKey(
                name: "FK_services_locations_SourceLocId",
                table: "services");

            migrationBuilder.AddForeignKey(
                name: "FK_services_locations_DestLocId",
                table: "services",
                column: "DestLocId",
                principalTable: "locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_services_locations_SourceLocId",
                table: "services",
                column: "SourceLocId",
                principalTable: "locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
