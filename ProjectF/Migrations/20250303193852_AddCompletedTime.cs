using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectF.Migrations
{
    /// <inheritdoc />
    public partial class AddCompletedTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "TaskItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TaskItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TaskItems");
        }
    }
}
