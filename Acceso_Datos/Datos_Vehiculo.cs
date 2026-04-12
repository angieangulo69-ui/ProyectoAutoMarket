using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_Datos
{
    public class Datos_Vehiculo
    {
        private Conexion conexion = new Conexion();

        // 
        public bool InsertarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"INSERT INTO Vehiculo (IdVehiculo, Marca, Modelo, Ano, Precio, IdCategoria, Estado) 
                                    VALUES  (@IdVehiculo, @Marca, @Modelo, @Ano, @Precio, @IdCategoria, @Estado)";

                    using (var comando = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        comando.Parameters.AddWithValue("@IdVehiculo", vehiculo.IdVehiculo);
                        comando.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                        comando.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                        comando.Parameters.AddWithValue("@Ano", vehiculo.Ano);
                        comando.Parameters.AddWithValue("@Precio", vehiculo.Precio);                       
                        comando.Parameters.AddWithValue("@IdCategoria", vehiculo.IdCategoria);
                        comando.Parameters.AddWithValue("@Estado", vehiculo.Estado);

                        int filasafectadas = comando.ExecuteNonQuery();
                        if (filasafectadas == 1)
                        {
                            return true;
                        }
                        else
                        {
                            throw new Exception("No se pudo insertar el vehículo.");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar vehículo: " + ex.Message);
                return false;
            }
        }

        // 
        public List<Vehiculo> ObtenerVehiculo()
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"SELECT v.IdVehiculo, v.Marca, v.Modelo, v.Ano, v.Precio, v.IdCategoria,c.NombreCategoria,c.Descripcion, v.Estado 
                                     FROM Vehiculo v INNER JOIN CategoriaVehiculo c  ON v.IdCategoria = c.IdCategoria";

                    using (SqlCommand comando = new SqlCommand(query, conn))

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vehiculo vehiculo = new Vehiculo
                            {
                                IdVehiculo = reader.GetInt32(0),
                                Marca = reader.GetString(1),
                                Modelo = reader.GetString(2),
                                Ano = reader.GetInt32(3),
                                Precio = reader.GetDecimal(4),
                                IdCategoria = reader.GetInt32(5),
                                Estado = reader.GetString(8)[0],

                                // 
                                Categoria = new CategoriaVehiculo(
                                    reader.GetInt32(5),
                                    reader.GetString(6),
                                    reader.GetString(7)
                                )
                            };

                            listaVehiculos.Add(vehiculo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vehículos: " + ex.Message);
            }

            return listaVehiculos;
        }
        public Vehiculo ObtenerPorId(int idVehiculo)
        {
            Vehiculo vehiculo = null;

            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"SELECT v.IdVehiculo, v.Marca, v.Modelo, v.Ano, v.Precio, 
                                    v.IdCategoria, c.NombreCategoria, c.Descripcion, v.Estado 
                             FROM Vehiculo v 
                             INNER JOIN CategoriaVehiculo c ON v.IdCategoria = c.IdCategoria
                             WHERE v.IdVehiculo = @Id";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", idVehiculo);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                vehiculo = new Vehiculo
                                {
                                    IdVehiculo = reader.GetInt32(0),
                                    Marca = reader.GetString(1),
                                    Modelo = reader.GetString(2),
                                    Ano = reader.GetInt32(3),
                                    Precio = reader.GetDecimal(4),
                                    IdCategoria = reader.GetInt32(5),
                                    Estado = reader.GetString(8)[0],

                                    Categoria = new CategoriaVehiculo(
                                        reader.GetInt32(5),
                                        reader.GetString(6),
                                        reader.GetString(7)
                                    )
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener vehículo: " + ex.Message);
            }
            return vehiculo;
        }

        //  
        public int ObtenerSiguienteId()
        {
            int siguienteId = 1;

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
                throw new Exception("Error al obtener el siguiente ID: " + ex.Message);
            }

            return siguienteId;
        }
    }
}   


    


