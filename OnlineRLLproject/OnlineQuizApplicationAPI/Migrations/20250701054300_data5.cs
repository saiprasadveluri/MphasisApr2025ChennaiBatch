using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineQuizApplicationAPI.Migrations
{
    /// <inheritdoc />
    public partial class data5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionText",
                table: "Questions",
                column: "QuestionText",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Questions_QuestionText",
                table: "Questions");
        }
    }
}
