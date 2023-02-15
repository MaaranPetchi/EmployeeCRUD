using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeCRUD.Migrations
{
    public partial class createnewfilepath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "filepath",
                table: "NonRiBillingfile",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "MeterData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgreementName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantPrimaryDomain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherCustomerID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherSubscriptionID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisherSubscriptionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subcategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsageStartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsageEndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtendedInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    organizationsnames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksAPIServerIPAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksmanagedclustername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksmanagedclusterrg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksmanagedcreateOperationID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksmanagedcreationSource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksmanagedkubeletIdentityClientID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksmanagedorchestrator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksmanagedorchestratorKubernetes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksmanagedpoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksmanagedresourceNameSuffix = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    aksmanagedtype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Atlas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtlasOil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    atlasoils = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clusterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMACGMSTG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMAQC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMAShiptech10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DemoMachineforAnanda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    displayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    environment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FRSPD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hapag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hartree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inatech = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    inatechcustomers = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    k8sazureclustername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    k8sazureservice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    msresourceusage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NonProdResource = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PDI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PDIUAT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PMG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Refuel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    resourceType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SHAPI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shiptech10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shiptechdev = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShiptechHapag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SmartTrader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stroage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subcustomerlevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Techoil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Techoil_1133 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechoilAlchemist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechoilInternal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechoilMultitenant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechoilPDI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechoilStaging = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tenant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenantManager = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TerfoilBO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrefoilBO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MeterFileUploads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filepath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterFileUploads", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeterData");

            migrationBuilder.DropTable(
                name: "MeterFileUploads");

            migrationBuilder.DropColumn(
                name: "filepath",
                table: "NonRiBillingfile");
        }
    }
}
