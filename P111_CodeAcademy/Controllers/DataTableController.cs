using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace P111_CodeAcademy.Controllers
{
    public class DataTableController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Table = "DataTable";
            return View();
        }
    }
}