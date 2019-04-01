using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTML_helpers.Models;

namespace HTML_helpers.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        



        public ActionResult MostarD( Datos datos )
        {
            if (!ModelState.IsValid)
            {
                return View(datos);
            }
            return View("MostarD", datos);
        }


    }
}