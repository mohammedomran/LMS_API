using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApiJWT.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserCourse_Course_CoursesId",
                table: "ApplicationUserCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Lesson_Course_CourseId",
                table: "Lesson");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonItems_Lesson_LessonId",
                table: "LessonItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_StudentId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Course_CourseId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "Lesson",
                newName: "Lessons");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameIndex(
                name: "IX_Review_StudentId",
                table: "Reviews",
                newName: "IX_Reviews_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_CourseId",
                table: "Reviews",
                newName: "IX_Reviews_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Lesson_CourseId",
                table: "Lessons",
                newName: "IX_Lessons_CourseId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsPaid",
                table: "Courses",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserCourse_Courses_CoursesId",
                table: "ApplicationUserCourse",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonItems_Lessons_LessonId",
                table: "LessonItems",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_StudentId",
                table: "Reviews",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Courses_CourseId",
                table: "Reviews",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserCourse_Courses_CoursesId",
                table: "ApplicationUserCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonItems_Lessons_LessonId",
                table: "LessonItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Courses_CourseId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_StudentId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Courses_CourseId",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lessons",
                table: "Lessons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "Lessons",
                newName: "Lesson");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_StudentId",
                table: "Review",
                newName: "IX_Review_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_CourseId",
                table: "Review",
                newName: "IX_Review_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_CourseId",
                table: "Lesson",
                newName: "IX_Lesson_CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "IsPaid",
                table: "Course",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lesson",
                table: "Lesson",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserCourse_Course_CoursesId",
                table: "ApplicationUserCourse",
                column: "CoursesId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lesson_Course_CourseId",
                table: "Lesson",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonItems_Lesson_LessonId",
                table: "LessonItems",
                column: "LessonId",
                principalTable: "Lesson",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_StudentId",
                table: "Review",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Course_CourseId",
                table: "Review",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
