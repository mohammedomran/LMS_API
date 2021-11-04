using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApiJWT.Migrations
{
    public partial class initial21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonItems_Lessons_LessonId",
                table: "LessonItems");

            migrationBuilder.AlterColumn<int>(
                name: "LessonId",
                table: "LessonItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonItems_Lessons_LessonId",
                table: "LessonItems",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonItems_Lessons_LessonId",
                table: "LessonItems");

            migrationBuilder.AlterColumn<int>(
                name: "LessonId",
                table: "LessonItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonItems_Lessons_LessonId",
                table: "LessonItems",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
