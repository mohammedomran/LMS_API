using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApiJWT.Migrations
{
    public partial class initial14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonItems_Level_LevelId",
                table: "LessonItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Level_LevelId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Level_Courses_CourseId",
                table: "Level");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Level",
                table: "Level");

            migrationBuilder.RenameTable(
                name: "Level",
                newName: "Levels");

            migrationBuilder.RenameIndex(
                name: "IX_Level_CourseId",
                table: "Levels",
                newName: "IX_Levels_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Levels",
                table: "Levels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonItems_Levels_LevelId",
                table: "LessonItems",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Levels_LevelId",
                table: "Lessons",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Levels_Courses_CourseId",
                table: "Levels",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonItems_Levels_LevelId",
                table: "LessonItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Levels_LevelId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Levels_Courses_CourseId",
                table: "Levels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Levels",
                table: "Levels");

            migrationBuilder.RenameTable(
                name: "Levels",
                newName: "Level");

            migrationBuilder.RenameIndex(
                name: "IX_Levels_CourseId",
                table: "Level",
                newName: "IX_Level_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Level",
                table: "Level",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonItems_Level_LevelId",
                table: "LessonItems",
                column: "LevelId",
                principalTable: "Level",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Level_LevelId",
                table: "Lessons",
                column: "LevelId",
                principalTable: "Level",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Level_Courses_CourseId",
                table: "Level",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
