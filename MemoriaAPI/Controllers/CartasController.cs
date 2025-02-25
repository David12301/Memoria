using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using MemoriaAPI.Entidades;
using MemoriaAPI.Logica;

namespace MemoriaAPI.Controllers
{
    public class CartasController : Controller
    {
        private static readonly CartasLogica logicObject = new CartasLogica(); 

        [HttpGet]
        public ActionResult Index()
        {
            return Json(new { data = "" }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Nuevo()
        {
            Grilla g = logicObject.Nuevo();
            return Json(new { data = g.data }, JsonRequestBehavior.AllowGet);
        }


        [HttpGet]
        public ActionResult Jugada(int[] data, Carta[] cartasData) 
        {
            bool flag = false;
                        try
            {
                flag = logicObject.Jugada(data, cartasData);
            }
            catch (Exception ex) {
                return Json(new { data = "", err = ex.Message }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { data = flag ? 1 : 0, err="OK" }, JsonRequestBehavior.AllowGet);

        }
    }
}
