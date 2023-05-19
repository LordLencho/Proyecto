using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class AdminController : Controller
    {
        private static PersonaController oPersona;
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["Usuario"] == null)
                return RedirectToAction("Index", "Login");

            oPersona = (PersonaController)Session["Usuaro"];

            return View();
        }

        public ActionResult CerrarSesion()
        {
            Session["Usuario"] = null;
            return RedirectToAction("Index", "Login");

        }

    }
}
