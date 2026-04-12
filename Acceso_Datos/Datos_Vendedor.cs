using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Datos_Vendedor
    {
        private Conexion conexion = new Conexion();
        public bool InsertarVendedor(Vendedor vendedor)
        {
            
            
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Vendedor (IdVendedor,Identificacion, NombreCompleto, FechaNacimiento, FechaIngreso, Telefono) " +
                                   "VALUES (@IdVendedor,@Identificacion, @NombreCompleto, @FechaNacimiento, @FechaIngreso, @Telefono)";
                    // Se utiliza un comando SQL parametrizado para evitar inyecciones SQL y asegurar la integridad de los datos.
                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@IdVendedor", vendedor.IdVendedor);
                        comando.Parameters.AddWithValue("@Identificacion", vendedor.Identificacion);
                        comando.Parameters.AddWithValue("@NombreCompleto", vendedor.NombreCompleto);
                        comando.Parameters.AddWithValue("@FechaNacimiento", vendedor.FechaNacimiento);
                        comando.Parameters.AddWithValue("@FechaIngreso", vendedor.FechaIngreso);
                        comando.Parameters.AddWithValue("@Telefono", vendedor.Telefono);

                        int filasAfectadas = comando.ExecuteNonQuery();
                        if (filasAfectadas == 1)
                        {
                            return true;
                        }
                        else
                        {
                            throw new Exception("No se pudo insertar la categoría de vehículo.");
                            return false;
                        }
                    }
                }
            }
           
        
        public List<Vendedor> ObtenerVendedor()
        {
            List<Vendedor> listavendedor = new List<Vendedor>();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT IdVendedor, Identificacion, NombreCompleto, FechaNacimiento, FechaIngreso, Telefono FROM Vendedor";

                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Vendedor vendedor = new Vendedor
                                {
                                    IdVendedor = reader.GetInt32(0),
                                    Identificacion = reader.GetString(1),
                                    NombreCompleto = reader.GetString(2),
                                    FechaNacimiento = reader.GetDateTime(3),
                                    FechaIngreso = reader.GetDateTime(4),
                                    Telefono = reader.GetString(5)
                                };
                                listavendedor.Add(vendedor);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vendedor: " + ex.Message, ex);
            }
            return listavendedor;
        }
        //
        public int ObtenerSiguienteId()
        {
            int siguienteId = 1; // Valor predeterminado si no hay clientes en la base de datos
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(IdVendedor),0) + 1 FROM Vendedor";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        siguienteId = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar vendedor: " + ex.Message, ex);
            }
            return siguienteId;
        }
    }
}
    

