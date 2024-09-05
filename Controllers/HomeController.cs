﻿using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionsASP.Controllers
{
    // : means extends
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
