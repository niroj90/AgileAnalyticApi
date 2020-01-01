using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileInsights.Migrations
{
    public partial class connectionstringstabledropped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analytics_ConnectionStrings_ConnectionStringId",
                table: "Analytics");

            migrationBuilder.DropTable(
                name: "ConnectionStrings");

            migrationBuilder.DropTable(
                name: "TableReferences");

            migrationBuilder.DropIndex(
                name: "IX_Analytics_ConnectionStringId",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "ConnectionStringId",
                table: "Analytics");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ConnectionStringId",
                table: "Analytics",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "ConnectionStrings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConnectionStringValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    DatabaseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectionStrings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TableReferences",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColumnName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ConnectionStringId = table.Column<long>(type: "bigint", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    MappedColumnName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TableReferences", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_ConnectionStringId",
                table: "Analytics",
                column: "ConnectionStringId");

            migrationBuilder.AddForeignKey(
                name: "FK_Analytics_ConnectionStrings_ConnectionStringId",
                table: "Analytics",
                column: "ConnectionStringId",
                principalTable: "ConnectionStrings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
