using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    public partial class ExcelFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsageDetails",
                table: "Employees",
                newName: "Sub_Category");

            migrationBuilder.RenameColumn(
                name: "ReportDetails",
                table: "Employees",
                newName: "Static_Percentage");

            migrationBuilder.RenameColumn(
                name: "PriceList",
                table: "Employees",
                newName: "Split_Percentage");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "Split_Group");

            migrationBuilder.RenameColumn(
                name: "Designation",
                table: "Employees",
                newName: "Resource_Name");

            migrationBuilder.RenameColumn(
                name: "Budget",
                table: "Employees",
                newName: "Resource_Group");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Employees",
                newName: "Company_Name");

            migrationBuilder.CreateTable(
                name: "NonRdFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filepath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonRdFile", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NonRdFile");

            migrationBuilder.RenameColumn(
                name: "Sub_Category",
                table: "Employees",
                newName: "UsageDetails");

            migrationBuilder.RenameColumn(
                name: "Static_Percentage",
                table: "Employees",
                newName: "ReportDetails");

            migrationBuilder.RenameColumn(
                name: "Split_Percentage",
                table: "Employees",
                newName: "PriceList");

            migrationBuilder.RenameColumn(
                name: "Split_Group",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Resource_Name",
                table: "Employees",
                newName: "Designation");

            migrationBuilder.RenameColumn(
                name: "Resource_Group",
                table: "Employees",
                newName: "Budget");

            migrationBuilder.RenameColumn(
                name: "Company_Name",
                table: "Employees",
                newName: "Address");
        }
    }
}
