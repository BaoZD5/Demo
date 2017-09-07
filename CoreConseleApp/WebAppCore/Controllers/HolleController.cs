using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCore.Controllers
{
    public class HolleController : Controller
    {
        public IActionResult Index()
        {
            ViewData["x"] = "xxxxxxxx";
            return View();
        }
    }
}