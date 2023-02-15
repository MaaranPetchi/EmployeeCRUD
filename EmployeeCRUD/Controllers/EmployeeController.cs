using DocumentFormat.OpenXml.Spreadsheet;
using EmployeeCRUD.Data;
using EmployeeCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace EmployeeCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
     
        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        private ApplicationDbContext db = new ApplicationDbContext();
        public IActionResult Index()
        {
            IEnumerable<UsersConsumptionData> objCatlist = _context.UsersConsumptionReport;
            //ViewBag.ListCheckbox = this.db.ManualUserConsumptionData.ToList();

            return View(objCatlist);

           
            //List<UsersConsumptionDataviewModel> vm = new List<UsersConsumptionDataviewModel>();
            //var items = _context.ManualUserConsumptionData.ToList();
            //foreach (var item in items)

            //{

            //    vm.Add(new UsersConsumptionDataviewModel
            //    {

            //        Id = item.Id,
            //        Name = item.Name,
            //        RESOURCEGROUP = item.RESOURCEGROUP,
            //        Customer = item.Customer,
            //        Environment = item.Environment,
            //        SplitPercentage = item.SplitPercentage,
            //        SplitGroup = item.SplitGroup,
            //        Consumed = item.Consumed,
            //        Unit = item.Unit,
            //        RecordCreatedOn = item.RecordCreatedOn
            //    });
            //}
            //return View(vm);

        }

        [HttpGet]

        public async Task<IActionResult> Index(string Empsearch)
        {
            ViewData["Getemployeedetails"] = Empsearch;
          

          var empquery = from x in _context.ManualUserConsumptionData select x;
            if (!String.IsNullOrEmpty (Empsearch))
{
                empquery = empquery.Where(x => x.Name.Contains(Empsearch) || x.RESOURCEGROUP.Contains(Empsearch));
            }
            return View(await empquery.AsNoTracking().ToListAsync());
        }
        public IActionResult Create()
        {
        //    List<UsersConsumptionData> cl = new List<UsersConsumptionData>();
        //    List<string> userName = new List<string>();
        //    cl = _context.ManualUserConsumptionData.ToList();
        //    foreach(UsersConsumptionData usersConsumptionData in cl)
        //    {
        //        userName.Add(usersConsumptionData.Name);
        //    }
        //    ViewBag.userNameId = new SelectList(userName, "userNameId", "userName");
            return View();
        }
        public IActionResult PageSubmission()
        {
            return View();
        }
        public IActionResult Details(int id )
        {
           var Data = _context.ManualUserConsumptionData.Where(s => s.Id == id).FirstOrDefault();
            
            return View(Data);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UsersConsumptionData empobj)
        {
            if (ModelState.IsValid)
            {
                var cdate=DateTime.Now;
                empobj.RecordCreatedOn = cdate;

                _context.UsersConsumptionReport.Add(empobj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added Successfully !";
                return RedirectToAction("PageSubmission","Employee");
            }

            return View(empobj);
        }

        
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var empfromdb = _context.UsersConsumptionReport.Find(id);

            if (empfromdb == null)
            {
                return NotFound();
            }
            return View(empfromdb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(UsersConsumptionData empobj)
        {
            if (ModelState.IsValid)
            {
                _context.UsersConsumptionReport.Update(empobj);
                _context.SaveChanges();
                TempData["ResultOk"] = "Data Updated Successfully !";
                return RedirectToAction("Index");
            }

            return View(empobj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var empfromdb = _context.UsersConsumptionReport.Find(id);
         
            if (empfromdb == null)
            {
                return NotFound();
            }
            return View(empfromdb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEmp(int? id)
        {
            var deleterecord = _context.UsersConsumptionReport.Find(id);
            if (deleterecord == null)
            {
                return NotFound();
            }
            _context.UsersConsumptionReport.Remove(deleterecord);
            _context.SaveChanges();
            TempData["ResultOk"] = "Data Deleted Successfully !";
            return RedirectToAction("Index");
        }
        

    }
}
