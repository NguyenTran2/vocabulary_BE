using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VocabularyProject.Migrations
{
    public partial class ThirdAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Contracts");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Marketing");

            migrationBuilder.InsertData(
                table: "Sets",
                columns: new[] { "ID", "Name", "UserID" },
                values: new object[,]
                {
                    { 3, "Warrranties", 2 },
                    { 4, "Business Planning", 2 },
                    { 5, "Conferences", 2 },
                    { 6, "Computers and the Internet", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "English", "TiengViet" },
                values: new object[] { "abide by", "tuân theo" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "English", "TiengViet" },
                values: new object[] { "agreement", "Thoả thuận" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "English", "TiengViet" },
                values: new object[] { "assurance", "đảm bảo" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "ID", "English", "SetID", "TiengViet" },
                values: new object[,]
                {
                    { 4, "determine", 1, "giải quyết vấn đề" },
                    { 5, "engage", 1, "thuê, mướn" },
                    { 6, "establish", 1, "thành lập" },
                    { 7, "obligate", 1, "bắt buộc, ép buộc" },
                    { 8, "party", 1, "nhóm làm việc chung" },
                    { 9, "provision", 1, "sự cung cấp" },
                    { 10, "Resolve", 1, "Giải quyết" },
                    { 11, "specify", 1, "chỉ rõ, định rõ" },
                    { 12, "attract", 2, "hấp dẫn, lôi cuốn, thu hút" },
                    { 13, "compare", 2, "so sánh, đối chiếu" },
                    { 14, "competition", 2, "cạnh tranh, tranh giành, thi đấu" },
                    { 15, "consume", 2, "tiêu thụ, tiêu dùng" },
                    { 16, "convince", 2, "Thuyết phục" },
                    { 17, "currently", 2, "hiện thời, hiện nay, lúc này" },
                    { 18, "fad", 2, "mốt nhất thời, sự thích thú tạm thời; dở hơi, gàn dở" },
                    { 19, "inspiration", 2, "‹sự/người/vật› truyền cảm hứng, gây cảm hứng" },
                    { 20, "market", 2, "thị trường, chợ, nơi mua bán sản phẩm" },
                    { 21, "persuasion", 2, "thuyết phục, làm cho tin" },
                    { 22, "productive", 2, "sản xuất, sinh sản; sinh lợi nhiều, có hiệu quả" },
                    { 23, "satisfaction", 2, "sự làm thỏa mãn, sự hài lòng" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "ABC");

            migrationBuilder.UpdateData(
                table: "Sets",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "ABCD");

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
    }
}
