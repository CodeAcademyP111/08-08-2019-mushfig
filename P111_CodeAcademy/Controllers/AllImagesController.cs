using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P111_CodeAcademy.Models;
using P111_CodeAcademy.ViewModels;

namespace P111_CodeAcademy.Controllers
{
    public class AllImagesController : Controller
    {
        public IActionResult Index()
        {
            StudentImage studentImages = new StudentImage()
            {
                Students = Images.GetStudents(),
                MyImages = Images.GetImages(),
                Numbers = Images.GetNumbers()
            };

            ViewBag.Name = "It's interesting";
           // return View(Images.GetImages());
            return View(studentImages);
        }
          
        public IActionResult Image(int id)
        {
            Image image = Images.GetImages().Where(v => v.Id == id).FirstOrDefault();
            //< a href = "/AllImages/image/@image.Id" ></ a > id burdan gelir
            //if (image==null)
            //{
            //    return NotFound();
            //}
            return File("~/img/cards_img/" + @image.Link, "image/jpg");

        }
        public IActionResult Error()
        {
            return Content("Zehmet olmasa duzgun URL daxil edin");
        }
    }
}


