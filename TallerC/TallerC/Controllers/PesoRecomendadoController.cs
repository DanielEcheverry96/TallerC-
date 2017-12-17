using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerC.Models;

namespace TallerC.Controllers
{
    public class PesoRecomendadoController : Controller
    {
        // GET: PesoRecomendado
        public ActionResult Index(PesoRecomendado pesotemp)
        {

            ViewBag.PesoRecomendado = (pesotemp.altura - 100 + pesotemp.edad / 10) * 0.9;
            return View();
        }
    }
}