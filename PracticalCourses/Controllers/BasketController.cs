using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PracticalCourses.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult AddToBasket(string id)
        {
            return View();
        }
    }
}