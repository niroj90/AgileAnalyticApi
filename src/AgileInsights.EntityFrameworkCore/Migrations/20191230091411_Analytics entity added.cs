using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileInsights.Migrations
{
    public partial class Analyticsentityadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Analytics",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ConnectionStringId = table.Column<long>(nullable: false),
                    OrganizationId = table.Column<long>(nullable: false),
                    DepartmentId = table.Column<long>(nullable: false),
                    Periodicity = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Average = table.Column<decimal>(nullable: false),
                    Sum = table.Column<decimal>(nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Analytics_ConnectionStrings_ConnectionStringId",
                        column: x => x.ConnectionStringId,
                        principalTable: "ConnectionStrings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_ConnectionStringId",
                table: "Analytics",
                column: "ConnectionStringId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analytics");
        }
    }
}
