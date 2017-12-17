using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerC.Models;

namespace TallerC.Controllers
{
    public class NumerosController : Controller
    {
        // GET: Numeros
        public ActionResult Index(Numeros numerostemp)
        {
            int numero1 = numerostemp.numero1, numero2 = numerostemp.numero2, resultado = 0;

            if (numero1 < numero2)
            {
                resultado = numero1 + numero2;
            }
            else if (numero1 > numero2)
            {
                resultado = numero1 - numero2;
            }
            else
            {
                resultado = numero1 * numero2;
            }

            ViewBag.Resultado = resultado;
            return View();
        }
    }
}