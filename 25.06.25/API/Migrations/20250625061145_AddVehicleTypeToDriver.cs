using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggregatorApi.Migrations
{
    /// <inheritdoc />
    public partial class AddVehicleTypeToDriver : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "Rides",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "Drivers");
        }
    }
}
