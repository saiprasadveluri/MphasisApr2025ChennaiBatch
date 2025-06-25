using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggregatorWEBAPI.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PickupDropRides_Locations_DestinationLocationId",
                table: "PickupDropRides");

            migrationBuilder.DropForeignKey(
                name: "FK_PickupDropRides_Locations_SourceLocationId",
                table: "PickupDropRides");

            migrationBuilder.AddForeignKey(
                name: "FK_PickupDropRides_Locations_DestinationLocationId",
                table: "PickupDropRides",
                column: "DestinationLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PickupDropRides_Locations_SourceLocationId",
                table: "PickupDropRides",
                column: "SourceLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PickupDropRides_Locations_DestinationLocationId",
                table: "PickupDropRides");

            migrationBuilder.DropForeignKey(
                name: "FK_PickupDropRides_Locations_SourceLocationId",
                table: "PickupDropRides");

            migrationBuilder.AddForeignKey(
                name: "FK_PickupDropRides_Locations_DestinationLocationId",
                table: "PickupDropRides",
                column: "DestinationLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PickupDropRides_Locations_SourceLocationId",
                table: "PickupDropRides",
                column: "SourceLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
