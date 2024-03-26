using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentMarkProject.Web.Migrations
{
    /// <inheritdoc />
    public partial class addingNewColumnToTeacherEnrollmentmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TeacherEnrollments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "TeacherEnrollments");
        }
    }
}
