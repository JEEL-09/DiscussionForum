using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscussionForumCore.Migrations
{
    public partial class Answer1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "appUserId",
                table: "answers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_answers_appUserId",
                table: "answers",
                column: "appUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_answers_AspNetUsers_appUserId",
                table: "answers",
                column: "appUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_answers_AspNetUsers_appUserId",
                table: "answers");

            migrationBuilder.DropIndex(
                name: "IX_answers_appUserId",
                table: "answers");

            migrationBuilder.DropColumn(
                name: "appUserId",
                table: "answers");
        }
    }
}
