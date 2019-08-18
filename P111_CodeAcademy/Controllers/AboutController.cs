using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace P111_CodeAcademy.Controllers
{
    public class AboutController : Controller
    {
        public string Index()
        {
            //ViewResult view = new ViewResult();
            //view.ViewName = "Index";
            //return view;
            return "Salam : About Page";
        }

    }
}