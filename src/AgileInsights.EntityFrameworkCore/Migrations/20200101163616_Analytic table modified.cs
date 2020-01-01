using Microsoft.EntityFrameworkCore.Migrations;

namespace AgileInsights.Migrations
{
    public partial class Analytictablemodified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentName",
                table: "Analytics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrganizationName",
                table: "Analytics",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RemoteClientId",
                table: "Analytics",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_RemoteClientId",
                table: "Analytics",
                column: "RemoteClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Analytics_RemoteClients_RemoteClientId",
                table: "Analytics",
                column: "RemoteClientId",
                principalTable: "RemoteClients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Analytics_RemoteClients_RemoteClientId",
                table: "Analytics");

            migrationBuilder.DropIndex(
                name: "IX_Analytics_RemoteClientId",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "DepartmentName",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "OrganizationName",
                table: "Analytics");

            migrationBuilder.DropColumn(
                name: "RemoteClientId",
                table: "Analytics");
        }
    }
}
