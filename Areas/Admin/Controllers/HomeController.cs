using Microsoft.AspNetCore.Mvc;

namespace Lab1final.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult Profile()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult LogOut()
        {
            return View("~/Views/Account/Login.cshtml");
        }
    }
}
