using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApiJWT.Migrations
{
    public partial class initial13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "NumberOfLevels",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "Lessons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "LessonItems",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Level",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Level", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Level_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_LevelId",
                table: "Lessons",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonItems_LevelId",
                table: "LessonItems",
                column: "LevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Level_CourseId",
                table: "Level",
                column: "CourseId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonItems_Level_LevelId",
                table: "LessonItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Level_LevelId",
                table: "Lessons");

            migrationBuilder.DropTable(
                name: "Level");

            migrationBuilder.DropIndex(
                name: "IX_Lessons_LevelId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_LessonItems_LevelId",
                table: "LessonItems");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "LessonItems");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "NumberOfLevels",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_CourseId",
                table: "Lessons",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
