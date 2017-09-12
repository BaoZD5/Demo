using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppCore2.Controllers
{
    public class TwoController : Controller
    {
        public IActionResult TwoIndex()
        {
            return View();
        }
    }
}