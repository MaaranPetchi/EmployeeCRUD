using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    public partial class Riandnonri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NonRdFile");

            migrationBuilder.CreateTable(
                name: "NonRiBillingfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonRiBillingfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NonRIExcelUploads",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period_Year = table.Column<int>(type: "int", nullable: false),
                    Order_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agreement_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tenant_Primary_Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tenant_Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher_Customer_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher_Subscription_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher_Subscription_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription_Department_Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription_Cost_Center_Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription_Project_Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription_Owner_Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription_Custom_Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Charge_Type_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Charge_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit_Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reservation_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Billing_Frequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Term_and_Billing_Cycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Charge_Start_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Charge_End_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditReasonCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionStartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionEndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductQualifiers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonRIExcelUploads", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RiBillingfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiBillingfile", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RIExcelUploads",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period_Year = table.Column<int>(type: "int", nullable: false),
                    Order_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agreement_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tenant_Primary_Domain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tenant_Reference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher_Customer_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher_Subscription_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher_Subscription_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription_Department_Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription_Cost_Center_Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription_Project_Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription_Owner_Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subscription_Custom_Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SKU_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Charge_Type_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Charge_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit_Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reservation_ID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Billing_Frequency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Term_and_Billing_Cycle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Charge_Start_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Charge_End_Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditReasonCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionStartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionEndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductQualifiers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RIExcelUploads", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NonRiBillingfile");

            migrationBuilder.DropTable(
                name: "NonRIExcelUploads");

            migrationBuilder.DropTable(
                name: "RiBillingfile");

            migrationBuilder.DropTable(
                name: "RIExcelUploads");

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
    }
}
