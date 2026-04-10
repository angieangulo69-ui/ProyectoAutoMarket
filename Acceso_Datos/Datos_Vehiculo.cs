using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Datos_Vehiculo
    {
       
        // Clase para gestionar el acceso a datos de los Vehiculo, utilizando una instancia de la clase Conexion para interactuar con la base de datos.
            private Conexion conexion = new Conexion();
            public void InsertarVehiculo(Vehiculo vehiculo)
            {
                try
                {
                    using (var conn = conexion.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "INSERT INTO Vehiculo (IdVehiculo,Marca, Modelo, Ano, Precio, IdCategoria, Estado) " +
                                       "VALUES (@IdVehiculo,@Marca, @Modelo, @Ano, @Precio, @IdCategoria, @Estado)";
                        // Se utiliza un comando SQL parametrizado para evitar inyecciones SQL y asegurar la integridad de los datos.
                        using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@IdVehiculo", vehiculo.IdVehiculo);
                            cmd.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                            cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                            cmd.Parameters.AddWithValue("@Ano", vehiculo.Ano);
                            cmd.Parameters.AddWithValue("@Precio", vehiculo.Precio);
                            cmd.Parameters.AddWithValue("@IdCategoria", vehiculo.Categoria);
                            cmd.Parameters.AddWithValue("@Estado", vehiculo.Estado);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores, por ejemplo, registrar el error o mostrar un mensaje
                    Console.WriteLine("Error al insertar Vehiculo: " + ex.Message);
                }
            }
            public List<Vehiculo> ObtenerVehiculo()
            {
                List<Vehiculo> listaVehiculos = new List<Vehiculo>();
                try
                {
                    using (var conn = conexion.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "SELECT * FROM Vehiculo";

                        using (var cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                        {
                            using (var reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int id = Convert.ToInt32(reader["IdVehiculo"]);
                                    string marca = reader["Marca"].ToString();
                                    string modelo = reader["Modelo"].ToString();
                                    int ano = Convert.ToInt32(reader["Ano"]);
                                    decimal precio = Convert.ToDecimal(reader["Precio"]);
                                    int idCategoria = Convert.ToInt32(reader["IdCategoria"]);
                                    char estado = Convert.ToChar(reader["Estado"]);

                                    listaVehiculos.Add(new Vehiculo(id, marca, modelo, ano, precio, idCategoria, estado));
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener vehículos: " + ex.Message, ex);
                }
                return listaVehiculos;
            }
            //
            public int ObtenerSiguienteId()
            {
                int siguienteId = 1; // Valor predeterminado si no hay vehículos en la base de datos
                try
                {
                    using (var conn = conexion.ObtenerConexion())
                    {
                        conn.Open();
                        string query = "SELECT ISNULL(MAX(IdVehiculo),0) + 1 FROM Vehiculo";
                        using (var cmd = new SqlCommand(query, conn))
                        {
                            siguienteId = Convert.ToInt32(cmd.ExecuteScalar());

                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el siguiente ID de vehículo: " + ex.Message, ex);
                }
                return siguienteId;
            }
        }

    }


