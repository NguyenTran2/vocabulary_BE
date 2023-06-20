using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VocabularyProject.Migrations
{
    public partial class secondAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "English", "TiengViet" },
                values: new object[] { "Performance", "hiệu suất, buổi diễn" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "English", "TiengViet" },
                values: new object[] { "Specify", "Chỉ rõ, định rõ" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "English", "TiengViet" },
                values: new object[] { "Resolve", "Giải quyết" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "English", "TiengViet" },
                values: new object[] { "hiệu suất, buổi diễn", "Performance" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "English", "TiengViet" },
                values: new object[] { "Chỉ rõ, định rõ", "Specify" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "English", "TiengViet" },
                values: new object[] { "Giải quyết", "Resolve" });
        }
    }
}
