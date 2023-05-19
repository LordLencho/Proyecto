using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteca.Models;
using Biblioteca.Logica;

namespace Biblioteca.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }   

        // POST: Login/Create
        [HttpPost]
        public ActionResult Index(string correo, string clave)
        {

            Persona ousuario = PersonaLogica.Instancia.Listar().Where(u => u.Correo == correo && u.Clave
            == clave && u.oTipoPersona.IdTipoPersona != 3).FirstOrDefault();

            if (ousuario == null)
            {
                ViewBag.Error = "Usuario o contraseña incorrectos";
                return View();
            }

            Session["Usuario"] = ousuario;

            return RedirectToAction("Index", "Admin");

        }
    }
}
