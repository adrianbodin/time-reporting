using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeReporting.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedJobTitleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_JobTitles_JobTitleId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_JobTitleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobTitleId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "HireDate",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "HireDate",
                table: "AspNetUsers",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<string>(
                name: "JobTitleId",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JobTitleId",
                table: "AspNetUsers",
                column: "JobTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_JobTitles_JobTitleId",
                table: "AspNetUsers",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "Id");
        }
    }
}
