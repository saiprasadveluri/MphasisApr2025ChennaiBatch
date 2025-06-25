using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAppAgg.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<int>(type: "int", nullable: false),
                    DName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CId);
                    table.ForeignKey(
                        name: "FK_Customers_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<int>(type: "int", nullable: false),
                    DName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    NoOfRides = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DId);
                    table.ForeignKey(
                        name: "FK_Drivers_Users_UId",
                        column: x => x.UId,
                        principalTable: "Users",
                        principalColumn: "UId");
                });

            migrationBuilder.CreateTable(
                name: "PickupDrops",
                columns: table => new
                {
                    PId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DId = table.Column<int>(type: "int", nullable: false),
                    CId = table.Column<int>(type: "int", nullable: false),
                    PickupLocationId = table.Column<int>(type: "int", nullable: false),
                    DropLocationId = table.Column<int>(type: "int", nullable: false),
                    PickupTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DropTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LocationLId = table.Column<int>(type: "int", nullable: true),
                    LocationLId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickupDrops", x => x.PId);
                    table.ForeignKey(
                        name: "FK_PickupDrops_Customers_CId",
                        column: x => x.CId,
                        principalTable: "Customers",
                        principalColumn: "CId");
                    table.ForeignKey(
                        name: "FK_PickupDrops_Drivers_DId",
                        column: x => x.DId,
                        principalTable: "Drivers",
                        principalColumn: "DId");
                    table.ForeignKey(
                        name: "FK_PickupDrops_Locations_DropLocationId",
                        column: x => x.DropLocationId,
                        principalTable: "Locations",
                        principalColumn: "LId");
                    table.ForeignKey(
                        name: "FK_PickupDrops_Locations_LocationLId",
                        column: x => x.LocationLId,
                        principalTable: "Locations",
                        principalColumn: "LId");
                    table.ForeignKey(
                        name: "FK_PickupDrops_Locations_LocationLId1",
                        column: x => x.LocationLId1,
                        principalTable: "Locations",
                        principalColumn: "LId");
                    table.ForeignKey(
                        name: "FK_PickupDrops_Locations_PickupLocationId",
                        column: x => x.PickupLocationId,
                        principalTable: "Locations",
                        principalColumn: "LId");
                });

            migrationBuilder.CreateTable(
                name: "Rides",
                columns: table => new
                {
                    RId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PId = table.Column<int>(type: "int", nullable: false),
                    Distance = table.Column<double>(type: "float", nullable: false),
                    CostPerKm = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rides", x => x.RId);
                    table.ForeignKey(
                        name: "FK_Rides_PickupDrops_PId",
                        column: x => x.PId,
                        principalTable: "PickupDrops",
                        principalColumn: "PId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UId",
                table: "Customers",
                column: "UId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_UId",
                table: "Drivers",
                column: "UId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PickupDrops_CId",
                table: "PickupDrops",
                column: "CId");

            migrationBuilder.CreateIndex(
                name: "IX_PickupDrops_DId",
                table: "PickupDrops",
                column: "DId");

            migrationBuilder.CreateIndex(
                name: "IX_PickupDrops_DropLocationId",
                table: "PickupDrops",
                column: "DropLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PickupDrops_LocationLId",
                table: "PickupDrops",
                column: "LocationLId");

            migrationBuilder.CreateIndex(
                name: "IX_PickupDrops_LocationLId1",
                table: "PickupDrops",
                column: "LocationLId1");

            migrationBuilder.CreateIndex(
                name: "IX_PickupDrops_PickupLocationId",
                table: "PickupDrops",
                column: "PickupLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rides_PId",
                table: "Rides",
                column: "PId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rides");

            migrationBuilder.DropTable(
                name: "PickupDrops");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
