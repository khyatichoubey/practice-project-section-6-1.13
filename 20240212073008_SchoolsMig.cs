using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practice_project_6_1._13.Migrations
{
    public partial class SchoolsMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "uischooldb",
                columns: table => new
                {
                    RollNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    marks = table.Column<int>(type: "int", nullable: false),
                    Student = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uischooldb", x => x.RollNo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "uischooldb");
        }
    }
}
