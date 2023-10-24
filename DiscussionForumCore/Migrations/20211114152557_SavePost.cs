using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscussionForumCore.Migrations
{
    public partial class SavePost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "savedPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quetionId = table.Column<int>(type: "int", nullable: false),
                    questionId = table.Column<int>(type: "int", nullable: true),
                    appUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_savedPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_savedPosts_AspNetUsers_appUserId",
                        column: x => x.appUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_savedPosts_questions_questionId",
                        column: x => x.questionId,
                        principalTable: "questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_savedPosts_appUserId",
                table: "savedPosts",
                column: "appUserId");

            migrationBuilder.CreateIndex(
                name: "IX_savedPosts_questionId",
                table: "savedPosts",
                column: "questionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "savedPosts");
        }
    }
}
