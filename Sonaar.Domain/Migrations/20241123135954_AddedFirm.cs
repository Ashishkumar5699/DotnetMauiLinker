using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Sonaar.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddedFirm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "ContactDetails",
            //     columns: table => new
            //     {
            //         ContactId = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         ContactPrifix = table.Column<string>(type: "text", nullable: true),
            //         ContactFirstName = table.Column<string>(type: "text", nullable: true),
            //         ContactLastName = table.Column<string>(type: "text", nullable: true),
            //         ContactPhoneNumber = table.Column<string>(type: "text", nullable: true),
            //         ContactAddress1 = table.Column<string>(type: "text", nullable: true),
            //         ContactAddress2 = table.Column<string>(type: "text", nullable: true),
            //         ContactLandMark = table.Column<string>(type: "text", nullable: true),
            //         ContactCity = table.Column<string>(type: "text", nullable: true),
            //         ContactState = table.Column<string>(type: "text", nullable: true),
            //         ContactPinCode = table.Column<string>(type: "text", nullable: true),
            //         AdharNumber = table.Column<string>(type: "text", nullable: true),
            //         PanNumber = table.Column<string>(type: "text", nullable: true),
            //         CustmorGSTNumber = table.Column<string>(type: "text", nullable: true),
            //         CustmorCountry = table.Column<string>(type: "text", nullable: true),
            //         CustmorZipCode = table.Column<string>(type: "text", nullable: true),
            //         ContactType = table.Column<int>(type: "integer", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_ContactDetails", x => x.ContactId);
            //     });

            migrationBuilder.CreateTable(
                name: "FirmEntities",
                columns: table => new
                {
                    FirmId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirmName = table.Column<string>(type: "text", nullable: true),
                    FirmAddress = table.Column<string>(type: "text", nullable: true),
                    FirmGSTNumber = table.Column<string>(type: "text", nullable: true),
                    FirmPhoneNumber = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmEntities", x => x.FirmId);
                });

            // migrationBuilder.CreateTable(
            //     name: "GstAmountEntity",
            //     columns: table => new
            //     {
            //         GstAmountId = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         Discount = table.Column<decimal>(type: "numeric", nullable: false),
            //         TotalAfterDiscount = table.Column<decimal>(type: "numeric", nullable: false),
            //         CGSt = table.Column<decimal>(type: "numeric", nullable: false),
            //         SGST = table.Column<decimal>(type: "numeric", nullable: false),
            //         IGST = table.Column<decimal>(type: "numeric", nullable: false),
            //         GrandTotal = table.Column<decimal>(type: "numeric", nullable: false),
            //         TotalBeforeDiscount = table.Column<decimal>(type: "numeric", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_GstAmountEntity", x => x.GstAmountId);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Users",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         UserName = table.Column<string>(type: "text", nullable: true),
            //         PasswordHash = table.Column<byte[]>(type: "bytea", nullable: true),
            //         PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Users", x => x.Id);
            //     });

            // migrationBuilder.CreateTable(
            //     name: "PreSaleEntities",
            //     columns: table => new
            //     {
            //         PreSaleId = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         Billid = table.Column<int>(type: "integer", nullable: false),
            //         BillType = table.Column<int>(type: "integer", nullable: false),
            //         DateofBill = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //         ContactId = table.Column<int>(type: "integer", nullable: true),
            //         GstAmountId = table.Column<int>(type: "integer", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_PreSaleEntities", x => x.PreSaleId);
            //         table.ForeignKey(
            //             name: "FK_PreSaleEntities_ContactDetails_ContactId",
            //             column: x => x.ContactId,
            //             principalTable: "ContactDetails",
            //             principalColumn: "ContactId");
            //         table.ForeignKey(
            //             name: "FK_PreSaleEntities_GstAmountEntity_GstAmountId",
            //             column: x => x.GstAmountId,
            //             principalTable: "GstAmountEntity",
            //             principalColumn: "GstAmountId");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Quotations",
            //     columns: table => new
            //     {
            //         QuotationId = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         Billid = table.Column<int>(type: "integer", nullable: false),
            //         BillType = table.Column<int>(type: "integer", nullable: false),
            //         DateofBill = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
            //         ContactId = table.Column<int>(type: "integer", nullable: true),
            //         GstAmountId = table.Column<int>(type: "integer", nullable: true)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Quotations", x => x.QuotationId);
            //         table.ForeignKey(
            //             name: "FK_Quotations_ContactDetails_ContactId",
            //             column: x => x.ContactId,
            //             principalTable: "ContactDetails",
            //             principalColumn: "ContactId");
            //         table.ForeignKey(
            //             name: "FK_Quotations_GstAmountEntity_GstAmountId",
            //             column: x => x.GstAmountId,
            //             principalTable: "GstAmountEntity",
            //             principalColumn: "GstAmountId");
            //     });

            // migrationBuilder.CreateTable(
            //     name: "Products",
            //     columns: table => new
            //     {
            //         ProductId = table.Column<int>(type: "integer", nullable: false)
            //             .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
            //         QuotationId = table.Column<int>(type: "integer", nullable: false),
            //         Description = table.Column<string>(type: "text", nullable: true),
            //         HSN_Code = table.Column<string>(type: "text", nullable: true),
            //         Purity = table.Column<string>(type: "text", nullable: true),
            //         Weight = table.Column<decimal>(type: "numeric", nullable: false),
            //         Rate = table.Column<decimal>(type: "numeric", nullable: false),
            //         Making_Charge = table.Column<decimal>(type: "numeric", nullable: false),
            //         Amount = table.Column<decimal>(type: "numeric", nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Products", x => x.ProductId);
            //         table.ForeignKey(
            //             name: "FK_Products_PreSaleEntities_QuotationId",
            //             column: x => x.QuotationId,
            //             principalTable: "PreSaleEntities",
            //             principalColumn: "PreSaleId",
            //             onDelete: ReferentialAction.Cascade);
            //         table.ForeignKey(
            //             name: "FK_Products_Quotations_QuotationId",
            //             column: x => x.QuotationId,
            //             principalTable: "Quotations",
            //             principalColumn: "QuotationId",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateIndex(
            //     name: "IX_PreSaleEntities_ContactId",
            //     table: "PreSaleEntities",
            //     column: "ContactId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_PreSaleEntities_GstAmountId",
            //     table: "PreSaleEntities",
            //     column: "GstAmountId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Products_QuotationId",
            //     table: "Products",
            //     column: "QuotationId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Quotations_ContactId",
            //     table: "Quotations",
            //     column: "ContactId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Quotations_GstAmountId",
            //     table: "Quotations",
            //     column: "GstAmountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FirmEntities");

            // migrationBuilder.DropTable(
            //     name: "Products");

            // migrationBuilder.DropTable(
            //     name: "Users");

            // migrationBuilder.DropTable(
            //     name: "PreSaleEntities");

            // migrationBuilder.DropTable(
            //     name: "Quotations");

            // migrationBuilder.DropTable(
            //     name: "ContactDetails");

            // migrationBuilder.DropTable(
            //     name: "GstAmountEntity");
        }
    }
}
