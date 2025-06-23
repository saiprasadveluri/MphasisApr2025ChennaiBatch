using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggregatorAPI.Migrations
{
    /// <inheritdoc />
    public partial class Prmkeychange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PickupId",
                table: "RentalRides",
                newName: "RetalRideId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RetalRideId",
                table: "RentalRides",
                newName: "PickupId");
        }
    }
}
