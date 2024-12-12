using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sonaar.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddedFirmBank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountHolder",
                table: "FirmEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "FirmEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "FirmEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Branch",
                table: "FirmEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IfscCode",
                table: "FirmEntities",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountHolder",
                table: "FirmEntities");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "FirmEntities");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "FirmEntities");

            migrationBuilder.DropColumn(
                name: "Branch",
                table: "FirmEntities");

            migrationBuilder.DropColumn(
                name: "IfscCode",
                table: "FirmEntities");
        }
    }
}
