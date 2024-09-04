using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionsASP.Controllers
{
    // : means extends
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // ViewResult, PArtialViewResult, JsonResult, etc has implemented the IActionResult
        }

        public string Display()
        {
            return "Welcome to ASP.NET World!";
        }

        public int DisplayId(int id)
        {
            return id;
        }

        public IActionResult ContentResult() 
        {
            return Content("This is Content Result"); //for plain text result
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult(); //for doing nothing
        }

        public IActionResult JsonResult()
        {
            var name = "Sarmad";
            var department = "Computer Science";
            return Json(new {name,department}); //for JSON result
        }
    }
}
