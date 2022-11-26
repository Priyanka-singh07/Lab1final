using Microsoft.AspNetCore.Mvc;

namespace Lab1final.Areas.User.Controllers
{
    public class HomeController : Controller
    {
        [Area("User")]
        public IActionResult Index()
        {
            return View();
        }
        [Area("User")]

        public IActionResult Profile()
        {
            return View();
        }
        [Area("User")]
        public IActionResult LogOut()
        {
            return View("~/Views/Account/Login.cshtml");

        }
    }
}
