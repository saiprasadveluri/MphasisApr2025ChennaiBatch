using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineQuizApplicationAPI.Migrations
{
    /// <inheritdoc />
    public partial class Data4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizs_Category_CategoryId",
                table: "Quizs");

            migrationBuilder.DropIndex(
                name: "IX_Quizs_CategoryId",
                table: "Quizs");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Quizs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Quizs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quizs_CategoryId",
                table: "Quizs",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizs_Category_CategoryId",
                table: "Quizs",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId");
        }
    }
}
