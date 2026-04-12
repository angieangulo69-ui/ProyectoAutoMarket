using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Acceso_Datos
{
    public class Datos_VehiculoSucursal
    {
        private Conexion conexion = new Conexion();

        // 🔹 INSERTAR
        public bool InsertarVehiculoSucursal(Vehiculo_Sucursal vehiculoSucursal)
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"INSERT INTO VehiculoxSucursal 
                                     (IdSucursal, IdVehiculo, Cantidad)
                                     VALUES (@IdSucursal, @IdVehiculo, @Cantidad)";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSucursal", vehiculoSucursal.IdSucursal);
                        cmd.Parameters.AddWithValue("@IdVehiculo", vehiculoSucursal.IdVehiculo);
                        cmd.Parameters.AddWithValue("@Cantidad", vehiculoSucursal.Cantidad);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar vehículo en sucursal: " + ex.Message);
                return false;
            }
        }

        // 🔹 OBTENER TODOS
        public List<Vehiculo_Sucursal> ObtenerVehiculoSucursal()
        {
            var lista = new List<Vehiculo_Sucursal>();

            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = "SELECT IdSucursal, IdVehiculo, Cantidad FROM VehiculoxSucursal";

                    using (var cmd = new SqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Vehiculo_Sucursal
                            {
                                IdSucursal = reader.GetInt32(0),
                                IdVehiculo = reader.GetInt32(1),
                                Cantidad = reader.GetInt32(2)
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vehículos por sucursal: " + ex.Message);
            }

            return lista;
        }

        // 🔹 ACTUALIZAR CANTIDAD (CLAVE COMPUESTA)
        public bool ActualizarCantidad(int idSucursal, int idVehiculo, int nuevaCantidad)
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"UPDATE VehiculoxSucursal 
                                     SET Cantidad = @Cantidad 
                                     WHERE IdSucursal = @IdSucursal 
                                     AND IdVehiculo = @IdVehiculo";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cantidad", nuevaCantidad);
                        cmd.Parameters.AddWithValue("@IdSucursal", idSucursal);
                        cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar cantidad: " + ex.Message);
            }
        }

        // 🔹 VERIFICAR SI YA EXISTE (MUY ÚTIL)
        public Vehiculo_Sucursal ObtenerPorIds(int idSucursal, int idVehiculo)
        {
            Vehiculo_Sucursal vehiculo = null;

            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"SELECT IdSucursal, IdVehiculo, Cantidad 
                                     FROM VehiculoxSucursal
                                     WHERE IdSucursal = @IdSucursal 
                                     AND IdVehiculo = @IdVehiculo";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdSucursal", idSucursal);
                        cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                vehiculo = new Vehiculo_Sucursal
                                {
                                    IdSucursal = reader.GetInt32(0),
                                    IdVehiculo = reader.GetInt32(1),
                                    Cantidad = reader.GetInt32(2)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar vehículo en sucursal: " + ex.Message);
            }
            return vehiculo;
        }
    }
}