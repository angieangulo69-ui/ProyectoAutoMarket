using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Datos_CategoriaVehiculo
    {
        // Instancia de la clase Conexion para manejar la conexión a la base de datos
        private Conexion conexion = new Conexion();
        // Método para insertar una nueva categoría de vehículo en la base de datos
        public bool InsertarCategoria(CategoriaVehiculo categoria)
        {
            //using se usa para asegurar que la conexión se
            //cierre correctamente después de su uso, incluso si ocurre una excepción
            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                //query 
                string query = "INSERT INTO CategoriaVehiculo (IdCategoria,NombreCategoria,Descripcion) VALUES (@Id,@Nombre,@Descripcion)";
                // Ejecutar la consulta SQL para insertar la nueva categoría de vehículo
                using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@Id", categoria.IdCategoria);
                    comando.Parameters.AddWithValue("@Nombre", categoria.NombreCategoria);
                    comando.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);
                    //verifica si se insertó correctamente la
                    //categoría de vehículo, si no se afectó ninguna fila, lanza una excepción
                    int filasAfectadas = comando.ExecuteNonQuery();
                    if (filasAfectadas == 1)
                    {
                        return true;
                    }
                    else
                    {
                        throw new Exception("No se pudo insertar la categoría de vehículo.");

                    }
                }
            }
        }

        // Método para obtener todas las categorías de vehículos desde la base de datos
        public List<CategoriaVehiculo> ObtenerCategorias()
        {
            List<CategoriaVehiculo> listacategorias = new List<CategoriaVehiculo>();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();// Consulta SQL para seleccionar todas las categorías de vehículos
                    string query = "SELECT IdCategoria, NombreCategoria, Descripcion FROM CategoriaVehiculo";
                    // Ejecutar la consulta y leer los resultados
                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader()) // Leer cada fila devuelta por la consulta
                        {
                            while (reader.Read())
                            {
                                CategoriaVehiculo categoria = new CategoriaVehiculo
                                {
                                    IdCategoria = reader.GetInt32(0), // Obtener el ID de la categoría
                                    NombreCategoria = reader.GetString(1), // Obtener el nombre de la categoría
                                    Descripcion = reader.GetString(2) // Obtener la descripción de la categoría
                                };
                                listacategorias.Add(categoria); // Agregar la categoría a la lista de categorías
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener categorías: " + ex.Message);
            }
            return listacategorias;
        }

        // Método para obtener el siguiente ID disponible para una nueva categoría de vehículo
        public int ObtenerSiguienteId()
        {
            int siguienteId = 1;

            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT ISNULL(MAX(IdCategoria),0) + 1 FROM CategoriaVehiculo";

                using (var cmd = new SqlCommand(query, conn))
                {
                    siguienteId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return siguienteId;
        }
        public int ContarCategorias()
        {
            const string sql = "SELECT COUNT(*) FROM CategoriaVehiculo";
            using (var conn = conexion.ObtenerConexion())
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}