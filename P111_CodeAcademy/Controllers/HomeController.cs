using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace P111_CodeAcademy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        #region
        //public IActionResult Index()
        //{
        //    return Json(new
        //    {

        //        id = 1,
        //        name = "cavid",
        //        surname = "bashirov"
        //    });

        // return File("~/img/cards_img/1.jpg","image/jpg");

        // }
        #endregion

        public  IActionResult Error()
        {
            return Content("Siz gonderdiyiniz url duzgun deyil");
        }
    }
}
