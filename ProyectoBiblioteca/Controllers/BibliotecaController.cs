using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoBiblioteca.Controllers
{
    public class BibliotecaController : Controller
    {
        // Biblioteca
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Libros()
        {
            return View();
        }

        public ActionResult Autores()
        {
            return View();
        }

        public ActionResult Editorial()
        {
            return View();
        }

        public ActionResult Categoria()
        {
            return View();
        }

        //[HttpGet]

        //public JsonResult ListarCategoria()
        //{
        //    List<Categoria> oLista = new List<Categoria>();
        //}
    }
}