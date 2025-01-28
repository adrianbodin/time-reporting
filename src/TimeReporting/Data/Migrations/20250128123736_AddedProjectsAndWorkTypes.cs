using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeReporting.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedProjectsAndWorkTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntries_Customers_CustomerId",
                table: "TimeEntries");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "TimeEntries",
                newName: "WorkTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeEntries_CustomerId",
                table: "TimeEntries",
                newName: "IX_TimeEntries_WorkTypeId");

            migrationBuilder.AddColumn<string>(
                name: "ProjectId",
                table: "TimeEntries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    CustomerId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkTypes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    HourlyRate = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeEntries_ProjectId",
                table: "TimeEntries",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CustomerId",
                table: "Projects",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntries_Projects_ProjectId",
                table: "TimeEntries",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntries_WorkTypes_WorkTypeId",
                table: "TimeEntries",
                column: "WorkTypeId",
                principalTable: "WorkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntries_Projects_ProjectId",
                table: "TimeEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_TimeEntries_WorkTypes_WorkTypeId",
                table: "TimeEntries");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "WorkTypes");

            migrationBuilder.DropIndex(
                name: "IX_TimeEntries_ProjectId",
                table: "TimeEntries");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "TimeEntries");

            migrationBuilder.RenameColumn(
                name: "WorkTypeId",
                table: "TimeEntries",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_TimeEntries_WorkTypeId",
                table: "TimeEntries",
                newName: "IX_TimeEntries_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeEntries_Customers_CustomerId",
                table: "TimeEntries",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
