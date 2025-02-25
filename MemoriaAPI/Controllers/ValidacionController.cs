using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemoriaAPI.Entidades;
using MemoriaAPI.Logica;

namespace MemoriaAPI.Controllers
{
    public class ValidacionController : Controller
    {
        private static readonly ValidacionLogica logicObject = new ValidacionLogica();

        // GET: Validacion
        [HttpGet]
        public ActionResult Index()
        {
            return Json(new { data = "" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult ValidarJugada(int[] data, Carta[] cartasData)
        {
            bool flag = false;
            try
            {
                flag = logicObject.ValidarJugada(data, cartasData);
            }
            catch (Exception ex)
            {
                return Json(new { data = "", err = ex.Message }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { data = flag ? 1 : 0, err="OK" }, JsonRequestBehavior.AllowGet);
        }
    }
}