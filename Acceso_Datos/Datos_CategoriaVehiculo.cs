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
        public void InsertarCategoria(CategoriaVehiculo categoria)
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    //query 
                    string query = "INSERT INTO CategoriaVehiculo (IdCategoria,NombreCategoria,Descripcion) VALUES (@Id,@Nombre,@Descripcion)";

                    using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", categoria.IdCategoria);
                        cmd.Parameters.AddWithValue("@Nombre", categoria.NombreCategoria);
                        cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar categoría: " + ex.Message);
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
                    string query = "SELECT * FROM CategoriaVehiculo";
                    // Ejecutar la consulta y leer los resultados
                    using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader()) // Leer cada fila devuelta por la consulta
                        {
                            while (reader.Read())
                            { //
                                int id = Convert.ToInt32(reader["IdCategoria"]);
                                string nombre = reader["NombreCategoria"].ToString();
                                string descripcion = reader["Descripcion"].ToString();
                                listacategorias.Add(new CategoriaVehiculo(id, nombre, descripcion));
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
    }
}
    

