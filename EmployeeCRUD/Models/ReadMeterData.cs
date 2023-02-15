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
    public static class ReadMeterData
    {

        public static List<MeteringData> ReadMeterDataFile(System.IO.Stream memoryStream, DateTime dt, ref string error)
        {
            var MeterBillingList = new List<MeteringData>();
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
                string readRange = "1:83";
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
                        var meterexcelupload = new MeteringData();

                        foreach (IXLCell cell in row.Cells(readRange))
                        {
                            var value = cell.Value.ToString();

                            if (columnId == 1)
                            {
                                meterexcelupload.OrganizationName = value;
                            }
                            else if (columnId == 2)
                            {
                                meterexcelupload.Period = value;

                            }
                            else if (columnId == 3)
                            {
                                meterexcelupload.AgreementName = value; 

                            }
                            else if (columnId == 4)
                            {
                                meterexcelupload.Publisher = value;

                            }
                            else if (columnId == 5)
                            {
                                meterexcelupload.CompanyName = value;

                            }
                            else if (columnId == 6)
                            {
                                meterexcelupload.TenantPrimaryDomain = value;

                            }
                            else if (columnId == 7)
                            {
                                meterexcelupload.TenantReference = value;

                            }
                            else if (columnId == 8)
                            {
                                meterexcelupload.PublisherCustomerID = value;

                            }
                            else if (columnId == 9)
                            {
                                meterexcelupload.PublisherSubscriptionID = value;

                            }
                            else if (columnId == 10)
                            {
                                meterexcelupload.PublisherSubscriptionName = value;

                            }
                            else if (columnId == 11)
                            {
                                meterexcelupload.ProductID = value;

                            }
                            else if (columnId == 12)
                            {
                                meterexcelupload.Category = value;

                            }
                            else if (columnId == 13)
                            {
                                meterexcelupload.Subcategory = value;

                            }
                            else if (columnId == 14)
                            {
                                meterexcelupload.MeterName = value;

                            }
                            else if (columnId == 15)
                            {
                                meterexcelupload.UsageStartDate = value;

                            }
                            else if (columnId == 16)
                            {
                                meterexcelupload.UsageEndDate = value;

                            }
                            else if (columnId == 17)
                            {
                                meterexcelupload.UnitPrice = value;

                            }
                            else if (columnId == 18)
                            {
                                meterexcelupload.Quantity = value;

                            }
                            else if (columnId == 19)
                            {
                                meterexcelupload.Unit = value;

                            }
                            else if (columnId == 20)
                            {
                                meterexcelupload.Amount = value;

                            }
                            else if (columnId == 21)
                            {
                                meterexcelupload.Currency = value;

                            }
                            else if (columnId == 22)
                            {
                                meterexcelupload.ResourceGroupName = value;

                            }
                            else if (columnId == 23)
                            {
                                meterexcelupload.ResourceName = value;

                            }
                            else if (columnId == 24)
                            {
                                meterexcelupload.Location = value;

                            }
                            else if (columnId == 25)
                            {
                                meterexcelupload.ExtendedInformation = value;

                            }
                            else if (columnId == 26)
                            {
                                meterexcelupload.organizationsnames = value;

                            }
                            else if (columnId == 27)
                            {
                                meterexcelupload.aksAPIServerIPAddress = value;

                            }
                            else if (columnId == 28)
                            {
                                meterexcelupload.aksmanagedclustername = value;

                            }
                            else if (columnId == 29)
                            {
                                meterexcelupload.aksmanagedclusterrg = value;

                            }
                            else if (columnId == 30)
                            {
                                meterexcelupload.aksmanagedcreateOperationID = value;

                            }
                            else if (columnId == 31)
                            {
                                meterexcelupload.aksmanagedcreationSource = value;

                            }
                            else if (columnId == 32)
                            {
                                meterexcelupload.aksmanagedkubeletIdentityClientID = value;

                            }
                            else if (columnId == 33)
                            {
                                meterexcelupload.aksmanagedorchestrator = value;

                            }
                            else if (columnId == 34)
                            {
                                meterexcelupload.aksmanagedorchestratorKubernetes = value;

                            }
                            else if (columnId == 35)
                            {
                                meterexcelupload.aksmanagedpoolName = value;

                            }
                            else if (columnId == 36)
                            {
                                meterexcelupload.aksmanagedresourceNameSuffix = value;

                            }
                            else if (columnId == 37)
                            {
                                meterexcelupload.aksmanagedtype = value;

                            }
                            else if (columnId == 38)
                            {
                                meterexcelupload.Atlas = value;

                            }
                            else if (columnId == 39)
                            {
                                meterexcelupload.AtlasOil = value;

                            }
                            else if (columnId == 40)
                            {
                                meterexcelupload.atlasoils = value;

                            }
                            else if (columnId == 41)
                            {
                                meterexcelupload.clusterName = value;

                            }
                            else if (columnId == 42)
                            {
                                meterexcelupload.CMA = value;

                            }
                            else if (columnId == 43)
                            {
                                meterexcelupload.CMACGMSTG = value;

                            }
                            else if (columnId == 44)
                            {
                                meterexcelupload.CMAQC = value;

                            }
                            else if (columnId == 45)
                            {
                                meterexcelupload.CMAShiptech10 = value;

                            }
                            else if (columnId == 46)
                            {
                                meterexcelupload.DemoMachineforAnanda = value;

                            }
                            else if (columnId == 47)
                            {
                                meterexcelupload.displayName = value;

                            }
                            else if (columnId == 48)
                            {
                                meterexcelupload.environment = value;

                            }
                            else if (columnId == 49)
                            {
                                meterexcelupload.FRCSHPDCMASHAP = value;

                            }
                            else if (columnId == 50)
                            {
                                meterexcelupload.FRSPD = value;

                            }
                            
                            else if (columnId == 51)
                            {
                                meterexcelupload.hapag = value;

                            }
                            else if (columnId == 52)
                            {
                                meterexcelupload.Hartree = value;

                            }
                            else if (columnId == 53)
                            {
                                meterexcelupload.Inatech = value;

                            }
                            else if (columnId == 54)
                            {
                                meterexcelupload.inatechcustomers = value;

                            }
                            else if (columnId == 55)
                            {
                                meterexcelupload.k8sazureclustername = value;

                            }
                            else if (columnId == 56)
                            {
                                meterexcelupload.k8sazureservice = value;

                            }
                            else if (columnId == 57)
                            {
                                meterexcelupload.msresourceusage = value;

                            }
                            else if (columnId == 58)
                            {
                                meterexcelupload.NonProdResource = value;

                            }
                            else if (columnId == 59)
                            {
                                meterexcelupload.PDI = value;

                            }
                            else if (columnId == 60)
                            {
                                meterexcelupload.PDIUAT = value;

                            }
                            else if (columnId == 61)
                            {
                                meterexcelupload.PMG = value;

                            }
                            else if (columnId == 62)
                            {
                                meterexcelupload.Prf = value;

                            }
                            else if (columnId == 63)
                            {
                                meterexcelupload.Refuel = value;

                            }
                            else if (columnId == 64)
                            {
                                meterexcelupload.resourceType = value;

                            }
                            else if (columnId == 65)
                            {
                                meterexcelupload.SHAPI = value;

                            }
                            else if (columnId == 66)
                            {
                                meterexcelupload.Shiptech10 = value;

                            }
                            else if (columnId == 67)
                            {
                                meterexcelupload.Shiptechdev = value;

                            }
                            else if (columnId == 68)
                            {
                                meterexcelupload.ShiptechHapag = value;

                            }
                            else if (columnId == 69)
                            {
                                meterexcelupload.SmartTrader = value;

                            }
                            else if (columnId == 70)
                            {
                                meterexcelupload.Storage = value;

                            }
                            else if (columnId == 71)
                            {
                                meterexcelupload.Stroage = value;

                            }
                            else if (columnId == 72)
                            {
                                meterexcelupload.subcustomerlevel = value;

                            }
                            else if (columnId == 73)
                            {
                                meterexcelupload.Techoil = value;

                            }
                            else if (columnId == 74)
                            {
                                meterexcelupload.Techoil_1133 = value;

                            }
                            else if (columnId == 75)
                            {
                                meterexcelupload.TechoilAlchemist = value;

                            }
                            else if (columnId == 76)
                            {
                                meterexcelupload.TechoilInternal = value;

                            }
                            else if (columnId == 77)
                            {
                                meterexcelupload.TechoilMultitenant = value;

                            }
                            else if (columnId == 78)
                            {
                                meterexcelupload.TechoilPDI = value;

                            }
                            else if (columnId == 79)
                            {
                                meterexcelupload.TechoilStaging = value;

                            }
                            else if (columnId == 80)
                            {
                                meterexcelupload.tenant = value;

                            }
                            else if (columnId == 81)
                            {
                                meterexcelupload.TenantManager = value;

                            }
                            else if (columnId == 82)
                            {
                                meterexcelupload.TerfoilBO = value;

                            }
                            else if (columnId == 83)
                            {
                                meterexcelupload.TrefoilBO = value;

                            }
                        
                            columnId++;
                        }

                        MeterBillingList.Add(meterexcelupload);
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

            return MeterBillingList;
        }
    }
}
