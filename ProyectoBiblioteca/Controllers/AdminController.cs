using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBiblioteca.Controllers
{
    public class AdminController : Controller
    {
        private static PersonaController oPersona;
        // GET: Admin
        //public ActionResult Index()
        //{
        //    if (Session["Usuario"] == null)
        //        return RedirectToAction("Index", "Login");

        //    oPersona = (Persona)Session["Usuario"];

        //        return View();
        //}

        public ActionResult CerrarSesion()
        {
            Session["Usuario"] = null;
            return RedirectToAction("Index", "Login");
        }

    }
}
