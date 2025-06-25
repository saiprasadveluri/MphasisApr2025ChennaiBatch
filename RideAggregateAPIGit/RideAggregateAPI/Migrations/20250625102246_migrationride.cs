using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggregateAPI.Migrations
{
    /// <inheritdoc />
    public partial class migrationride : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocId);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerInfo",
                columns: table => new
                {
                    CustId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInfo", x => x.CustId);
                    table.ForeignKey(
                        name: "FK_CustomerInfo_UserInfo_LoginId",
                        column: x => x.LoginId,
                        principalTable: "UserInfo",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriverInfo",
                columns: table => new
                {
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    VehicleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleNo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverInfo", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_DriverInfo_UserInfo_LoginId",
                        column: x => x.LoginId,
                        principalTable: "UserInfo",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PickUpDropRides",
                columns: table => new
                {
                    pickUpId = table.Column<long>(type: "bigint", nullable: false),
                    custId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    driverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    sourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    destinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    distance = table.Column<double>(type: "float", nullable: false),
                    CustomerCustId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickUpDropRides", x => x.pickUpId);
                    table.ForeignKey(
                        name: "FK_PickUpDropRides_CustomerInfo_CustomerCustId",
                        column: x => x.CustomerCustId,
                        principalTable: "CustomerInfo",
                        principalColumn: "CustId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PickUpDropRides_DriverInfo_driverId",
                        column: x => x.driverId,
                        principalTable: "DriverInfo",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PickUpDropRides_Location_destinationId",
                        column: x => x.destinationId,
                        principalTable: "Location",
                        principalColumn: "LocId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PickUpDropRides_Location_sourceId",
                        column: x => x.sourceId,
                        principalTable: "Location",
                        principalColumn: "LocId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "RentalRide",
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
                    table.PrimaryKey("PK_RentalRide", x => x.RetalRideId);
                    table.ForeignKey(
                        name: "FK_RentalRide_CustomerInfo_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerInfo",
                        principalColumn: "CustId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RentalRide_DriverInfo_DriverId",
                        column: x => x.DriverId,
                        principalTable: "DriverInfo",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RentalRide_Location_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Location",
                        principalColumn: "LocId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInfo_LoginId",
                table: "CustomerInfo",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverInfo_LoginId",
                table: "DriverInfo",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LocName",
                table: "Location",
                column: "LocName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PickUpDropRides_CustomerCustId",
                table: "PickUpDropRides",
                column: "CustomerCustId");

            migrationBuilder.CreateIndex(
                name: "IX_PickUpDropRides_destinationId",
                table: "PickUpDropRides",
                column: "destinationId");

            migrationBuilder.CreateIndex(
                name: "IX_PickUpDropRides_driverId",
                table: "PickUpDropRides",
                column: "driverId");

            migrationBuilder.CreateIndex(
                name: "IX_PickUpDropRides_sourceId",
                table: "PickUpDropRides",
                column: "sourceId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalRide_CustomerId",
                table: "RentalRide",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalRide_DriverId",
                table: "RentalRide",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalRide_SourceId",
                table: "RentalRide",
                column: "SourceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PickUpDropRides");

            migrationBuilder.DropTable(
                name: "RentalRide");

            migrationBuilder.DropTable(
                name: "CustomerInfo");

            migrationBuilder.DropTable(
                name: "DriverInfo");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "UserInfo");
        }
    }
}
