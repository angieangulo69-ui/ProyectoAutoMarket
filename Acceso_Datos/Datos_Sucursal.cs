using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Acceso_Datos
{
    public class Datos_Sucursal
    {
        private Conexion conexion = new Conexion();     
            public void InsertarSucursal(Sucursal sucursal)
            {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"INSERT INTO Sucursal 
                            (IdSucursal, Nombre, Direccion, Telefono, IdVendedor, Activo) 
                            VALUES 
                            (@IdSucursal, @Nombre, @Direccion, @Telefono, @IdVendedor, @Activo)";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSucursal", sucursal.IdSucursal);
                        cmd.Parameters.AddWithValue("@Nombre", sucursal.Nombre);
                        cmd.Parameters.AddWithValue("@Direccion", sucursal.Direccion);
                        cmd.Parameters.AddWithValue("@Telefono", sucursal.Telefono);
                        cmd.Parameters.AddWithValue("@IdVendedor", sucursal.IdVendedorEncargado);
                        cmd.Parameters.AddWithValue("@Activo", sucursal.Activo);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar sucursal: " + ex.Message);
            }
        }
           
        
        public List<Sucursal> ObtenerSucursales()
        {
            List<Sucursal> listasucursal = new List<Sucursal>();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT s.IdSucursal, s.Nombre, s.Direccion, s.Telefono, s.Activo, v.IdVendedor, v.NombreCompleto " +
                                   "FROM Sucursal s " +
                                   "LEFT JOIN Vendedor v ON s.IdVendedor = v.IdVendedor";

                    using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                
                                int id = Convert.ToInt32(reader["IdSucursal"]);
                                string nombre = reader["Nombre"].ToString();
                                string direccion = reader["Direccion"].ToString();
                                string telefono = reader["Telefono"].ToString();
                                bool activo = Convert.ToBoolean(reader["Activo"]);

                                int idVendedor = reader["IdVendedor"] != DBNull.Value
                                    ? Convert.ToInt32(reader["IdVendedor"])
                                    : 0;

                                string nombreVendedor = reader["NombreCompleto"] != DBNull.Value
                                    ? reader["NombreCompleto"].ToString()
                                    : "SIN VENDEDOR";

                                Vendedor Encargado = new Vendedor
                                {
                                    IdVendedor = idVendedor,
                                    NombreCompleto = nombreVendedor
                                };

                                listasucursal.Add(new Sucursal(id, nombre, direccion, telefono, Encargado, activo));
                               
                            }
                        }
                    }
                }
            } catch (Exception ex) 
            {
                Console.WriteLine("Error al obtener las sucursales: " + ex.Message);
            }
            return listasucursal;
        }
        public int ObtenerSiguienteID()
        {
            int siguienteId = 1; // Valor predeterminado si no hay clientes en la base de datos
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(IdSucursal),0) + 1 FROM Sucursal";
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
    


