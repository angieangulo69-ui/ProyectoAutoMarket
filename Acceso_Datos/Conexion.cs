using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Conexion
    {
        private string cadenaConexion;

        public Conexion()
        {
            var conn = ConfigurationManager.ConnectionStrings["conexion"];

            if (conn == null)
                throw new Exception("No se encontró la cadena de conexión en App.config");

            cadenaConexion = conn.ConnectionString;
        }

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

