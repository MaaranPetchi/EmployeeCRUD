using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    public partial class done : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Subscription_ID",
                table: "Employees",
                newName: "SubscriptionID");

            migrationBuilder.RenameColumn(
                name: "RowCreatedDate",
                table: "Employees",
                newName: "RecordCreatedOn");

            migrationBuilder.RenameColumn(
                name: "Resource_Location",
                table: "Employees",
                newName: "SplitPercentage");

            migrationBuilder.RenameColumn(
                name: "Resource_Group",
                table: "Employees",
                newName: "SplitCategory2");

            migrationBuilder.RenameColumn(
                name: "Meter_ID",
                table: "Employees",
                newName: "ResourceLocation");

            migrationBuilder.RenameColumn(
                name: "Cost",
                table: "Employees",
                newName: "ResourceInstance");

            migrationBuilder.AddColumn<string>(
                name: "CostPrice",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Meter",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MeterID",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResourceGroup",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CostPrice",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Meter",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MeterID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ResourceGroup",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "SubscriptionID",
                table: "Employees",
                newName: "Subscription_ID");

            migrationBuilder.RenameColumn(
                name: "SplitPercentage",
                table: "Employees",
                newName: "Resource_Location");

            migrationBuilder.RenameColumn(
                name: "SplitCategory2",
                table: "Employees",
                newName: "Resource_Group");

            migrationBuilder.RenameColumn(
                name: "ResourceLocation",
                table: "Employees",
                newName: "Meter_ID");

            migrationBuilder.RenameColumn(
                name: "ResourceInstance",
                table: "Employees",
                newName: "Cost");

            migrationBuilder.RenameColumn(
                name: "RecordCreatedOn",
                table: "Employees",
                newName: "RowCreatedDate");
        }
    }
}
