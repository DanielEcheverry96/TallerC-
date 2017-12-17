using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerC.Models;

namespace TallerC.Controllers
{
    public class NumerosConsecutivosController : Controller
    {
        string mensaje = "";

        // GET: NumerosConsecutivos
        public ActionResult Index(NumerosConsecutivos numconsetemp)
        {
            int ini = numconsetemp.inicio;
            int final = numconsetemp.fin;
            string resultado = "";
            if (ini <= final)
            {
                resultado = inicio(ini,final);
            }
            else
            {
                resultado = fin(ini, final);
            }

            ViewBag.Resultado = resultado;
            return View();
        }

        public string inicio(int inicio, int fin)
        {
            for (int i = inicio; i <= fin; i++)
            {
                mensaje += i + ", ";
            }
            return mensaje;
        }

        public string fin(int fin, int inicio)
        {
            for (int i = fin; i >= inicio; i--)
            {
                mensaje += i + ", ";
            }
            return mensaje;
        }
    }
}