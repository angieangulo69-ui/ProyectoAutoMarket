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
        public bool InsertarCliente(Cliente cliente)
        {

            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Cliente (IdCliente,Identificacion, NombreCompleto, FechaNacimiento, FechaRegistro, Activo) " +
                               "VALUES (@IdCliente,@Identificacion, @NombreCompleto, @FechaNacimiento, @FechaRegistro, @Activo)";
                // Se utiliza un comando SQL parametrizado para evitar inyecciones SQL y asegurar la integridad de los datos.
                using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                {
                    comando.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    comando.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                    comando.Parameters.AddWithValue("@NombreCompleto", cliente.NombreCompleto);
                    comando.Parameters.AddWithValue("@FechaNacimiento", cliente.FechaNacimiento);
                    comando.Parameters.AddWithValue("@FechaRegistro", cliente.FechaRegistro);
                    comando.Parameters.AddWithValue("@Activo", cliente.Activo);

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
        
        public List<Cliente> ObtenerClientes()
        {
            List<Cliente> listaclientes = new List<Cliente>();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT IdCliente, Identificacion,NombreCompleto,FechaNacimiento,FechaRegistro,Activo FROM Cliente";

                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Cliente cliente = new Cliente
                                {
                                 IdCliente = reader.GetInt32(0),
                                 Identificacion = reader.GetString(1),
                                 NombreCompleto = reader.GetString(2),
                                 FechaNacimiento = reader.GetDateTime(3),
                                 FechaRegistro = reader.GetDateTime(4),
                                 Activo = reader.GetBoolean(5)
                                };
                                listaclientes.Add(cliente);
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