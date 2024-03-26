using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentMarkProject.Web.Migrations
{
    /// <inheritdoc />
    public partial class removeColumnToTeacherEnrollmentmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "TeacherEnrollments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TeacherEnrollments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
