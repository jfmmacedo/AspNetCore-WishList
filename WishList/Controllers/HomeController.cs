using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace wishlist.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // return View("./Views/Home/Index");
            return View();
        }

        public IActionResult Error() 
        {
            return View("./View/Shared/Error");
        }
    }
}
