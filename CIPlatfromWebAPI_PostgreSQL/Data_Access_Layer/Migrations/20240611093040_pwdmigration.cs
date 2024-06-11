using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data_Access_Layer.Migrations
{
    /// <inheritdoc />
    public partial class pwdmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CIProject");

            migrationBuilder.RenameTable(
                name: "UserDetail",
                newName: "UserDetail",
                newSchema: "CIProject");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "User",
                newSchema: "CIProject");

            migrationBuilder.RenameTable(
                name: "Missions",
                newName: "Missions",
                newSchema: "CIProject");

            migrationBuilder.RenameTable(
                name: "MissionTheme",
                newName: "MissionTheme",
                newSchema: "CIProject");

            migrationBuilder.RenameTable(
                name: "MissionSkill",
                newName: "MissionSkill",
                newSchema: "CIProject");

            migrationBuilder.RenameTable(
                name: "MissionApplication",
                newName: "MissionApplication",
                newSchema: "CIProject");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Country",
                newSchema: "CIProject");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "City",
                newSchema: "CIProject");

            migrationBuilder.CreateTable(
                name: "ContactUs",
                schema: "CIProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    EmailAddress = table.Column<string>(type: "text", nullable: false),
                    Subject = table.Column<string>(type: "text", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSkills",
                schema: "CIProject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Skill = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSkills", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactUs",
                schema: "CIProject");

            migrationBuilder.DropTable(
                name: "UserSkills",
                schema: "CIProject");

            migrationBuilder.RenameTable(
                name: "UserDetail",
                schema: "CIProject",
                newName: "UserDetail");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "CIProject",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Missions",
                schema: "CIProject",
                newName: "Missions");

            migrationBuilder.RenameTable(
                name: "MissionTheme",
                schema: "CIProject",
                newName: "MissionTheme");

            migrationBuilder.RenameTable(
                name: "MissionSkill",
                schema: "CIProject",
                newName: "MissionSkill");

            migrationBuilder.RenameTable(
                name: "MissionApplication",
                schema: "CIProject",
                newName: "MissionApplication");

            migrationBuilder.RenameTable(
                name: "Country",
                schema: "CIProject",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "City",
                schema: "CIProject",
                newName: "City");
        }
    }
}
