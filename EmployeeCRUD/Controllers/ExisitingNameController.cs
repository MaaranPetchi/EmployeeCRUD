using EmployeeCRUD.Data;
using EmployeeCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeCRUD.Controllers
{
    public class ExisitingNameController : Controller
    {
        //private ApplicationDbContext _applicationDbContext;

        //public ExisitingNameController(ApplicationDbContext applicationDbContext)
        //{
        //    _applicationDbContext = applicationDbContext;
        //}

        //public IActionResult Index()
        //{
        //    var exisitingName = (from UsersConsumptionData in _applicationDbContext.ManualUserConsumptionData
        //                         select new SelectListItem()
        //                         {
        //                             Text = UsersConsumptionData.Name.ToString(),
        //                             Value = UsersConsumptionData.Id.ToString()
        //                         }).ToList();
        //    exisitingName.Insert(0, new SelectListItem()
        //    {
        //        Text = "---Select---",
        //        Value = String.Empty
        //    });

        //    ViewBag.ExisitingName = exisitingName;
        //    return View();
        //}


        //[HttpPost]

        //public IActionResult Index(ExisitingUserConsumptionData exisitingUserConsumptionData)

        //{
        //    var selectedValue = exisitingUserConsumptionData.UserId;

        //    return View(exisitingUserConsumptionData);
        //}
      
    }
}
