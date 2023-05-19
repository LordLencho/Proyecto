using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Models;
using System.Text;

namespace Biblioteca.Logica
{
    public class PersonaLogica
    {
        private static PersonaLogica instancia = null;

        public PersonaLogica()
        {

        }

        public static PersonaLogica Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new PersonaLogica();
                }

                return instancia;
            }
        }

        public List<Persona> Listar()
        {
            List<Persona> Lista = new List<Persona>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.CN))
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("select p.IdPersona,p.Nombre,p.Apellido,p.Correo,p.Clave,p.Codigo,tp.IdTipoPersona,tp.Descripcion, p.Estado from persona p");
                    sb.AppendLine("inner join TIPO_PERSONA tp on tp.IdTipoPersona = p.IdTipoPersona");

                    SqlCommand cmd = new SqlCommand(sb.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;

                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Persona()
                            {
                                IdPersona = Convert.ToInt32(dr["IdPersona"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellido = dr["Apellido"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Codigo = dr["Codigo"].ToString(),
                                oTipoPersona = new TipoPersona() { IdTipoPersona = Convert.ToInt32(dr["IdTipoPersona"]), Descripcion = dr["Descripcion"].ToString() },
                                Estado = Convert.ToBoolean(dr["Estado"])
                            });
                        }
                    }

                }
                catch (Exception ex)
                {
                    Lista = new List<Persona>();
                }
            }
            return Lista;
        }


    }
}