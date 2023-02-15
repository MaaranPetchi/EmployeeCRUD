using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ClosedXML;
using System.Web;

using ClosedXML.Excel;

namespace EmployeeCRUD.Models
{
    public static class ReadRIExcel
    {

        public static List<RIExcelname> ReadRIExcelFile(System.IO.Stream memoryStream, DateTime dt, ref string error)
        {
            var RiBillingList = new List<RIExcelname>();
            DataTable tbl = new DataTable();
            //Checking file content length and Extension must be .xlsx  
            //if (file != null && file.ContentLength > 0 && System.IO.Path.GetExtension(file.FileName).ToLower() == ".xlsx")
            //{




            //Started reading the Excel file.  
            using (XLWorkbook workbook = new XLWorkbook(memoryStream))
            {
                IXLWorksheet worksheet = workbook.Worksheet(1);
                bool FirstRow = true;
                //Range for reading the cells based on the last cell used.  
                string readRange = "1:41";
                foreach (IXLRow row in worksheet.RowsUsed())
                {
                    //If Reading the First Row (used) then add them as column name  
                    if (FirstRow)
                    {
                        //var LastCellNumber = row.LastCellUsed().Address.ColumnNumber;
                        ////Checking the Last cellused for column generation in datatable  

                        //if (LastCellNumber == 5)
                        //{

                        //    var attendance=new AttendenceModel();
                        //    tbl.Columns.Add("EmpCde");
                        //    tbl.Columns.Add("Name");
                        //    tbl.Columns.Add("Devision");
                        //    tbl.Columns.Add("Shift");
                        //    tbl.Columns.Add("AttendanceStatus");

                        //}
                        //readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                        //foreach (IXLCell cell in row.Cells(readRange))
                        //{
                        //    tbl.Columns.Add(cell.Value.ToString());
                        //}
                        FirstRow = false;
                    }
                    else
                    {
                        //Adding a Row in datatable  
                        tbl.Rows.Add();
                        //int cellIndex = 0;
                        //Updating the values of datatable  


                        var columnId = 1;
                        var riexcelupload = new RIExcelname();

                        foreach (IXLCell cell in row.Cells(readRange))
                        {
                            var value = cell.Value.ToString();

                            if (columnId == 1)
                            {
                                riexcelupload.OrganizationName = value; 
                            }
                            else if (columnId == 2)
                            {
                                riexcelupload.Period = value;

                            }
                            else if (columnId == 3)
                            {
                                riexcelupload.Period_Year = Convert.ToInt32(value);

                            }
                            else if (columnId == 4)
                            {
                                riexcelupload.Order_Date = value;

                            }
                            else if (columnId == 5)
                            {
                                riexcelupload.Agreement_Name = value;

                            }
                            else if (columnId == 6)
                            {
                                riexcelupload.Publisher = value;

                            }
                            else if (columnId == 7)
                            {
                                riexcelupload.Company_Name = value;

                            }
                            else if (columnId == 8)
                            {
                                riexcelupload.Tenant_Primary_Domain = value;

                            }
                            else if (columnId == 9)
                            {
                                riexcelupload.Tenant_Reference = value;

                            }
                            else if (columnId == 10)
                            {
                                riexcelupload.Publisher_Customer_ID = value;

                            }
                            else if (columnId == 11)
                            {
                                riexcelupload.Publisher_Subscription_ID = value;

                            }
                            else if (columnId == 12)
                            {
                                riexcelupload.Publisher_Subscription_Name = value;

                            }
                            else if (columnId == 13)
                            {
                                riexcelupload.Subscription_Department_Tag = value;

                            }
                            else if (columnId == 14)
                            {
                                riexcelupload.Subscription_Cost_Center_Tag = value;

                            }
                            else if (columnId == 15)
                            {
                                riexcelupload.Subscription_Project_Tag = value;

                            }
                            else if (columnId == 16)
                            {
                                riexcelupload.Subscription_Owner_Tag = value;

                            }
                            else if (columnId == 17)
                            {
                                riexcelupload.Subscription_Custom_Tag = value;

                            }
                            else if (columnId == 18)
                            {
                                riexcelupload.Product_ID = value;

                            }
                            else if (columnId == 19)
                            {
                                riexcelupload.SKU_ID = value;

                            }
                            else if (columnId == 20)
                            {
                                riexcelupload.SKU_Name = value;

                            }
                            else if (columnId == 21)
                            {
                                riexcelupload.Product_Name = value;

                            }
                            else if (columnId == 22)
                            {
                                riexcelupload.Charge_Type_ID = value;

                            }
                            else if (columnId == 23)
                            {
                                riexcelupload.Charge_Type = value;

                            }
                            else if (columnId == 24)
                            {
                                riexcelupload.Currency = value;

                            }
                            else if (columnId == 25)
                            {
                                riexcelupload.Unit = value;

                            }
                            else if (columnId == 26)
                            {
                                riexcelupload.Unit_Price = value;

                            }
                            else if (columnId == 27)
                            {
                                riexcelupload.Quantity = value;

                            }
                            else if (columnId == 28)
                            {
                                riexcelupload.Amount= value;

                            }
                            else if (columnId == 29)
                            {
                                riexcelupload.Reservation_ID = value;

                            }
                            else if (columnId == 30)
                            {
                                riexcelupload.Billing_Frequency = value;

                            }
                            else if (columnId == 31)
                            {
                                riexcelupload.Term_and_Billing_Cycle = value;

                            }
                            else if (columnId == 32)
                            {
                                riexcelupload.Charge_Start_Date = value;

                            }
                            else if (columnId == 33)
                            {
                                riexcelupload.Charge_End_Date = value;

                            }
                            else if (columnId == 34)
                            {
                                riexcelupload.CustomerCountry = value;

                            }
                            else if (columnId == 35)
                            {
                                riexcelupload.CreditReasonCode = value;

                            }
                            else if (columnId == 36)
                            {
                                riexcelupload.SubscriptionStartDate = value;

                            }
                            else if (columnId == 37)
                            {
                                riexcelupload.SubscriptionEndDate = value;

                            }
                            else if (columnId == 38)
                            {
                                riexcelupload.ReferenceID = value;

                            }
                            else if (columnId == 39)
                            {
                                riexcelupload.ProductQualifiers = value;

                            }
                            else if (columnId == 40)
                            {
                                riexcelupload.PublisherName = value;

                            }
                            else if (columnId == 41)
                            {
                                riexcelupload.PublisherId = value;

                            }
                            columnId++;
                        }

                        RiBillingList.Add(riexcelupload);
                    }
                }
                //If no data in Excel file  
                if (FirstRow)
                {
                    error = "Empty Excel File!";
                }
            }
            //}
            //else
            //{
            //    //If file extension of the uploaded file is different then .xlsx  
            //    error = "Please select file with .xlsx extension!";
            //}
            //SaveAttendace(attendanceList, dt);

            return RiBillingList;
        }
    }
}
