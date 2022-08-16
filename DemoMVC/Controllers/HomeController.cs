using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string name = "Tom";
            int age = 20;
            ViewBag.Name = name;
            ViewData["age"] = age;
            TempData["name"] = name;
            return View();
        }
        public IActionResult Contact()
        {
            
            return View();
        }
        public IActionResult About()
        {
            ViewBag.Name = TempData["name"];
            return View();
        }
    }
}
