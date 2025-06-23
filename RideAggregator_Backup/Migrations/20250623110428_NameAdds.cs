using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RideAggregatorAPI.Migrations
{
    /// <inheritdoc />
    public partial class NameAdds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DriverName",
                table: "DriverDatas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "CustomerDatas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverName",
                table: "DriverDatas");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "CustomerDatas");
        }
    }
}
