using Angular_Test.WebTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Angular_Test.WebTest.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public Student GetStudent()
        {
            var obj = new Student();
            obj.Name = "Sahan";
            obj.SurName = "Mendis";
            obj.Address = "14, SS Road, XYZ.";
            obj.Mobile = "0772356734";
            return obj;
        }

        public IActionResult Index()
        {
            var std = GetStudent();
            return View("Home", std);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}