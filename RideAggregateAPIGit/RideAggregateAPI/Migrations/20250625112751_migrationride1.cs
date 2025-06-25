using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggregateAPI.Migrations
{
    /// <inheritdoc />
    public partial class migrationride1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PickUpDropRides_CustomerInfo_CustomerCustId",
                table: "PickUpDropRides");

            migrationBuilder.DropIndex(
                name: "IX_PickUpDropRides_CustomerCustId",
                table: "PickUpDropRides");

            migrationBuilder.DropColumn(
                name: "CustomerCustId",
                table: "PickUpDropRides");

            migrationBuilder.CreateIndex(
                name: "IX_PickUpDropRides_custId",
                table: "PickUpDropRides",
                column: "custId");

            migrationBuilder.AddForeignKey(
                name: "FK_PickUpDropRides_CustomerInfo_custId",
                table: "PickUpDropRides",
                column: "custId",
                principalTable: "CustomerInfo",
                principalColumn: "CustId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PickUpDropRides_CustomerInfo_custId",
                table: "PickUpDropRides");

            migrationBuilder.DropIndex(
                name: "IX_PickUpDropRides_custId",
                table: "PickUpDropRides");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerCustId",
                table: "PickUpDropRides",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_PickUpDropRides_CustomerCustId",
                table: "PickUpDropRides",
                column: "CustomerCustId");

            migrationBuilder.AddForeignKey(
                name: "FK_PickUpDropRides_CustomerInfo_CustomerCustId",
                table: "PickUpDropRides",
                column: "CustomerCustId",
                principalTable: "CustomerInfo",
                principalColumn: "CustId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
