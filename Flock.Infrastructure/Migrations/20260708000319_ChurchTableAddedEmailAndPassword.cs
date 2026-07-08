using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flock.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChurchTableAddedEmailAndPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "church",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "church",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "church");

            migrationBuilder.DropColumn(
                name: "password",
                table: "church");
        }
    }
}
