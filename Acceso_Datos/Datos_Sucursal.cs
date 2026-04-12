using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class Datos_Sucursal
    {
        private Conexion conexion = new Conexion();

        // Insertar nueva sucursal
        public bool InsertarSucursal(Sucursal sucursal)
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"INSERT INTO Sucursal (IdSucursal, Nombre, Direccion, Telefono, IdVendedor, Activo) 
                                     VALUES (@IdSucursal, @Nombre, @Direccion, @Telefono, @IdVendedor, @Activo)";

                    using (SqlCommand comando = new SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@IdSucursal", sucursal.IdSucursal);
                        comando.Parameters.AddWithValue("@Nombre", sucursal.Nombre);
                        comando.Parameters.AddWithValue("@Direccion", sucursal.Direccion);
                        comando.Parameters.AddWithValue("@Telefono", sucursal.Telefono);
                        comando.Parameters.AddWithValue("@IdVendedor", sucursal.IdVendedor);
                        comando.Parameters.AddWithValue("@Activo", sucursal.Activo);

                        int filasafectadas = comando.ExecuteNonQuery();
                        if (filasafectadas == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar sucursal: " + ex.Message);
            }
        }

        // Obtener lista de sucursales (máximo 5)
        public List<Sucursal> ObtenerSucursales()
        {
            List<Sucursal> lista = new List<Sucursal>();

            using (var conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT s.IdSucursal, s.Nombre, s.Direccion, s.Telefono,
                                s.IdVendedor, v.IdVendedor, v.NombreCompleto, s.Activo
                         FROM Sucursal s
                         LEFT JOIN Vendedor v ON s.IdVendedor = v.IdVendedor";

                using (SqlCommand comando = new SqlCommand(query, conn))
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Vendedor vendedor = new Vendedor
                        {
                            IdVendedor = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                            NombreCompleto = reader.IsDBNull(6) ? "SIN VENDEDOR" : reader.GetString(6)
                        };

                        Sucursal sucursal = new Sucursal
                        {
                            IdSucursal = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Direccion = reader.GetString(2),
                            Telefono = reader.IsDBNull(3) ? "" : reader.GetString(3),
                            IdVendedor = reader.GetInt32(4), // aquí usamos la columna real IdVendedor
                            Vendedor = vendedor,
                            Activo = reader.GetBoolean(7)
                        };

                        lista.Add(sucursal);
                    }
                }
            }

            return lista;
        }

        // Obtener sucursal por ID
        public Sucursal ObtenerPorId(int idSucursal)
        {
            Sucursal sucursal = null;

            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"SELECT s.IdSucursal, s.Nombre, s.Direccion, s.Telefono, 
                                            s.IdVendedorEncargado, v.IdVendedor, v.Nombre AS NombreVendedor, s.Activo
                                     FROM Sucursal s
                                     INNER JOIN Vendedor v ON s.IdVendedor = v.IdVendedor
                                     WHERE s.IdSucursal = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", idSucursal);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Vendedor vendedor = new Vendedor
                                {
                                    IdVendedor = reader.GetInt32(5),
                                    NombreCompleto = reader.GetString(6)
                                };

                                sucursal = new Sucursal
                                {
                                    IdSucursal = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Direccion = reader.GetString(2),
                                    Telefono = reader.GetString(3),
                                    IdVendedor = reader.GetInt32(4),
                                    Vendedor = vendedor,
                                    Activo = reader.GetBoolean(7)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener sucursal: " + ex.Message);
            }

            return sucursal;
        }

        // Obtener siguiente ID
        public int ObtenerSiguienteId()
        {
            int siguienteId = 1;

            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = "SELECT ISNULL(MAX(IdSucursal),0) + 1 FROM Sucursal";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        siguienteId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el siguiente ID: " + ex.Message);
            }

            return siguienteId;
        }

        public IDisposable ObtenerConexionParaDepuracion()
        {
            throw new NotImplementedException();
        }
    }
}
