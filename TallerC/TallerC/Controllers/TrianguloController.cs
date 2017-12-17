using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerC.Models;

namespace TallerC.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Index(Triangulo triangulotemp)
        {
            ViewBag.AreaTriangulo = (triangulotemp.baset * triangulotemp.altura)/ 2;
            return View();
        }
    }
}