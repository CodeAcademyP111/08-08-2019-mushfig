using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P111_CodeAcademy.Controllers
{
    public class AccardionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Error()
        {
            return Content("Zehmet olmasa duzgun URL daxil edin");
        }
    }
}
