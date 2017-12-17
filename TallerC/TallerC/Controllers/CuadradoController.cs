using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerC.Models;

namespace TallerC.Controllers
{
    public class CuadradoController : Controller
    {
        // GET: Cuadrado
        public ActionResult Index(Cuadrado cuadradotemp)
        {
            double lado = cuadradotemp.lado;
            ViewBag.AreaCuadrado = lado * lado; 
            return View();
        }
    }
}