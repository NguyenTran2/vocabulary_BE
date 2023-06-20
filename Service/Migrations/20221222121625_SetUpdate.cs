using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VocabularyProject.Migrations
{
    public partial class SetUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameVi",
                table: "Sets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 1,
                column: "NameVi",
                value: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 2,
                column: "NameVi",
                value: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 3,
                column: "NameVi",
                value: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 4,
                column: "NameVi",
                value: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 5,
                column: "NameVi",
                value: "");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 6,
                column: "NameVi",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NameVi",
                table: "Sets");
        }
    }
}
