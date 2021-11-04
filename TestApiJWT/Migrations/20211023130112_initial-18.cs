using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApiJWT.Migrations
{
    public partial class initial18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Levels_Courses_CourseId",
                table: "Levels");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Levels",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "FK_Levels_Courses_CourseId",
                table: "Levels");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Levels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Levels_Courses_CourseId",
                table: "Levels",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
