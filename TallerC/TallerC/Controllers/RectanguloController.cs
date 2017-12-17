using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerC.Models;

namespace TallerC.Controllers
{ 
    public class RectanguloController : Controller
    {
        // GET: Rectangulo
        public ActionResult Index(Rectangulo rectangulotemp)
        {
            ViewBag.AreaRectangulo = rectangulotemp.altura * rectangulotemp.baser;
            return View();
        }
    }
}