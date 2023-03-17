using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitWeb.Data.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "OrganizationsMembers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationsMembers_UserId",
                table: "OrganizationsMembers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrganizationsMembers_Users_UserId",
                table: "OrganizationsMembers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrganizationsMembers_Users_UserId",
                table: "OrganizationsMembers");

            migrationBuilder.DropIndex(
                name: "IX_OrganizationsMembers_UserId",
                table: "OrganizationsMembers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OrganizationsMembers");
        }
    }
}
