using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    public partial class UserDataChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersConsumptionReport",
                table: "UsersConsumptionReport");

            migrationBuilder.RenameTable(
                name: "UsersConsumptionReport",
                newName: "UsersConsumptionData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersConsumptionData",
                table: "UsersConsumptionData",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserConsumptionDataFileUpload",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filepath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserConsumptionDataFileUpload", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserConsumptionDataFileUpload");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsersConsumptionData",
                table: "UsersConsumptionData");

            migrationBuilder.RenameTable(
                name: "UsersConsumptionData",
                newName: "UsersConsumptionReport");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsersConsumptionReport",
                table: "UsersConsumptionReport",
                column: "Id");
        }
    }
}
