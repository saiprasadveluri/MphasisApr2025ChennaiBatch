using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggregatorApi.Migrations
{
    /// <inheritdoc />
    public partial class ExtendRentalsRideTracking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AcceptedAt",
                table: "Rides",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedAt",
                table: "Rides",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedDistance",
                table: "Rides",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstimatedTime",
                table: "Rides",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "Rides",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptedAt",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "CompletedAt",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "EstimatedDistance",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "EstimatedTime",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "Rides");
        }
    }
}
