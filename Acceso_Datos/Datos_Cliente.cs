using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Datos_Cliente
    {// Clase para gestionar el acceso a datos de los clientes, utilizando una instancia de la clase Conexion para interactuar con la base de datos.
        private Conexion conexion = new Conexion();
        public void InsertarCliente(Cliente cliente)
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Cliente (IdCliente,Identificacion, NombreCompleto, FechaNacimiento, FechaRegistro, Activo) " +
                                   "VALUES (@IdCliente,@Identificacion, @NombreCompleto, @FechaNacimiento, @FechaRegistro, @Activo)";
                    // Se utiliza un comando SQL parametrizado para evitar inyecciones SQL y asegurar la integridad de los datos.
                    using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                        cmd.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                        cmd.Parameters.AddWithValue("@NombreCompleto", cliente.NombreCompleto);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);
                        cmd.Parameters.AddWithValue("@Activo", cliente.Activo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores, por ejemplo, registrar el error o mostrar un mensaje
                Console.WriteLine("Error al insertar cliente: " + ex.Message);
            }
        }
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> listaclientes = new List<Cliente>();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT * FROM Cliente";

                    using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {                                
                                int id = Convert.ToInt32(reader["IdCliente"]);
                                string identificacion = reader["Identificacion"].ToString();
                                string nombre = reader["NombreCompleto"].ToString();
                                DateTime fechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                                DateTime fechaRegistro = Convert.ToDateTime(reader["FechaRegistro"]);
                                bool activo = Convert.ToBoolean(reader["Activo"]);

                                listaclientes.Add(new Cliente(id, identificacion, nombre, fechaNacimiento, fechaRegistro, activo));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener clientes: " + ex.Message, ex);
            }
            return listaclientes;
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
                    string query = "SELECT ISNULL(MAX(IdCliente),0) + 1 FROM Cliente";
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        siguienteId = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente: " + ex.Message, ex);
            }
            return siguienteId;
        }
    }
}