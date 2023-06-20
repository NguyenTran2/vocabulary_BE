using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VocabularyProject.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FoldersIDs",
                table: "Sets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 1,
                column: "FoldersIDs",
                value: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 2,
                column: "FoldersIDs",
                value: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 3,
                column: "FoldersIDs",
                value: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 4,
                column: "FoldersIDs",
                value: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 5,
                column: "FoldersIDs",
                value: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 6,
                column: "FoldersIDs",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoldersIDs",
                table: "Sets");
        }
    }
}
