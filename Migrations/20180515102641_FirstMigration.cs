using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LK2.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoryProducts",
                columns: table => new
                {
                    CategoryProductID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Image = table.Column<string>(nullable: true),
                    Position = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProducts", x => x.CategoryProductID);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryProductID = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_CategoryProducts_CategoryProductID",
                        column: x => x.CategoryProductID,
                        principalTable: "CategoryProducts",
                        principalColumn: "CategoryProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProductLanguages",
                columns: table => new
                {
                    CategoryProductID = table.Column<int>(nullable: false),
                    LanguageID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProductLanguages", x => new { x.CategoryProductID, x.LanguageID });
                    table.ForeignKey(
                        name: "FK_CategoryProductLanguages_CategoryProducts_CategoryProductID",
                        column: x => x.CategoryProductID,
                        principalTable: "CategoryProducts",
                        principalColumn: "CategoryProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProductLanguages_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryProductPositions",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false),
                    CategoryProductID = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Selection = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryProductPositions", x => new { x.ProductID, x.CategoryProductID, x.Position });
                    table.UniqueConstraint("AK_ProductCategoryProductPositions_CategoryProductID_Position_ProductID", x => new { x.CategoryProductID, x.Position, x.ProductID });
                    table.ForeignKey(
                        name: "FK_ProductCategoryProductPositions_CategoryProducts_CategoryProductID",
                        column: x => x.CategoryProductID,
                        principalTable: "CategoryProducts",
                        principalColumn: "CategoryProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategoryProductPositions_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductLanguages",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false),
                    LanguageID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLanguages", x => new { x.ProductID, x.LanguageID });
                    table.UniqueConstraint("AK_ProductLanguages_LanguageID_ProductID", x => new { x.LanguageID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_ProductLanguages_Languages_LanguageID",
                        column: x => x.LanguageID,
                        principalTable: "Languages",
                        principalColumn: "LanguageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductLanguages_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProductLanguages_LanguageID",
                table: "CategoryProductLanguages",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryProductID",
                table: "Products",
                column: "CategoryProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProductLanguages");

            migrationBuilder.DropTable(
                name: "ProductCategoryProductPositions");

            migrationBuilder.DropTable(
                name: "ProductLanguages");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "CategoryProducts");
        }
    }
}
