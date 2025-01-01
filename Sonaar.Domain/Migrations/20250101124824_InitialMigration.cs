using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Sonaar.Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ContactPrifix = table.Column<string>(type: "text", nullable: true),
                    ContactFirstName = table.Column<string>(type: "text", nullable: true),
                    ContactLastName = table.Column<string>(type: "text", nullable: true),
                    ContactPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    ContactAddress1 = table.Column<string>(type: "text", nullable: true),
                    ContactAddress2 = table.Column<string>(type: "text", nullable: true),
                    ContactLandMark = table.Column<string>(type: "text", nullable: true),
                    ContactCity = table.Column<string>(type: "text", nullable: true),
                    ContactState = table.Column<string>(type: "text", nullable: true),
                    ContactPinCode = table.Column<string>(type: "text", nullable: true),
                    AdharNumber = table.Column<string>(type: "text", nullable: true),
                    PanNumber = table.Column<string>(type: "text", nullable: true),
                    CustmorGSTNumber = table.Column<string>(type: "text", nullable: true),
                    CustmorCountry = table.Column<string>(type: "text", nullable: true),
                    CustmorZipCode = table.Column<string>(type: "text", nullable: true),
                    ContactType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "FirmEntities",
                columns: table => new
                {
                    FirmId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirmName = table.Column<string>(type: "text", nullable: true),
                    FirmAddress = table.Column<string>(type: "text", nullable: true),
                    FirmGSTNumber = table.Column<string>(type: "text", nullable: true),
                    FirmPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    BankName = table.Column<string>(type: "text", nullable: true),
                    AccountNumber = table.Column<string>(type: "text", nullable: true),
                    AccountHolder = table.Column<string>(type: "text", nullable: true),
                    Branch = table.Column<string>(type: "text", nullable: true),
                    IfscCode = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmEntities", x => x.FirmId);
                });

            migrationBuilder.CreateTable(
                name: "GstAmountEntity",
                columns: table => new
                {
                    GstAmountId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Total = table.Column<decimal>(type: "numeric", nullable: false),
                    CGSt = table.Column<decimal>(type: "numeric", nullable: false),
                    SGST = table.Column<decimal>(type: "numeric", nullable: false),
                    IGST = table.Column<decimal>(type: "numeric", nullable: false),
                    GrandTotal = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GstAmountEntity", x => x.GstAmountId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PreSaleBills",
                columns: table => new
                {
                    PreSaleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BillId = table.Column<int>(type: "integer", nullable: false),
                    BillType = table.Column<int>(type: "integer", nullable: false),
                    DateOfBill = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ContactId = table.Column<int>(type: "integer", nullable: true),
                    GstAmountId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreSaleBills", x => x.PreSaleId);
                    table.ForeignKey(
                        name: "FK_PreSaleBills_ContactDetails_ContactId",
                        column: x => x.ContactId,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactId");
                    table.ForeignKey(
                        name: "FK_PreSaleBills_GstAmountEntity_GstAmountId",
                        column: x => x.GstAmountId,
                        principalTable: "GstAmountEntity",
                        principalColumn: "GstAmountId");
                });

            migrationBuilder.CreateTable(
                name: "Quotations",
                columns: table => new
                {
                    QuotationId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Billid = table.Column<int>(type: "integer", nullable: false),
                    BillType = table.Column<int>(type: "integer", nullable: false),
                    DateOfBill = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ContactId = table.Column<int>(type: "integer", nullable: true),
                    GstAmountId = table.Column<int>(type: "integer", nullable: true),
                    IsEnable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotations", x => x.QuotationId);
                    table.ForeignKey(
                        name: "FK_Quotations_ContactDetails_ContactId",
                        column: x => x.ContactId,
                        principalTable: "ContactDetails",
                        principalColumn: "ContactId");
                    table.ForeignKey(
                        name: "FK_Quotations_GstAmountEntity_GstAmountId",
                        column: x => x.GstAmountId,
                        principalTable: "GstAmountEntity",
                        principalColumn: "GstAmountId");
                });

            migrationBuilder.CreateTable(
                name: "RateEntities",
                columns: table => new
                {
                    RateId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Gold24K = table.Column<decimal>(type: "numeric", nullable: false),
                    Gold22K = table.Column<decimal>(type: "numeric", nullable: false),
                    Gold18K = table.Column<decimal>(type: "numeric", nullable: false),
                    Gold14K = table.Column<decimal>(type: "numeric", nullable: false),
                    Silver70 = table.Column<decimal>(type: "numeric", nullable: false),
                    Silver925 = table.Column<decimal>(type: "numeric", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Id = table.Column<int>(type: "integer", nullable: true),
                    ExpireOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RateEntities", x => x.RateId);
                    table.ForeignKey(
                        name: "FK_RateEntities_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PreSaleProductEntity",
                columns: table => new
                {
                    PreSaleProductId = table.Column<int>(type: "integer", nullable: false),
                    PreSaleId = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<int>(type: "integer", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    HSN_Code = table.Column<string>(type: "text", nullable: true),
                    Purity = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<decimal>(type: "numeric", nullable: false),
                    Rate = table.Column<decimal>(type: "numeric", nullable: false),
                    Making_Charge = table.Column<decimal>(type: "numeric", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreSaleProductEntity", x => x.PreSaleProductId);
                    table.ForeignKey(
                        name: "FK_PreSaleProductEntity_PreSaleBills_PreSaleProductId",
                        column: x => x.PreSaleProductId,
                        principalTable: "PreSaleBills",
                        principalColumn: "PreSaleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    QuotationId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    HSN_Code = table.Column<string>(type: "text", nullable: true),
                    Purity = table.Column<string>(type: "text", nullable: true),
                    Weight = table.Column<decimal>(type: "numeric", nullable: false),
                    Rate = table.Column<decimal>(type: "numeric", nullable: false),
                    Making_Charge = table.Column<decimal>(type: "numeric", nullable: false),
                    Amount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Quotations_QuotationId",
                        column: x => x.QuotationId,
                        principalTable: "Quotations",
                        principalColumn: "QuotationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreSaleBills_ContactId",
                table: "PreSaleBills",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_PreSaleBills_GstAmountId",
                table: "PreSaleBills",
                column: "GstAmountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_QuotationId",
                table: "Products",
                column: "QuotationId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_ContactId",
                table: "Quotations",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_GstAmountId",
                table: "Quotations",
                column: "GstAmountId");

            migrationBuilder.CreateIndex(
                name: "IX_RateEntities_Id",
                table: "RateEntities",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirmEntities");

            migrationBuilder.DropTable(
                name: "PreSaleProductEntity");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RateEntities");

            migrationBuilder.DropTable(
                name: "PreSaleBills");

            migrationBuilder.DropTable(
                name: "Quotations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "GstAmountEntity");
        }
    }
}
