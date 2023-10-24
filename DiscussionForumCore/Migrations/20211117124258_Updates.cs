using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscussionForumCore.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "savedPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePic",
                table: "savedPosts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePic",
                table: "questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "answers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePic",
                table: "answers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "savedPosts");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "savedPosts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "questions");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "questions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "answers");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "answers");
        }
    }
}
