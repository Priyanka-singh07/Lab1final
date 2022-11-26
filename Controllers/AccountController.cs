using Microsoft.AspNetCore.Mvc;
using Lab1final.Models;

namespace Lab1final.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View("~/Views/Account/Login.cshtml");
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel objlogin)
        {
            if (ModelState.IsValid)
            {
                if (objlogin.UserName == "admin@gmail.com" && objlogin.Password == "12345678")
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                else if (objlogin.UserName == "user@gmail.com" && objlogin.Password == "12345678")
                {
                    return RedirectToAction("Index", "Home", new { area = "User" });
                }


            }
            ModelState.AddModelError("", "Invalid login attempt");
            return View(objlogin);


        }
        public IActionResult Logout()
        {
            return View("~/Views/Account/Login.cshtml");
        }
    }
}
