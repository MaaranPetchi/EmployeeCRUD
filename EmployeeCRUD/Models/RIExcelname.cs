using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Models
{
    public class RIExcelname
    {
        [Key]
        public int id { get; set; }
        public string OrganizationName { get; set; } = "";
        public string Period { get; set; } = "";
        public int Period_Year { get; set; }
        public string Order_Date { get; set; } 
        public string Agreement_Name { get; set; } = "";
        public string Publisher { get; set; } = "";
        public string Company_Name { get; set; } = "";
        public string Tenant_Primary_Domain { get; set; } = "";
        public string Tenant_Reference { get; set; } = "";
        public string Publisher_Customer_ID { get; set; } = "";
        public string Publisher_Subscription_ID { get; set; } = "";
        public string Publisher_Subscription_Name { get; set; } = "";
        public string Subscription_Department_Tag { get; set; } = "";
        public string Subscription_Cost_Center_Tag { get; set; } = "";
        public string Subscription_Project_Tag { get; set; } = "";
        public string Subscription_Owner_Tag { get; set; } = "";
        public string Subscription_Custom_Tag { get; set; } = "";
        public string Product_ID { get; set; } = "";
        public string SKU_ID { get; set; } = "";
        public string SKU_Name { get; set; } = "";
        public string Product_Name { get; set; } = "";
        public string Charge_Type_ID { get; set; } = "";
        public string Charge_Type { get; set; } = "";
        public string Currency { get; set; } = "";
        public string Unit { get; set; } = "";
        public string Unit_Price { get; set; } = "";
        public string Quantity { get; set; } = "";
        public string Amount { get; set; } = "";
        public string Reservation_ID { get; set; } = "";
        public string Billing_Frequency { get; set; } = "";
        public string Term_and_Billing_Cycle { get; set; } = "";
        public string Charge_Start_Date { get; set; } = "";
        public string Charge_End_Date { get; set; } = "";
        public string CustomerCountry { get; set; } = "";
        public string CreditReasonCode { get; set; } = "";
        public string SubscriptionStartDate { get; set; } = "";
        public string SubscriptionEndDate { get; set; } = "";
        public string ReferenceID { get; set; } = "";
        public string ProductQualifiers { get; set; } = "";
        public string PublisherName { get; set; } = "";
        public string PublisherId { get; set; } = "";

    }
}
