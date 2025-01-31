using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace student_registration.Migrations
{
    /// <inheritdoc />
    public partial class OnetoManyRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "LocationId",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Students");
        }
    }
}
