using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace student_registration.Migrations
{
    /// <inheritdoc />
    public partial class OnetoOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TechnologyId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technologies_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "IdNo", "Name", "Phone", "Registration", "School", "TechnologyId" },
                values: new object[] { 3, 55555555, "Andrew Kimwetich", 765383853, "BIT/041/21", "Science", 1 });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name", "StudentId" },
                values: new object[] { 1, ".NET Developer", 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_StudentId",
                table: "Technologies",
                column: "StudentId",
                unique: true,
                filter: "[StudentId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Technologies");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "TechnologyId",
                table: "Students");
        }
    }
}
