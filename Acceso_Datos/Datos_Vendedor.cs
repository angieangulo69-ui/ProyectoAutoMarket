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
        public void InsertarVendedor(Vendedor vendedor)
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Vendedor (IdVendedor,Identificacion, NombreCompleto, FechaNacimiento, FechaIngreso, Telefono) " +
                                   "VALUES (@IdVendedor,@Identificacion, @NombreCompleto, @FechaNacimiento, @FechaIngreso, @Telefono)";
                    // Se utiliza un comando SQL parametrizado para evitar inyecciones SQL y asegurar la integridad de los datos.
                    using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdVendedor", vendedor.IdVendedor);
                        cmd.Parameters.AddWithValue("@Identificacion", vendedor.Identificacion);
                        cmd.Parameters.AddWithValue("@NombreCompleto", vendedor.NombreCompleto);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", vendedor.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@FechaIngreso", vendedor.FechaIngreso);
                        cmd.Parameters.AddWithValue("@Telefono", vendedor.Telefono);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar vendedor: " + ex.Message);
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
                    string query = "SELECT * FROM Vendedor";

                    using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = Convert.ToInt32(reader["IdVendedor"]);
                                string identificacion = reader["Identificacion"].ToString();
                                string nombre = reader["NombreCompleto"].ToString();
                                DateTime fechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                                DateTime fechaIngreso = Convert.ToDateTime(reader["FechaIngreso"]);
                                string telefono = reader["Telefono"].ToString();

                                listavendedor.Add(new Vendedor(id, identificacion, nombre, fechaNacimiento, fechaIngreso, telefono));
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
    

