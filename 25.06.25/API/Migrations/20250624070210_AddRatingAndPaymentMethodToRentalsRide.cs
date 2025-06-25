using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggregatorApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRatingAndPaymentMethodToRentalsRide : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distance",
                table: "Rides");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Rides");

            migrationBuilder.RenameColumn(
                name: "HiredDays",
                table: "Rides",
                newName: "Rating");

            migrationBuilder.AlterColumn<double>(
                name: "TollFees",
                table: "Rides",
                type: "float(18)",
                precision: 18,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentMethod",
                table: "Rides",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMethod",
                table: "Rides");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Rides",
                newName: "HiredDays");

            migrationBuilder.AlterColumn<decimal>(
                name: "TollFees",
                table: "Rides",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float(18)",
                oldPrecision: 18,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Distance",
                table: "Rides",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Rides",
                type: "datetime2",
                nullable: true);
        }
    }
}
