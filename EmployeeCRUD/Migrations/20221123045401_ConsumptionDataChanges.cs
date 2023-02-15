using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    public partial class ConsumptionDataChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sub_Category",
                table: "Employees",
                newName: "UsageDate");

            migrationBuilder.RenameColumn(
                name: "Static_Percentage",
                table: "Employees",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "Split_Percentage",
                table: "Employees",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "Split_Group",
                table: "Employees",
                newName: "Subscription_ID");

            migrationBuilder.RenameColumn(
                name: "Resource_Name",
                table: "Employees",
                newName: "Subscription");

            migrationBuilder.RenameColumn(
                name: "RecordCreatedOn",
                table: "Employees",
                newName: "RowCreatedDate");

            migrationBuilder.RenameColumn(
                name: "Company_Name",
                table: "Employees",
                newName: "Subcategory");

            migrationBuilder.AddColumn<string>(
                name: "filepath",
                table: "RiBillingfile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CloudAccount",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Consumed",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cost",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntitlementDescription",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EntitlementId",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Meter_ID",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PayerAccountID",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Resource_Location",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SkuName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "filepath",
                table: "RiBillingfile");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CloudAccount",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Consumed",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EntitlementDescription",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EntitlementId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Meter_ID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PayerAccountID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Resource_Location",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SkuName",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "UsageDate",
                table: "Employees",
                newName: "Sub_Category");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Employees",
                newName: "Static_Percentage");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "Employees",
                newName: "Split_Percentage");

            migrationBuilder.RenameColumn(
                name: "Subscription_ID",
                table: "Employees",
                newName: "Split_Group");

            migrationBuilder.RenameColumn(
                name: "Subscription",
                table: "Employees",
                newName: "Resource_Name");

            migrationBuilder.RenameColumn(
                name: "Subcategory",
                table: "Employees",
                newName: "Company_Name");

            migrationBuilder.RenameColumn(
                name: "RowCreatedDate",
                table: "Employees",
                newName: "RecordCreatedOn");
        }
    }
}
