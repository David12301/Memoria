using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemoriaAPI.Entidades;
using MemoriaAPI.Logica;

namespace MemoriaAPI.Controllers
{
    public class JuegoController : Controller
    {
        private static readonly JuegoLogica logicObject = new JuegoLogica();

        // GET: Juego
        [HttpGet]
        public ActionResult Index()
        {
            return Json(new { data = "" }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Iniciar()
        {
            Juego j = logicObject.Iniciar();
            return Json(new { data = j }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult JuegoTerminado(Carta[] data)
        {
            Grilla g = new Grilla(data);
            bool flag = logicObject.JuegoTerminado(g);
            return Json(new { data = flag ? 1 : 0 }, JsonRequestBehavior.AllowGet);
        }

    }
}