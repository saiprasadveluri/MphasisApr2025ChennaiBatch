using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggerator.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocId);
                });

            migrationBuilder.CreateTable(
                name: "UserDatas",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDatas", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerDatas",
                columns: table => new
                {
                    CustId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerDatas", x => x.CustId);
                    table.ForeignKey(
                        name: "FK_CustomerDatas_UserDatas_LoginId",
                        column: x => x.LoginId,
                        principalTable: "UserDatas",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriverDatas",
                columns: table => new
                {
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverDatas", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_DriverDatas_UserDatas_LoginId",
                        column: x => x.LoginId,
                        principalTable: "UserDatas",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PickupRides",
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
                    table.PrimaryKey("PK_PickupRides", x => x.PickupId);
                    table.ForeignKey(
                        name: "FK_PickupRides_CustomerDatas_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerDatas",
                        principalColumn: "CustId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PickupRides_DriverDatas_DriverId",
                        column: x => x.DriverId,
                        principalTable: "DriverDatas",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PickupRides_Locations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Locations",
                        principalColumn: "LocId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PickupRides_Locations_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Locations",
                        principalColumn: "LocId",
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
                        name: "FK_RentalRides_CustomerDatas_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CustomerDatas",
                        principalColumn: "CustId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RentalRides_DriverDatas_DriverId",
                        column: x => x.DriverId,
                        principalTable: "DriverDatas",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RentalRides_Locations_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Locations",
                        principalColumn: "LocId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerDatas_LoginId",
                table: "CustomerDatas",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverDatas_LoginId",
                table: "DriverDatas",
                column: "LoginId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_LocationName",
                table: "Locations",
                column: "LocationName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PickupRides_CustomerId",
                table: "PickupRides",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_PickupRides_DestinationId",
                table: "PickupRides",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_PickupRides_DriverId",
                table: "PickupRides",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_PickupRides_SourceId",
                table: "PickupRides",
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
                name: "PickupRides");

            migrationBuilder.DropTable(
                name: "RentalRides");

            migrationBuilder.DropTable(
                name: "CustomerDatas");

            migrationBuilder.DropTable(
                name: "DriverDatas");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "UserDatas");
        }
    }
}
