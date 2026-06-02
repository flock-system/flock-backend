using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Flock.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedTenantId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tenantId",
                table: "members");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "tenantId",
                table: "members",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
