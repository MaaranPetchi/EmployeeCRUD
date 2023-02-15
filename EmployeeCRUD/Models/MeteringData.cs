using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Wordprocessing;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Engineering;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace EmployeeCRUD.Models
{
    public class MeteringData
    {

        [Key]
        public int Id { get; set; }
        public string OrganizationName { get; set; } = "";
public string Period { get; set; } = "";
        public string AgreementName { get; set; } = "";
        public string Publisher { get; set; } = "";
        public string CompanyName { get; set; } = "";
        public string TenantPrimaryDomain { get; set; } = "";
        public string TenantReference { get; set; } = "";
        public string PublisherCustomerID { get; set; } = "";
        public string PublisherSubscriptionID { get; set; } = "";
        public string PublisherSubscriptionName { get; set; } = "";
        public string ProductID { get; set; } = "";
        public string Category { get; set; } = "";
        public string Subcategory { get; set; } = "";
        public string MeterName { get; set; } = "";
        public string UsageStartDate { get; set; } = "";
        public string UsageEndDate { get; set; } = "";
        public string UnitPrice { get; set; } = "";
        public string Quantity { get; set; } = "";
        public string Unit { get; set; } = "";
        public string Amount { get; set; } = "";
        public string Currency { get; set; } = "";
        public string ResourceGroupName { get; set; } = "";
        public string ResourceName { get; set; } = "";
        public string Location { get; set; } = "";
        public string ExtendedInformation { get; set; } = "";
        public string organizationsnames { get; set; } = "";
        public string aksAPIServerIPAddress { get; set; } = "";
        public string aksmanagedclustername {get; set; } = "";
public string aksmanagedclusterrg { get; set; } = "";
public string aksmanagedcreateOperationID{ get; set; } = "";
public string aksmanagedcreationSource{ get; set; } = "";
public string aksmanagedkubeletIdentityClientID{ get; set; } = "";
public string aksmanagedorchestrator{ get; set; } = "";
public string aksmanagedorchestratorKubernetes{ get; set; } = "";
public string aksmanagedpoolName{ get; set; } = "";
public string aksmanagedresourceNameSuffix{ get; set; } = "";
public string aksmanagedtype{ get; set; } = "";
public string Atlas { get; set; } = "";
public string AtlasOil { get; set; } = "";
public string atlasoils { get; set; } = "";
public string clusterName { get; set; } = "";
public string CMA { get; set; } = "";
public string CMACGMSTG { get; set; } = "";
public string CMAQC{ get; set; } = "";
public string CMAShiptech10{ get; set; } = "";
public string DemoMachineforAnanda { get; set; } = "";
public string displayName { get; set; } = "";
public string environment { get; set; } = "";
public string FRSPD{ get; set; } = "";
public string hapag { get; set; } = "";
public string Hartree { get; set; } = "";
public string Inatech { get; set; } = "";
public string inatechcustomers { get; set; } = "";
public string k8sazureclustername{ get; set; } = "";
public string k8sazureservice{ get; set; } = "";
public string msresourceusage{ get; set; } = "";
public string NonProdResource { get; set; } = "";
public string PDI { get; set; } = "";
public string PDIUAT{ get; set; } = "";
public string PMG { get; set; } = "";
public string Prf { get; set; } = "";
public string Refuel { get; set; } = "";
public string resourceType { get; set; } = "";
public string SHAPI { get; set; } = "";
public string Shiptech10 { get; set; } = "";
public string Shiptechdev{ get; set; } = "";
public string ShiptechHapag{ get; set; } = "";
public string SmartTrader{ get; set; } = "";
public string Storage { get; set; } = "";
public string Stroage { get; set; } = "";
public string subcustomerlevel { get; set; } = "";
public string Techoil { get; set; } = "";
public string Techoil_1133{ get; set; } = "";
public string TechoilAlchemist{ get; set; } = "";
public string TechoilInternal{ get; set; } = "";
public string TechoilMultitenant{ get; set; } = "";
public string TechoilPDI{ get; set; } = "";
public string TechoilStaging{ get; set; } = "";
public string tenant { get; set; } = "";
public string TenantManager { get; set; } = "";
public string TerfoilBO{ get; set; } = "";
public string TrefoilBO{ get; set; } = "";

    }
}
