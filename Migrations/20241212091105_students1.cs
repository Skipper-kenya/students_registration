using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace student_registration.Migrations
{
    /// <inheritdoc />
    public partial class students1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNo",
                table: "Students",
                newName: "Phone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "Students",
                newName: "PhoneNo");
        }
    }
}
