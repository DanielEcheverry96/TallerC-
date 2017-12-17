using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerC.Models;

namespace TallerC.Controllers
{
    public class CirculoController : Controller
    {
        double pi = Math.PI;
        // GET: Circulo
        public ActionResult Index(Circulo circulotemp)
        {
            ViewBag.AreaCirculo = pi * Math.Pow(circulotemp.radio, 2);
            return View();
        }
    }
}