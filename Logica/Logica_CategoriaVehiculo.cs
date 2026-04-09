using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logica
{
    public class Logica_CategoriaVehiculo
    {
        private Acceso_Datos.Datos_CategoriaVehiculo datosCategoria = new Acceso_Datos.Datos_CategoriaVehiculo();

        //REgistrar una nueva categoría de vehículo
        public void RegistrarCategoria(Entidades.CategoriaVehiculo categoria) //categoria viende de la capa de logica
        {
            try
            {   // Validar que la categoría no sea nula
                if (categoria == null)
                {
                    throw new Exception("La categoría no puede ser nula.");
                }
                // Validar que el nombre de la categoría no esté vacío
                if (string.IsNullOrWhiteSpace(categoria.NombreCategoria))
                {
                    throw new Exception("El nombre de la categoría no puede estar vacío.");
                }
                // Validar que la descripción no esté vacía
                if (string.IsNullOrWhiteSpace(categoria.Descripcion))
                {
                    throw new Exception("La descripción de la categoría no puede estar vacía.");
                }

                // Validar que no se registren más de 20 categorías de vehículos
                var listaregistros = datosCategoria.ObtenerCategorias();
                if (listaregistros.Count >= 20) //count me cuenta los registros que hay en la base de datos, si es mayor o igual a 20 no se pueden registrar más categorías
                {
                    throw new Exception("No se pueden registrar más de 20 categorías de vehículos.");
                }
                //insertar la categoría en la base de datos
                datosCategoria.InsertarCategoria(categoria);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar la categoría de vehículo: " + ex.Message);
            }
        }
        public int ObtenerSiguienteId()
        {
            return datosCategoria.ObtenerSiguienteId();
        }

        //consultar todas las categorías de vehículos
        public List<Entidades.CategoriaVehiculo> ConsultarCategorias()
        {
            try
            {
                return datosCategoria.ObtenerCategorias();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar las categorías de vehículos: " + ex.Message);
            }
        }
    }
}
