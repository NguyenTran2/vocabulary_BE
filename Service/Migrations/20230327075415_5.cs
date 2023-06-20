using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VocabularyProject.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NewestDateLearn",
                table: "Sets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserSharedID",
                table: "Sets",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NewestDateLearn",
                table: "Sets");

            migrationBuilder.DropColumn(
                name: "UserSharedID",
                table: "Sets");
        }
    }
}
