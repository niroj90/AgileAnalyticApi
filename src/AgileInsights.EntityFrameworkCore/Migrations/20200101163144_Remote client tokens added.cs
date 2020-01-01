using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileInsights.Migrations
{
    public partial class Remoteclienttokensadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RemoteClientTokens",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<Guid>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    Expires = table.Column<DateTime>(nullable: false),
                    RemoteClientId = table.Column<long>(nullable: false),
                    IPAddress = table.Column<string>(nullable: true),
                    LastActivity = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemoteClientTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemoteClientTokens_RemoteClients_RemoteClientId",
                        column: x => x.RemoteClientId,
                        principalTable: "RemoteClients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RemoteClientTokens_RemoteClientId",
                table: "RemoteClientTokens",
                column: "RemoteClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RemoteClientTokens");
        }
    }
}
