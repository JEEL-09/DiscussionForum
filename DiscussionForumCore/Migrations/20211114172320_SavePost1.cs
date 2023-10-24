using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscussionForumCore.Migrations
{
    public partial class SavePost1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_savedPosts_questions_questionId",
                table: "savedPosts");

            migrationBuilder.DropColumn(
                name: "quetionId",
                table: "savedPosts");

            migrationBuilder.AlterColumn<int>(
                name: "questionId",
                table: "savedPosts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_savedPosts_questions_questionId",
                table: "savedPosts",
                column: "questionId",
                principalTable: "questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_savedPosts_questions_questionId",
                table: "savedPosts");

            migrationBuilder.AlterColumn<int>(
                name: "questionId",
                table: "savedPosts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "quetionId",
                table: "savedPosts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_savedPosts_questions_questionId",
                table: "savedPosts",
                column: "questionId",
                principalTable: "questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
