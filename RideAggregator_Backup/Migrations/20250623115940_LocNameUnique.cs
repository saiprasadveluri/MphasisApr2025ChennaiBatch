using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggregatorAPI.Migrations
{
    /// <inheritdoc />
    public partial class LocNameUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationName",
                table: "Locations",
                column: "LocationName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Locations_LocationName",
                table: "Locations");
        }
    }
}
