using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    public partial class tablechanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.CreateTable(
                name: "UsersConsumptionReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RESOURCEGROUP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Environment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SplitPercentage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SplitGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Consumed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersConsumptionReport", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersConsumptionReport");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consumed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Environment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RESOURCEGROUP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordCreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SplitGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SplitPercentage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TYPE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Consumption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportDetails = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.CountryID);
                });
        }
    }
}
