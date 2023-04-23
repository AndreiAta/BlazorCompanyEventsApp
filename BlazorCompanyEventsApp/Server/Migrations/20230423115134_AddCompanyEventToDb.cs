using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorCompanyEventsApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyEventToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyEventId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_CompanyEvents_CompanyEventId",
                        column: x => x.CompanyEventId,
                        principalTable: "CompanyEvents",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "CompanyEvents",
                columns: new[] { "Id", "DateAndTime", "Description", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Annual party held for the entire company", "Annual Party" },
                    { 2, new DateTime(2023, 4, 23, 11, 51, 34, 94, DateTimeKind.Utc).AddTicks(8040), "Introduction course to React for beginners", "Intro course to React.js" },
                    { 3, new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "SQL learning module", "Learning in databases" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_CompanyEventId",
                table: "Participants",
                column: "CompanyEventId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "CompanyEvents");
        }
    }
}
