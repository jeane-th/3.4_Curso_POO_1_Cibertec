using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using appWeb01.Models;


namespace appWeb01.Controllers
{
    public class VentasController : Controller
    {
        // GET: Ventas 
        public ActionResult ActionVenta()
        {
            // inicialización de los valores de la vista
            // Hay q inicializar los valores para evital que salga null al cargar la pagina
            ViewBag.Descuento = 0;
            ViewBag.Total = 0;
            // Instanciación del Modelo
            return View(new Venta());
        }
        [HttpPost]public ActionResult ActionVenta(Venta reg)
        {
            ViewBag.Descuento = reg.Descuento();
            ViewBag.Total = reg.Total();
            return View(reg);
        }
    }
}