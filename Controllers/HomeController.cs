using ControllersAndActionsASP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionsASP.Controllers
{
    // : means extends
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //model data
            var persons = new List<PersonModel> { 
                new PersonModel { personName = "Sarmad", personAge = 24, personProfession = "Programmer"},
                new PersonModel { personName = "Jalbani", personAge = 16, personProfession = "Student" },
                new PersonModel { personName = "Ali", personAge = 5, personProfession = "Child"}
            };

            //passing data Via ViewData
            ViewData["persons"] = persons;


            //preparing data in ViewData to pass to View
            ViewData["name"] = "Sarmad";
            ViewData["dept"] = "Computer Science";
            ViewData["sem"] = "Seven";
            ViewData["date"] = DateTime.Now;

            string[] arr = { "Sarmad","Ali","Jalbani" };
            ViewData["array"] = arr;

            return View(); // ViewResult, PArtialViewResult, JsonResult, etc has implemented the IActionResult
        }

        public IActionResult About()
        {
            //preparing data in ViewBag to pass to View
            ViewBag.name = "Sarmad";
            ViewBag.dept = "Computer Science";
            ViewBag.age = 24;
            ViewBag.nameList = new List<string> { "Sarmad", "Ali", "Jalbani"};
            return View(); // ViewResult, PArtialViewResult, JsonResult, etc has implemented the IActionResult
        }

        public IActionResult Contact()
        {
            //preparing data in TempData to pass to View
            //and differences ViewData, ViewBag, TempData
            //we can access tempdata in other views as well
            //type cast is compulsory for TempData
            ViewData["vdata"] = "View Data";
            ViewBag.vbag = "View Bag";

            //we can use TempData.keep() to keep the data across Actions/Views
            //but the best practice is to use the sessions
            TempData["tempdata"] = "Temp Data";

            return View(); // ViewResult, PArtialViewResult, JsonResult, etc has implemented the IActionResult
        }


        //public string Display()
        //{
        //    return "Welcome to ASP.NET World!";
        //}

        //public int DisplayId(int id)
        //{
        //    return id;
        //}

        //public IActionResult ContentResult() 
        //{
        //    return Content("This is Content Result"); //for plain text result
        //}

        //public IActionResult EmptyResult()
        //{
        //    return new EmptyResult(); //for doing nothing
        //}

        //public IActionResult JsonResult()
        //{
        //    var name = "Sarmad";
        //    var department = "Computer Science";
        //    return Json(new {name,department}); //for JSON result
        //}
    }
}
