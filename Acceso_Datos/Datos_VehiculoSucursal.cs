using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Datos_VehiculoSucursal
    {

        public class Datos_Cliente
        {// Clase para gestionar el acceso a datos de los clientes, utilizando una instancia de la clase Conexion para interactuar con la base de datos.
            private Conexion conexion = new Conexion();

            public void InsertarVehiculoSucursal(Vehiculo_Sucursal vehiculoSucursal)
            {
                try
                {
                    using (var conn = conexion.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "INSERT INTO VehiculoxSucursal (IdSucursal, IdVehiculo, Cantidad) " +
                                       "VALUES (@IdSucursal, @IdVehiculo, @Cantidad)";
                        // Se utiliza un comando SQL parametrizado para evitar inyecciones SQL y asegurar la integridad de los datos.
                        using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@IdSucursal", vehiculoSucursal.Sucursal);
                            cmd.Parameters.AddWithValue("@IdVehiculo", vehiculoSucursal.Vehiculo);
                            cmd.Parameters.AddWithValue("@Cantidad", vehiculoSucursal.Cantidad);

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

            public List<Vehiculo_Sucursal> ObtenerVehiculoSucursal()
            {
                List<Vehiculo_Sucursal> listaVehiculoxSucursal = new List<Vehiculo_Sucursal>();
                {

                    try
                    {
                        using (var conn = conexion.ObtenerConexion())
                        {
                            conn.Open();
                            string query = "SELECT IdSucursal, IdVehiculo, Cantidad FROM VehiculoxSucursal";

                            using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                            {
                                using (var reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string idSucursal = reader["IdSucursal"].ToString();
                                        string idVehiculo = reader["IdVehiculo"].ToString();
                                        int cantidad = Convert.ToInt32(reader["Cantidad"]);

                                        listaVehiculoxSucursal.Add(new Vehiculo_Sucursal(idSucursal, idVehiculo, cantidad));
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener vehículos por sucursal: " + ex.Message, ex);
                    }
                }
                return listaVehiculoxSucursal;
            }
            public int ObtenerSiguienteId()
            {
                int siguienteId = 1; // Valor predeterminado si no hay clientes en la base de datos
                try
                {
                    using (var conn = conexion.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "SELECT ISNULL(MAX(IdVehiculoSucursal),0) + 1 FROM VehiculoxSucursal";
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            siguienteId = Convert.ToInt32(cmd.ExecuteScalar());

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar la asociación : " + ex.Message, ex);
                }
                return siguienteId;
            }
        }
    }
}
