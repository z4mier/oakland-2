using Microsoft.AspNetCore.Mvc;

namespace Oakland_Homeowners.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Loads Views/Home/Index.cshtml
        }

        public IActionResult Dashboard()
        {
            return View(); // Loads Views/Home/Dashboard.cshtml
        }
        public IActionResult Announcements()
        {
            return View();
        }
        public IActionResult EventCalendar()
        {
            return View();
        }

    }
}
