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
    public static class ReadNonRIExcel
    {

        public static List<NonRIExcelname> ReadNonRIExcelFile(System.IO.Stream memoryStream, DateTime dt, ref string error)
        {
            var NonRiBillingList = new List<NonRIExcelname>();
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
                        var nonriexcelupload = new NonRIExcelname();

                        foreach (IXLCell cell in row.Cells(readRange))
                        {
                            var value = cell.Value.ToString();

                            if (columnId == 1)
                            {
                                nonriexcelupload.OrganizationName = value;
                            }
                            else if (columnId == 2)
                            {
                                nonriexcelupload.Period = value;

                            }
                            else if (columnId == 3)
                            {
                                nonriexcelupload.Period_Year = Convert.ToInt32(value);

                            }
                            else if (columnId == 4)
                            {
                                nonriexcelupload.Order_Date = value;

                            }
                            else if (columnId == 5)
                            {
                                nonriexcelupload.Agreement_Name = value;

                            }
                            else if (columnId == 6)
                            {
                                nonriexcelupload.Publisher = value;

                            }
                            else if (columnId == 7)
                            {
                                nonriexcelupload.Company_Name = value;

                            }
                            else if (columnId == 8)
                            {
                                nonriexcelupload.Tenant_Primary_Domain = value;

                            }
                            else if (columnId == 9)
                            {
                                nonriexcelupload.Tenant_Reference = value;

                            }
                            else if (columnId == 10)
                            {
                                nonriexcelupload.Publisher_Customer_ID = value;

                            }
                            else if (columnId == 11)
                            {
                                nonriexcelupload.Publisher_Subscription_ID = value;

                            }
                            else if (columnId == 12)
                            {
                                nonriexcelupload.Publisher_Subscription_Name = value;

                            }
                            else if (columnId == 13)
                            {
                                nonriexcelupload.Subscription_Department_Tag = value;

                            }
                            else if (columnId == 14)
                            {
                                nonriexcelupload.Subscription_Cost_Center_Tag = value;

                            }
                            else if (columnId == 15)
                            {
                                nonriexcelupload.Subscription_Project_Tag = value;

                            }
                            else if (columnId == 16)
                            {
                                nonriexcelupload.Subscription_Owner_Tag = value;

                            }
                            else if (columnId == 17)
                            {
                                nonriexcelupload.Subscription_Custom_Tag = value;

                            }
                            else if (columnId == 18)
                            {
                                nonriexcelupload.Product_ID = value;

                            }
                            else if (columnId == 19)
                            {
                                nonriexcelupload.SKU_ID = value;

                            }
                            else if (columnId == 20)
                            {
                                nonriexcelupload.SKU_Name = value;

                            }
                            else if (columnId == 21)
                            {
                                nonriexcelupload.Product_Name = value;

                            }
                            else if (columnId == 22)
                            {
                                nonriexcelupload.Charge_Type_ID = value;

                            }
                            else if (columnId == 23)
                            {
                                nonriexcelupload.Charge_Type = value;

                            }
                            else if (columnId == 24)
                            {
                                nonriexcelupload.Currency = value;

                            }
                            else if (columnId == 25)
                            {
                                nonriexcelupload.Unit = value;

                            }
                            else if (columnId == 26)
                            {
                                nonriexcelupload.Unit_Price = value;

                            }
                            else if (columnId == 27)
                            {
                                nonriexcelupload.Quantity = value;

                            }
                            else if (columnId == 28)
                            {
                                nonriexcelupload.Amount = value;

                            }
                            else if (columnId == 29)
                            {
                                nonriexcelupload.Reservation_ID = value;

                            }
                            else if (columnId == 30)
                            {
                                nonriexcelupload.Billing_Frequency = value;

                            }
                            else if (columnId == 31)
                            {
                                nonriexcelupload.Term_and_Billing_Cycle = value;

                            }
                            else if (columnId == 32)
                            {
                                nonriexcelupload.Charge_Start_Date = value;

                            }
                            else if (columnId == 33)
                            {
                                nonriexcelupload.Charge_End_Date = value;

                            }
                            else if (columnId == 34)
                            {
                                nonriexcelupload.CustomerCountry = value;

                            }
                            else if (columnId == 35)
                            {
                                nonriexcelupload.CreditReasonCode = value;

                            }
                            else if (columnId == 36)
                            {
                                nonriexcelupload.SubscriptionStartDate = value;

                            }
                            else if (columnId == 37)
                            {
                                nonriexcelupload.SubscriptionEndDate = value;

                            }
                            else if (columnId == 38)
                            {
                                nonriexcelupload.ReferenceID = value;

                            }
                            else if (columnId == 39)
                            {
                                nonriexcelupload.ProductQualifiers = value;

                            }
                            else if (columnId == 40)
                            {
                                nonriexcelupload.PublisherName = value;

                            }
                            else if (columnId == 41)
                            {
                                nonriexcelupload.PublisherId = value;

                            }
                            columnId++;
                        }

                        NonRiBillingList.Add(nonriexcelupload);
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

            return NonRiBillingList;
        }
    }
}
