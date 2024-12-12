using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sonaar.Domain.Migrations
{
    /// <inheritdoc />
    public partial class UpdateQuotation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsEnable",
                table: "Quotations",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEnable",
                table: "Quotations");
        }
    }
}
