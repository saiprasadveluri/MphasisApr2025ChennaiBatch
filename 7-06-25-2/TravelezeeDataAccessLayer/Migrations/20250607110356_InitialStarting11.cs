using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelezeeDataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialStarting11 : Migration
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
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_services_locations_SourceLocId",
                table: "services",
                column: "SourceLocId",
                principalTable: "locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);
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
                principalColumn: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_services_locations_SourceLocId",
                table: "services",
                column: "SourceLocId",
                principalTable: "locations",
                principalColumn: "LocationId");
        }
    }
}
