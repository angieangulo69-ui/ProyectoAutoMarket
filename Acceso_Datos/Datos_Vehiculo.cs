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

        // 🔥 INSERTAR VEHÍCULO
        public void InsertarVehiculo(Vehiculo vehiculo)
        {
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"INSERT INTO Vehiculo 
                                    (IdVehiculo, Marca, Modelo, Ano, Precio, IdCategoria, Estado) 
                                    VALUES 
                                    (@IdVehiculo, @Marca, @Modelo, @Ano, @Precio, @IdCategoria, @Estado)";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdVehiculo", vehiculo.IdVehiculo);
                        cmd.Parameters.AddWithValue("@Marca", vehiculo.Marca);
                        cmd.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
                        cmd.Parameters.AddWithValue("@Ano", vehiculo.Ano);
                        cmd.Parameters.AddWithValue("@Precio", vehiculo.Precio);

                        // 🔥 CORREGIDO (ANTES ESTABA MAL)
                        cmd.Parameters.AddWithValue("@IdCategoria", vehiculo.IdCategoria);

                        cmd.Parameters.AddWithValue("@Estado", vehiculo.Estado);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar vehículo: " + ex.Message);
            }
        }

        // 🔥 OBTENER VEHÍCULOS (CON JOIN)
        public List<Vehiculo> ObtenerVehiculo()
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string query = @"SELECT v.IdVehiculo, v.Marca, v.Modelo, v.Ano, v.Precio,
                                           v.IdCategoria,
                                           c.NombreCategoria,
                                           c.Descripcion,
                                           v.Estado
                                    FROM Vehiculo v
                                    INNER JOIN CategoriaVehiculo c 
                                    ON v.IdCategoria = c.IdCategoria";

                    using (var cmd = new SqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Vehiculo v = new Vehiculo
                            {
                                IdVehiculo = Convert.ToInt32(reader["IdVehiculo"]),
                                Marca = reader["Marca"].ToString(),
                                Modelo = reader["Modelo"].ToString(),
                                Ano = Convert.ToInt32(reader["Ano"]),
                                Precio = Convert.ToDecimal(reader["Precio"]),
                                IdCategoria = Convert.ToInt32(reader["IdCategoria"]),
                                Estado = Convert.ToChar(reader["Estado"]),

                                // 🔥 RELACIÓN CON CATEGORÍA (PRO)
                                Categoria = new CategoriaVehiculo(
                                    Convert.ToInt32(reader["IdCategoria"]),
                                    reader["NombreCategoria"].ToString(),
                                    reader["Descripcion"].ToString()
                                )
                            };

                            listaVehiculos.Add(v);
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

        //  OBTENER SIGUIENTE ID
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


    


