using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VocabularyProject.Migrations
{
    public partial class FirstAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sets_Users",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    English = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TiengViet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SetID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Words_Sets",
                        column: x => x.SetID,
                        principalTable: "Sets",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Name", "Password" },
                values: new object[] { 1, "LHN", "LHN" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Name", "Password" },
                values: new object[] { 2, "VTAT", "VTAT" });

            migrationBuilder.InsertData(
                table: "Sets",
                columns: new[] { "ID", "Name", "UserID" },
                values: new object[] { 1, "ABC", 1 });

            migrationBuilder.InsertData(
                table: "Sets",
                columns: new[] { "ID", "Name", "UserID" },
                values: new object[] { 2, "ABCD", 2 });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "ID", "English", "SetID", "TiengViet" },
                values: new object[] { 1, "hiệu suất, buổi diễn", 1, "Performance" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "ID", "English", "SetID", "TiengViet" },
                values: new object[] { 2, "Chỉ rõ, định rõ", 1, "Specify" });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "ID", "English", "SetID", "TiengViet" },
                values: new object[] { 3, "Giải quyết", 1, "Resolve" });

            migrationBuilder.CreateIndex(
                name: "IX_Sets_UserID",
                table: "Sets",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Words_SetID",
                table: "Words",
                column: "SetID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "Sets");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
