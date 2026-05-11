using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flock.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeMemberIdToInt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "members",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "members",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isActive",
                table: "members",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "members",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "members");

            migrationBuilder.DropColumn(
                name: "email",
                table: "members");

            migrationBuilder.DropColumn(
                name: "isActive",
                table: "members");

            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "members");
        }
    }
}
