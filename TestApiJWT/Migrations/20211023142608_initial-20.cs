using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApiJWT.Migrations
{
    public partial class initial20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonItems_Levels_LevelId",
                table: "LessonItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Levels_LevelId",
                table: "Lessons");

            migrationBuilder.DropIndex(
                name: "IX_LessonItems_LevelId",
                table: "LessonItems");

            migrationBuilder.DropColumn(
                name: "LevelId",
                table: "LessonItems");

            migrationBuilder.AlterColumn<int>(
                name: "LevelId",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Levels_LevelId",
                table: "Lessons",
                column: "LevelId",
                principalTable: "Levels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Levels_LevelId",
                table: "Lessons");

            migrationBuilder.AlterColumn<int>(
                name: "LevelId",
                table: "Lessons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "LevelId",
                table: "LessonItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LessonItems_LevelId",
                table: "LessonItems",
                column: "LevelId");

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
        }
    }
}
