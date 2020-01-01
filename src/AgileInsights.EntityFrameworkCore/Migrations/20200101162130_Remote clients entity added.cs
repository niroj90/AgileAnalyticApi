using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileInsights.Migrations
{
    public partial class Remoteclientsentityadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RemoteClients",
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
                    DisplayName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    ComputerName = table.Column<string>(nullable: true),
                    ComputerMac = table.Column<string>(nullable: true),
                    LastSync = table.Column<DateTime>(nullable: true),
                    PrivateKey = table.Column<string>(nullable: true),
                    PublicKey = table.Column<string>(nullable: true),
                    AESKey = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemoteClients", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RemoteClients");
        }
    }
}
