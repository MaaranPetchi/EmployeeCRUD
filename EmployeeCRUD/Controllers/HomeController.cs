using EmployeeCRUD.Data;
using EmployeeCRUD.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Net.Http.Headers;
using System.Data.OleDb;
using OfficeOpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Wordprocessing;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Engineering;
using System.Security.AccessControl;


namespace EmployeeCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IHostEnvironment _environment;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IHostEnvironment environment)
        {
            _logger = logger;
            _context = context;
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ShowingPowerBIList()
        {
            return View();
        }
        public IActionResult Filecontainer()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();

        }


        [HttpPost]
        public IActionResult Login(Login login)
        {
            bool isTrue = _context.Login.Any(s => s.UserName == login.UserName && s.Password == login.Password);
            if (isTrue)
            {
                //     IEnumerable<Claim> tenantClaims = new Claim[]
                //{
                //     new Claim(ClaimTypes.Name,login.UserName) };
                //     ClaimsIdentity identity = new ClaimsIdentity(tenantClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                //     ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);
                //     HttpContext.SignInAsync(claimsPrincipal);
                //     var d = User;
                return RedirectToAction("Filecontainer", "Home");
            }
            else
            {
                return View();
            }


        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(SignUp signUp)
        {
            Login l = new Login();

            if (ModelState.IsValid)
            {
                l.UserName = signUp.UserName;
                l.Password = signUp.Password;
                _context.Login.Add(l);
                _context.SaveChanges();
                return View("Login");
            }
            return View();
        }

        //[HttpGet]
        //public IActionResult AttendanceFileUpload()
        //{
        //    return View();
        //}


        //[HttpPost]
        //public async Task<IActionResult> AttendanceFileUpload(Fileupload fileupload)
        //{


        //    List<Student> attendanceList;

        //    string error = "success";
        //    // && System.IO.Path.GetExtension(fileupload.formFile.Name).ToLower() == ".xlsx"
        //    if (fileupload != null && fileupload.formFile.Length > 0)
        //    {

        //        attendanceList = ReadExcel.ReadExcelFile(fileupload.formFile.OpenReadStream(), DateTime.Now, ref error);

        //        //ReadExcel.ReadExcel.ReadExcelFile(file, DateTime.Now, ref error);
        //        foreach (Student student in attendanceList)
        //        {
        //            Student s = new Student();


        //            s.OrganizationName = student.OrganizationName;
        //            s.ReportDetails = student.ReportDetails;
        //            s.Consumption = student.Consumption;
        //            _context.Students.Add(s);
        //            _context.SaveChanges();
        //            await _context.SaveChangesAsync();
        //            TempData["ResultOk"] = "Data Updated Successfully !";
        //        }


        //        //var attRes = new ReadExcel.Model
        //        //attRes.Result = error;
        //        //attRes.AttendanceList = attendanceList;
        //        return RedirectToAction("AttendanceFileUpload", "Home");
        //        //return attRes;            
        //        //return message.CreateResponse(System.Net.HttpStatusCode.OK);
        //    }
        //    else
        //    {
        //        //var attRes = new ReadExcel.Model.AttendanceResult();
        //        //attRes.Result = "invalidfile";
        //        attendanceList = null;
        //        return Ok(attendanceList);


        //    }

        //}


        [HttpGet]
        public IActionResult RIBillingFileUpload()
        {
            ViewBag.error = null;
            return View();
        }
        //RIExcelFileUpload

        [HttpPost]
        public async Task<IActionResult> RIBillingFileUpload(RIBillingFile rIBillingFile)
        {
            try
            {
                string name = rIBillingFile.formFile.ContentDisposition;
                var index = name.LastIndexOf("=");
                string f = name.Substring(index + 2);

                string fileName = f.Substring(0, f.Length - 1);

                var fileList = _context.RiBillingfile.ToList();
                bool isPresent = false;

                foreach (var file in fileList)
                {
                    if (file.filepath == fileName)
                        isPresent = true;
                }
                // name.EndsWith(.xlsx);

                if (!isPresent) // not present
                {
                    List<RIExcelname> ribillingList;

                    string error = "success";
                    // && System.IO.Path.GetExtension(fileupload.formFile.Name).ToLower() == ".xlsx"
                    if (rIBillingFile != null && rIBillingFile.formFile.Length > 0)
                    {

                        ribillingList = ReadRIExcel.ReadRIExcelFile(rIBillingFile.formFile.OpenReadStream(), DateTime.Now, ref error);

                        //ReadExcel.ReadExcel.ReadExcelFile(file, DateTime.Now, ref error);
                        foreach (RIExcelname riexcelname in ribillingList)
                        {
                            RIExcelname ri = new RIExcelname();


                            ri.OrganizationName = riexcelname.OrganizationName;
                            ri.Period = riexcelname.Period;
                            ri.Period_Year = riexcelname.Period_Year;
                            ri.Order_Date = riexcelname.Order_Date;
                            ri.Agreement_Name = riexcelname.Agreement_Name;
                            ri.Publisher = riexcelname.Publisher;
                            ri.Company_Name = riexcelname.Company_Name;
                            ri.Tenant_Primary_Domain = riexcelname.Tenant_Primary_Domain;
                            ri.Tenant_Reference = riexcelname.Tenant_Reference;
                            ri.Publisher_Customer_ID = riexcelname.Publisher_Customer_ID;
                            ri.Publisher_Subscription_ID = riexcelname.Publisher_Subscription_ID;
                            ri.Publisher_Subscription_Name = riexcelname.Publisher_Subscription_Name;
                            ri.Subscription_Department_Tag = riexcelname.Subscription_Department_Tag;
                            ri.Subscription_Cost_Center_Tag = riexcelname.Subscription_Cost_Center_Tag;
                            ri.Subscription_Project_Tag = riexcelname.Subscription_Project_Tag;
                            ri.Subscription_Owner_Tag = riexcelname.Subscription_Owner_Tag;
                            ri.Subscription_Custom_Tag = riexcelname.Subscription_Custom_Tag;
                            ri.Product_ID = riexcelname.Product_ID;
                            ri.SKU_ID = riexcelname.SKU_ID;
                            ri.SKU_Name = riexcelname.SKU_Name;
                            ri.Product_Name = riexcelname.Product_Name;
                            ri.Charge_Type_ID = riexcelname.Charge_Type_ID;
                            ri.Charge_Type = riexcelname.Charge_Type;
                            ri.Currency = riexcelname.Currency;
                            ri.Unit = riexcelname.Unit;
                            ri.Unit_Price = riexcelname.Unit_Price;
                            ri.Quantity = riexcelname.Quantity;
                            ri.Amount = riexcelname.Amount;
                            ri.Reservation_ID = riexcelname.Reservation_ID;
                            ri.Billing_Frequency = riexcelname.Billing_Frequency;
                            ri.Term_and_Billing_Cycle = riexcelname.Term_and_Billing_Cycle;
                            ri.Charge_Start_Date = riexcelname.Charge_Start_Date;
                            ri.Charge_End_Date = riexcelname.Charge_End_Date;
                            ri.CustomerCountry = riexcelname.CustomerCountry;
                            ri.CreditReasonCode = riexcelname.CreditReasonCode;
                            ri.SubscriptionStartDate = riexcelname.SubscriptionStartDate;
                            ri.SubscriptionEndDate = riexcelname.SubscriptionEndDate;
                            ri.ReferenceID = riexcelname.ReferenceID;
                            ri.ProductQualifiers = riexcelname.ProductQualifiers;
                            ri.PublisherName = riexcelname.PublisherName;
                            ri.PublisherId = riexcelname.PublisherId;



                            _context.RIExcelUploads.Add(ri);
                            _context.SaveChanges();
                            await _context.SaveChangesAsync();

                            RIBillingFile file = new RIBillingFile()
                            {
                                filepath = fileName
                            };
                            _context.RiBillingfile.Add(file);
                            _context.SaveChanges();
                            TempData["ResultOk"] = "Data Updated Successfully !";
                        }


                        //var attRes = new ReadExcel.Model
                        //attRes.Result = error;
                        //attRes.AttendanceList = attendanceList;
                        return RedirectToAction("PageSubmission", "Employee");
                        //return attRes;            
                        //return message.CreateResponse(System.Net.HttpStatusCode.OK);
                    }
                    else
                    {
                        //var attRes = new ReadExcel.Model.AttendanceResult();
                        //attRes.Result = "invalidfile";
                        ribillingList = null;
                        return Ok(ribillingList);


                    }
                }
                else // present
                {
                    ViewBag.error = "*File Already present. Please select the new one";
                    return View("RIBillingFileUpload");
                }
            }
            catch (Exception e)
            {

                ViewBag.error = "*Please choose the valid file";
                return View("RIBillingFileUpload");
            }


        }

        //Upload Nonri excelfile

        [HttpGet]
        public IActionResult NonRIBillingFileUpload()
        {
            return View();
        }

        //Non-RIExcelFileUpload

        [HttpPost]
        public async Task<IActionResult> NonRIBillingFileUpload(NonRiBillingFile nonrIBillingFile)
        {
            try
            {
                string name = nonrIBillingFile.formFile.ContentDisposition;
                var index = name.LastIndexOf("=");
                string f = name.Substring(index + 2);

                string fileName = f.Substring(0, f.Length - 1);

                var fileList = _context.NonRiBillingfile.ToList();
                bool isPresent = false;

                foreach (var file in fileList)
                {
                    if (file.filepath == fileName)
                        isPresent = true;
                }
                if (!isPresent) // not present
                {

                    List<NonRIExcelname> nonribillingList;

                    string error = "success";
                    // && System.IO.Path.GetExtension(fileupload.formFile.Name).ToLower() == ".xlsx"
                    if (nonrIBillingFile != null && nonrIBillingFile.formFile.Length > 0)
                    {

                        nonribillingList = ReadNonRIExcel.ReadNonRIExcelFile(nonrIBillingFile.formFile.OpenReadStream(), DateTime.Now, ref error);

                        //ReadExcel.ReadExcel.ReadExcelFile(file, DateTime.Now, ref error);
                        foreach (NonRIExcelname nonriexcelname in nonribillingList)
                        {
                            NonRIExcelname nonri = new NonRIExcelname();


                            nonri.OrganizationName = nonriexcelname.OrganizationName;
                            nonri.Period = nonriexcelname.Period;
                            nonri.Period_Year = nonriexcelname.Period_Year;
                            nonri.Order_Date = nonriexcelname.Order_Date;
                            nonri.Agreement_Name = nonriexcelname.Agreement_Name;
                            nonri.Publisher = nonriexcelname.Publisher;
                            nonri.Company_Name = nonriexcelname.Company_Name;
                            nonri.Tenant_Primary_Domain = nonriexcelname.Tenant_Primary_Domain;
                            nonri.Tenant_Reference = nonriexcelname.Tenant_Reference;
                            nonri.Publisher_Customer_ID = nonriexcelname.Publisher_Customer_ID;
                            nonri.Publisher_Subscription_ID = nonriexcelname.Publisher_Subscription_ID;
                            nonri.Publisher_Subscription_Name = nonriexcelname.Publisher_Subscription_Name;
                            nonri.Subscription_Department_Tag = nonriexcelname.Subscription_Department_Tag;
                            nonri.Subscription_Cost_Center_Tag = nonriexcelname.Subscription_Cost_Center_Tag;
                            nonri.Subscription_Project_Tag = nonriexcelname.Subscription_Project_Tag;
                            nonri.Subscription_Owner_Tag = nonriexcelname.Subscription_Owner_Tag;
                            nonri.Subscription_Custom_Tag = nonriexcelname.Subscription_Custom_Tag;
                            nonri.Product_ID = nonriexcelname.Product_ID;
                            nonri.SKU_ID = nonriexcelname.SKU_ID;
                            nonri.SKU_Name = nonriexcelname.SKU_Name;
                            nonri.Product_Name = nonriexcelname.Product_Name;
                            nonri.Charge_Type_ID = nonriexcelname.Charge_Type_ID;
                            nonri.Charge_Type = nonriexcelname.Charge_Type;
                            nonri.Currency = nonriexcelname.Currency;
                            nonri.Unit = nonriexcelname.Unit;
                            nonri.Unit_Price = nonriexcelname.Unit_Price;
                            nonri.Quantity = nonriexcelname.Quantity;
                            nonri.Amount = nonriexcelname.Amount;
                            nonri.Reservation_ID = nonriexcelname.Reservation_ID;
                            nonri.Billing_Frequency = nonriexcelname.Billing_Frequency;
                            nonri.Term_and_Billing_Cycle = nonriexcelname.Term_and_Billing_Cycle;
                            nonri.Charge_Start_Date = nonriexcelname.Charge_Start_Date;
                            nonri.Charge_End_Date = nonriexcelname.Charge_End_Date;
                            nonri.CustomerCountry = nonriexcelname.CustomerCountry;
                            nonri.CreditReasonCode = nonriexcelname.CreditReasonCode;
                            nonri.SubscriptionStartDate = nonriexcelname.SubscriptionStartDate;
                            nonri.SubscriptionEndDate = nonriexcelname.SubscriptionEndDate;
                            nonri.ReferenceID = nonriexcelname.ReferenceID;
                            nonri.ProductQualifiers = nonriexcelname.ProductQualifiers;
                            nonri.PublisherName = nonriexcelname.PublisherName;
                            nonri.PublisherId = nonriexcelname.PublisherId;

                            NonRiBillingFile file = new NonRiBillingFile()
                            {
                                filepath = fileName
                            };

                            _context.NonRIExcelUploads.Add(nonri);
                            _context.SaveChanges();
                            await _context.SaveChangesAsync();
                            TempData["ResultOk"] = "Data Updated Successfully !";
                        }


                        //var attRes = new ReadExcel.Model
                        //attRes.Result = error;
                        //attRes.AttendanceList = attendanceList;
                        return RedirectToAction("PageSubmission", "Employee");
                        //return attRes;            
                        //return message.CreateResponse(System.Net.HttpStatusCode.OK);
                    }
                    else
                    {
                        //var attRes = new ReadExcel.Model.AttendanceResult();
                        //attRes.Result = "invalidfile";
                        nonribillingList = null;
                        return Ok(nonribillingList);


                    }
                }
                else // present
                {
                    ViewBag.error = "*File Already present. Please select the new one";
                    return View("NonRIBillingFileUpload");
                }
            }
            catch (Exception e)
            {

                ViewBag.error = "*Please choose the valid file";
                return View("NonRIBillingFileUpload");
            }
        }


        //meteringdata
        [HttpGet]
        public IActionResult MeteringFileUpload()
        {
            return View();
        }
        //RIExcelFileUpload

        [HttpPost]
        public async Task<IActionResult> MeteringFileUpload(MeterFileUpload meterFile)
        {

            List<MeteringData> meterList;

            string error = "success";
            // && System.IO.Path.GetExtension(fileupload.formFile.Name).ToLower() == ".xlsx"
            if (meterFile != null && meterFile.formFile.Length > 0)
            {

                meterList = ReadMeterData.ReadMeterDataFile(meterFile.formFile.OpenReadStream(), DateTime.Now, ref error);

                //ReadExcel.ReadExcel.ReadExcelFile(file, DateTime.Now, ref error);
                foreach (MeteringData meterdata in meterList)
                {
                    MeteringData me = new MeteringData();


                    me.OrganizationName = meterdata.OrganizationName;
                    me.Period = meterdata.Period;
                    me.AgreementName = meterdata.AgreementName;
                    me.Publisher = meterdata.Publisher;
                    me.CompanyName = meterdata.CompanyName;
                    me.TenantPrimaryDomain = meterdata.TenantPrimaryDomain;
                    me.TenantReference = meterdata.TenantReference;
                    me.PublisherCustomerID = meterdata.PublisherCustomerID;
                    me.PublisherSubscriptionID = meterdata.PublisherSubscriptionID;
                    me.PublisherSubscriptionName = meterdata.PublisherSubscriptionName;
                    me.ProductID = meterdata.ProductID;
                    me.Category = meterdata.Category;
                    me.Subcategory = meterdata.Subcategory;
                    me.MeterName = meterdata.MeterName;
                    me.UsageStartDate = meterdata.UsageStartDate;
                    me.UsageEndDate = meterdata.UsageEndDate;
                    me.UnitPrice = meterdata.UnitPrice;
                    me.Quantity = meterdata.Quantity;
                    me.Unit = meterdata.Unit;
                    me.Amount = meterdata.Amount;
                    me.Currency = meterdata.Currency;
                    me.ResourceGroupName = meterdata.ResourceGroupName;
                    me.ResourceName = meterdata.ResourceName;
                    me.Location = meterdata.Location;
                    me.ExtendedInformation = meterdata.ExtendedInformation;
                    me.organizationsnames = meterdata.organizationsnames;
                    me.aksAPIServerIPAddress = meterdata.aksAPIServerIPAddress;
                    me.aksmanagedclustername = meterdata.aksmanagedclustername;
                    me.aksmanagedclusterrg = meterdata.aksmanagedclusterrg;
                    me.aksmanagedcreateOperationID = meterdata.aksmanagedcreateOperationID;
                    me.aksmanagedcreationSource = meterdata.aksmanagedcreationSource;
                    me.aksmanagedkubeletIdentityClientID = meterdata.aksmanagedkubeletIdentityClientID;
                    me.aksmanagedorchestrator = meterdata.aksmanagedorchestrator;
                    me.aksmanagedorchestratorKubernetes = meterdata.aksmanagedorchestratorKubernetes;
                    me.aksmanagedpoolName = meterdata.aksmanagedpoolName;
                    me.aksmanagedresourceNameSuffix = meterdata.aksmanagedresourceNameSuffix;
                    me.aksmanagedtype = meterdata.aksmanagedtype;
                    me.Atlas = meterdata.Atlas;
                    me.AtlasOil = meterdata.AtlasOil;
                    me.atlasoils = meterdata.atlasoils;
                    me.clusterName = meterdata.clusterName;
                    me.CMA = meterdata.CMA;
                    me.CMACGMSTG = meterdata.CMACGMSTG;
                    me.CMAQC = meterdata.CMAQC;
                    me.CMAShiptech10 = meterdata.CMAShiptech10;
                    me.DemoMachineforAnanda = meterdata.DemoMachineforAnanda;
                    me.displayName = meterdata.displayName;
                    me.environment = meterdata.environment;
                    me.FRCSHPDCMASHAP = meterdata.FRCSHPDCMASHAP;
                    me.FRSPD = meterdata.FRSPD;
                    me.hapag = meterdata.hapag;
                    me.Hartree = meterdata.Hartree;
                    me.Inatech = meterdata.Inatech;
                    me.inatechcustomers = meterdata.inatechcustomers;
                    me.k8sazureclustername = meterdata.k8sazureclustername;
                    me.k8sazureservice = meterdata.k8sazureservice;
                    me.msresourceusage = meterdata.msresourceusage;
                    me.NonProdResource = meterdata.NonProdResource;
                    me.PDI = meterdata.OrganizationName;
                    me.PDIUAT = meterdata.PDIUAT;
                    me.PMG = meterdata.PMG;
                    me.Prf = meterdata.Prf;
                    me.Refuel = meterdata.Refuel;
                    me.resourceType = meterdata.resourceType;
                    me.SHAPI = meterdata.SHAPI;
                    me.Shiptech10 = meterdata.Shiptech10;
                    me.Shiptechdev = meterdata.Shiptechdev;
                    me.ShiptechHapag = meterdata.ShiptechHapag;
                    me.SmartTrader = meterdata.SmartTrader;
                    me.Storage = meterdata.Storage;
                    me.Stroage = meterdata.Stroage;
                    me.subcustomerlevel = meterdata.subcustomerlevel;
                    me.Techoil = meterdata.Techoil;
                    me.Techoil_1133 = meterdata.Techoil_1133;
                    me.TechoilAlchemist = meterdata.TechoilAlchemist;
                    me.TechoilInternal = meterdata.TechoilInternal;
                    me.TechoilMultitenant = meterdata.TechoilMultitenant;
                    me.TechoilPDI = meterdata.TechoilPDI;
                    me.TechoilStaging = meterdata.TechoilStaging;
                    me.tenant = meterdata.tenant;
                    me.TenantManager = meterdata.TenantManager;
                    me.TerfoilBO = meterdata.TerfoilBO;
                    me.TrefoilBO = meterdata.TrefoilBO;




                    _context.MeterData.Add(me);
                    _context.SaveChanges();
                    await _context.SaveChangesAsync();
                    TempData["ResultOk"] = "Data Updated Successfully !";
                }


                //var attRes = new ReadExcel.Model
                //attRes.Result = error;
                //attRes.AttendanceList = attendanceList;
                return RedirectToAction("PageSubmission", "Employee");
                //return attRes;            
                //return message.CreateResponse(System.Net.HttpStatusCode.OK);
            }
            else
            {
                //var attRes = new ReadExcel.Model.AttendanceResult();
                //attRes.Result = "invalidfile";
                meterList = null;
                return Ok(meterList);


            }


        }

       // Upload UserConsumptionData

                [HttpGet]
                public IActionResult UserConsumptionFileUpload()
        {
            return View();
        }

        //Non-RIExcelFileUpload

        [HttpPost]
        public async Task<IActionResult> UserConsumptionFileUpload(UserConsumptionUpload userConsumptionUpload)
        {
            try
            {
                string name = userConsumptionUpload.formFile.ContentDisposition;
                var index = name.LastIndexOf("=");
                string f = name.Substring(index + 2);

                string fileName = f.Substring(0, f.Length - 1);

                var fileList = _context.UserConsumptionDataFileUpload.ToList();
                bool isPresent = false;

                foreach (var file in fileList)
                {
                    if (file.filepath == fileName)
                        isPresent = true;
                }
                if (!isPresent) // not present
                {

                    List<UserConsumptionExcelModel> usersConsumptionsList;

                    string error = "success";
                    // && System.IO.Path.GetExtension(fileupload.formFile.Name).ToLower() == ".xlsx"
                    if (userConsumptionUpload != null && userConsumptionUpload.formFile.Length > 0)
                    {

                        usersConsumptionsList = ReadUserConsumption.ReadUserConsumptionFile(userConsumptionUpload.formFile.OpenReadStream(), DateTime.Now, ref error);

                        //ReadExcel.ReadExcel.ReadExcelFile(file, DateTime.Now, ref error);
                        foreach (UserConsumptionExcelModel userConsumptionexcelname in usersConsumptionsList)
                        {
                            UserConsumptionExcelModel userri = new UserConsumptionExcelModel();


                            userri.Name = userConsumptionexcelname.Name;
                            userri.TYPE = userConsumptionexcelname.TYPE;
                            userri.RESOURCEGROUP = userConsumptionexcelname.RESOURCEGROUP;
                            userri.Customer = userConsumptionexcelname.Customer;
                            userri.Environment = userConsumptionexcelname.Environment;
                            userri.SplitPercentage = userConsumptionexcelname.SplitPercentage;
                            userri.SplitGroup = userConsumptionexcelname.SplitGroup;
                            userri.Consumed = userConsumptionexcelname.Consumed;
                            userri.Unit = userConsumptionexcelname.Unit;
                            userri.RecordCreatedOn = userConsumptionexcelname.RecordCreatedOn;

                            UserConsumptionUpload file = new UserConsumptionUpload()
                            {
                                filepath = fileName
                            };

                            _context.UserConsumptionRecords.Add(userri);
                            _context.SaveChanges();
                            await _context.SaveChangesAsync();
                            TempData["ResultOk"] = "Data Updated Successfully !";
                        }


                        //var attRes = new ReadExcel.Model
                        //attRes.Result = error;
                        //attRes.AttendanceList = attendanceList;
                        return RedirectToAction("PageSubmission", "Employee");
                        //return attRes;            
                        //return message.CreateResponse(System.Net.HttpStatusCode.OK);
                    }
                    else
                    {
                        //var attRes = new ReadExcel.Model.AttendanceResult();
                        //attRes.Result = "invalidfile";
                        usersConsumptionsList = null;
                        return Ok(usersConsumptionsList);


                    }
                }
                else // present
                {
                    ViewBag.error = "*File Already present. Please select the new one";
                    return View("NonRIBillingFileUpload");
                }
            }
            catch (Exception e)
            {

                ViewBag.error = "*Please choose the valid file";
                return View("NonRIBillingFileUpload");
            }
        }


    }
}