using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    public partial class clientdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CloudAccount",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CostPrice",
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
                name: "Meter",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MeterID",
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
                name: "ResourceInstance",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ResourceLocation",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SkuName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Subcategory",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "ResourceGroup",
                table: "Employees",
                newName: "RESOURCEGROUP");

            migrationBuilder.RenameColumn(
                name: "UsageDate",
                table: "Employees",
                newName: "TYPE");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SubscriptionID",
                table: "Employees",
                newName: "Environment");

            migrationBuilder.RenameColumn(
                name: "Subscription",
                table: "Employees",
                newName: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RESOURCEGROUP",
                table: "Employees",
                newName: "ResourceGroup");

            migrationBuilder.RenameColumn(
                name: "TYPE",
                table: "Employees",
                newName: "UsageDate");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "Environment",
                table: "Employees",
                newName: "SubscriptionID");

            migrationBuilder.RenameColumn(
                name: "Customer",
                table: "Employees",
                newName: "Subscription");

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
                name: "CostPrice",
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
                name: "ResourceInstance",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ResourceLocation",
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

            migrationBuilder.AddColumn<string>(
                name: "Subcategory",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
