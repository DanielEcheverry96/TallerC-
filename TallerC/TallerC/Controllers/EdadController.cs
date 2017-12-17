using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TallerC.Models;

namespace TallerC.Controllers
{
    /*
    Dada el nombre, Cedula y edad en años de una persona mostrar su nombre, cedula y 
    equivalencia en meses, días, horas y minutos, además mostrar un mensaje que diga 
    si es mayor o menor de edad. (Mayor edad>=18). 
    */
    public class EdadController : Controller
    {
        //Equivalencias a un año
        int meses = 12;
        int dias = 365;
        int horas = 8760;
        int minutos = 525600;

        // GET: Eadad
        public ActionResult Index(EdadPersona edadpersonatemp)
        {
            int edad = edadpersonatemp.edad;
            ViewBag.EdadMeses = meses * edad;
            ViewBag.EdadDias = dias * edad;
            ViewBag.EdadHoras = horas * edad;
            ViewBag.EdadMinutos = minutos * edad;
            ViewBag.Edad = edad;
            return View();
        }
    }
}