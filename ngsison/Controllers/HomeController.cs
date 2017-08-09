using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ngsison.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			ViewData["Title"] = "Nathaniel Brion Sison";
            return View();
        }
    }
}
