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
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            public SqlConnection ObtenerConexion()
            {
                return new SqlConnection(cadenaConexion);
        }
    }
}
