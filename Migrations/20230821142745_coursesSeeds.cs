using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database_class.Migrations
{
    /// <inheritdoc />
    public partial class coursesSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseDescription", "CourseName" },
                values: new object[] { 1, "C# is a programming language", "C#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
