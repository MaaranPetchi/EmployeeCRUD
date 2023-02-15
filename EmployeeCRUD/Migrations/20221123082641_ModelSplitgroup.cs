using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    public partial class ModelSplitgroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SplitCategory2",
                table: "Employees",
                newName: "SplitGroup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SplitGroup",
                table: "Employees",
                newName: "SplitCategory2");
        }
    }
}
