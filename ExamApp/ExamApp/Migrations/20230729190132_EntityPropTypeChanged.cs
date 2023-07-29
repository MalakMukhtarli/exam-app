using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamApp.Migrations
{
    public partial class EntityPropTypeChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonGradeTeachers_LessonGrade_LessonGradeId",
                table: "LessonGradeTeachers");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonGradeTeachers_Teachers_TeacherId",
                table: "LessonGradeTeachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LessonGradeTeachers",
                table: "LessonGradeTeachers");

            migrationBuilder.RenameTable(
                name: "LessonGradeTeachers",
                newName: "LessonGradeTeacher");

            migrationBuilder.RenameIndex(
                name: "IX_LessonGradeTeachers_TeacherId",
                table: "LessonGradeTeacher",
                newName: "IX_LessonGradeTeacher_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_LessonGradeTeachers_LessonGradeId",
                table: "LessonGradeTeacher",
                newName: "IX_LessonGradeTeacher_LessonGradeId");

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "Lessons",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LessonGradeTeacher",
                table: "LessonGradeTeacher",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGradeTeacher_LessonGrade_LessonGradeId",
                table: "LessonGradeTeacher",
                column: "LessonGradeId",
                principalTable: "LessonGrade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGradeTeacher_Teachers_TeacherId",
                table: "LessonGradeTeacher",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LessonGradeTeacher_LessonGrade_LessonGradeId",
                table: "LessonGradeTeacher");

            migrationBuilder.DropForeignKey(
                name: "FK_LessonGradeTeacher_Teachers_TeacherId",
                table: "LessonGradeTeacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LessonGradeTeacher",
                table: "LessonGradeTeacher");

            migrationBuilder.RenameTable(
                name: "LessonGradeTeacher",
                newName: "LessonGradeTeachers");

            migrationBuilder.RenameIndex(
                name: "IX_LessonGradeTeacher_TeacherId",
                table: "LessonGradeTeachers",
                newName: "IX_LessonGradeTeachers_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_LessonGradeTeacher_LessonGradeId",
                table: "LessonGradeTeachers",
                newName: "IX_LessonGradeTeachers_LessonGradeId");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "Lessons",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LessonGradeTeachers",
                table: "LessonGradeTeachers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGradeTeachers_LessonGrade_LessonGradeId",
                table: "LessonGradeTeachers",
                column: "LessonGradeId",
                principalTable: "LessonGrade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LessonGradeTeachers_Teachers_TeacherId",
                table: "LessonGradeTeachers",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
