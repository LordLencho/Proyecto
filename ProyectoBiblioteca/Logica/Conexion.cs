using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoBiblioteca.Logica
{
    public class Conexion
    {
        public static string conexion()
        {
            string miconexion = @"Data Source=LUISANTONIO;Initial Catalog=DB_BIBLIOTECA;User ID=luisa";
            return miconexion;
        }
    }
}