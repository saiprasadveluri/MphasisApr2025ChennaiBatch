using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggregatorAPI.Migrations
{
    /// <inheritdoc />
    public partial class prem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocationInfos",
                columns: table => new
                {
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocationInfos", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    URole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInfos",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInfos", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_CustomerInfos_UserInfos_LoginId",
                        column: x => x.LoginId,
                        principalTable: "UserInfos",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriverInfos",
                columns: table => new
                {
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverInfos", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_DriverInfos_UserInfos_LoginId",
                        column: x => x.LoginId,
                        principalTable: "UserInfos",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pickUpDropRides",
                columns: table => new
                {
                    PickupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pickUpDropRides", x => x.PickupId);
                    table.ForeignKey(
                        name: "FK_pickUpDropRides_CustomerInfos_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerInfos",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_pickUpDropRides_DriverInfos_DriverId",
                        column: x => x.DriverId,
                        principalTable: "DriverInfos",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_pickUpDropRides_LocationInfos_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "LocationInfos",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_pickUpDropRides_LocationInfos_SourceId",
                        column: x => x.SourceId,
                        principalTable: "LocationInfos",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RentalRides",
                columns: table => new
                {
                    RetalRideId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    HiredDays = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalRides", x => x.RetalRideId);
                    table.ForeignKey(
                        name: "FK_RentalRides_CustomerInfos_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerInfos",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RentalRides_DriverInfos_DriverId",
                        column: x => x.DriverId,
                        principalTable: "DriverInfos",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RentalRides_LocationInfos_SourceId",
                        column: x => x.SourceId,
                        principalTable: "LocationInfos",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInfos_LoginId",
                table: "CustomerInfos",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverInfos_LoginId",
                table: "DriverInfos",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_LocationInfos_LocationName",
                table: "LocationInfos",
                column: "LocationName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_pickUpDropRides_CustomerId",
                table: "pickUpDropRides",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_pickUpDropRides_DestinationId",
                table: "pickUpDropRides",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_pickUpDropRides_DriverId",
                table: "pickUpDropRides",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_pickUpDropRides_SourceId",
                table: "pickUpDropRides",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalRides_CustomerId",
                table: "RentalRides",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalRides_DriverId",
                table: "RentalRides",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalRides_SourceId",
                table: "RentalRides",
                column: "SourceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pickUpDropRides");

            migrationBuilder.DropTable(
                name: "RentalRides");

            migrationBuilder.DropTable(
                name: "CustomerInfos");

            migrationBuilder.DropTable(
                name: "DriverInfos");

            migrationBuilder.DropTable(
                name: "LocationInfos");

            migrationBuilder.DropTable(
                name: "UserInfos");
        }
    }
}
