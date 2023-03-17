using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitWeb.Data.Migrations
{
    public partial class MakeChangesInModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrganizationsRepositories");

            migrationBuilder.RenameColumn(
                name: "FriendlyName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "UsersReposStars",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "OrganizationsRepos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    StarCount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationsRepos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationsRepos_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersReposStars_UserId",
                table: "UsersReposStars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationsRepos_OrganizationId",
                table: "OrganizationsRepos",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsersReposStars_Users_UserId",
                table: "UsersReposStars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsersReposStars_Users_UserId",
                table: "UsersReposStars");

            migrationBuilder.DropTable(
                name: "OrganizationsRepos");

            migrationBuilder.DropIndex(
                name: "IX_UsersReposStars_UserId",
                table: "UsersReposStars");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UsersReposStars");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "FriendlyName");

            migrationBuilder.CreateTable(
                name: "OrganizationsRepositories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarCount = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationsRepositories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrganizationsRepositories_Organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrganizationsRepositories_OrganizationId",
                table: "OrganizationsRepositories",
                column: "OrganizationId");
        }
    }
}
