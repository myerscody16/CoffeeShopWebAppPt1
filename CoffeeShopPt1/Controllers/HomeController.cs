using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoffeeShopPt1.Models;

namespace CoffeeShopPt1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View(new NewUser());
        }
        [HttpPost]
        public IActionResult Registration(NewUser newUser)
        {
            return RedirectToAction("EnrollNewUser", newUser);
        }
        public IActionResult EnrollNewUser(NewUser user)
        {
            return View(user);
        }
    }
}
