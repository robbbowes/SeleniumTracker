using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeleniumTracker.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Codelines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Codelines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Autotests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Package = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Class = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Failing = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CodelineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autotests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Autotests_Codelines_CodelineId",
                        column: x => x.CodelineId,
                        principalTable: "Codelines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Failures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "date", nullable: false, defaultValue: new DateTime(2022, 6, 8, 19, 19, 5, 884, DateTimeKind.Local).AddTicks(8544)),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutotestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Failures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Failures_Autotests_AutotestId",
                        column: x => x.AutotestId,
                        principalTable: "Autotests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestLinkAnnotations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestlinkId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GeneralWorkflow = table.Column<int>(type: "int", nullable: false),
                    SpecificWorkflow = table.Column<int>(type: "int", nullable: false),
                    Ignore = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutotestId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestLinkAnnotations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestLinkAnnotations_Autotests_AutotestId",
                        column: x => x.AutotestId,
                        principalTable: "Autotests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false, defaultValue: new DateTime(2022, 6, 8, 19, 19, 5, 884, DateTimeKind.Local).AddTicks(9476)),
                    FailureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resolutions_Failures_FailureId",
                        column: x => x.FailureId,
                        principalTable: "Failures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Codelines",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "14.12" });

            migrationBuilder.InsertData(
                table: "Autotests",
                columns: new[] { "Id", "Class", "CodelineId", "Failing", "Name", "Package", "Priority" },
                values: new object[] { 1, "ullam1", 1, true, "iste1", "nihil1", 2 });

            migrationBuilder.InsertData(
                table: "Autotests",
                columns: new[] { "Id", "Class", "CodelineId", "Name", "Package", "Priority" },
                values: new object[,]
                {
                    { 2, "ut2", 1, "aut2", "maiores2", 0 },
                    { 3, "laboriosam3", 1, "omnis3", "inventore3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Autotests",
                columns: new[] { "Id", "Class", "CodelineId", "Failing", "Name", "Package", "Priority" },
                values: new object[,]
                {
                    { 4, "tempora4", 1, true, "iusto4", "et4", 1 },
                    { 5, "et5", 1, true, "debitis5", "deserunt5", 3 },
                    { 6, "qui6", 1, true, "iure6", "autem6", 0 },
                    { 7, "ut7", 1, true, "ab7", "Omnis7", 3 },
                    { 8, "perferendis8", 1, true, "aliquid8", "sunt8", 3 }
                });

            migrationBuilder.InsertData(
                table: "Autotests",
                columns: new[] { "Id", "Class", "CodelineId", "Name", "Package", "Priority" },
                values: new object[] { 9, "ut9", 1, "vel9", "occaecati.9", 3 });

            migrationBuilder.InsertData(
                table: "Autotests",
                columns: new[] { "Id", "Class", "CodelineId", "Failing", "Name", "Package", "Priority" },
                values: new object[,]
                {
                    { 10, "Explicabo10", 1, true, "occaecati10", "vitae10", 2 },
                    { 11, "reiciendis11", 1, true, "nemo.11", "unde11", 2 },
                    { 12, "et12", 1, true, "quis12", "et12", 2 },
                    { 13, "ex13", 1, true, "consectetur13", "molestiae13", 2 },
                    { 14, "Inventore14", 1, true, "voluptatem14", "Quasi14", 3 },
                    { 15, "non15", 1, true, "Voluptatem15", "quas15", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autotests_CodelineId",
                table: "Autotests",
                column: "CodelineId");

            migrationBuilder.CreateIndex(
                name: "IX_Failures_AutotestId",
                table: "Failures",
                column: "AutotestId");

            migrationBuilder.CreateIndex(
                name: "IX_Resolutions_FailureId",
                table: "Resolutions",
                column: "FailureId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestLinkAnnotations_AutotestId",
                table: "TestLinkAnnotations",
                column: "AutotestId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resolutions");

            migrationBuilder.DropTable(
                name: "TestLinkAnnotations");

            migrationBuilder.DropTable(
                name: "Failures");

            migrationBuilder.DropTable(
                name: "Autotests");

            migrationBuilder.DropTable(
                name: "Codelines");
        }
    }
}
