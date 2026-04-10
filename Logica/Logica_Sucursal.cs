
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Sucursal
    {
        private Acceso_Datos.Datos_Sucursal datosSucursal = new Acceso_Datos.Datos_Sucursal();
            public void registrarSucursal(Entidades.Sucursal sucursal)
            {
            
             // Validar que el objeto Sucursal no sea nulo
                if (sucursal == null)
                {
                    throw new Exception("La categoría no puede ser nula.");
                }
                // Validar que el nombre de la sucursal no esté vacío
                if (string.IsNullOrWhiteSpace(sucursal.Nombre))
                {
                    throw new Exception("El nombre de la sucursal no puede estar vacío.");
                }
                // Validar que la dirección de la sucursal no esté vacía
                if (string.IsNullOrWhiteSpace(sucursal.Direccion))
                {
                    throw new Exception("La dirección de la sucursal no puede estar vacía.");
                }
                // Validar que el teléfono de la sucursal no esté vacío
                if (string.IsNullOrWhiteSpace(sucursal.Telefono))
                {
                    throw new Exception("El teléfono de la sucursal no puede estar vacío.");
                }

                //Validar registro de surcursales no se registre más de 5
                var listaSucursales = datosSucursal.ObtenerSucursales();
               if(listaSucursales.Count >= 5)
                {
                    throw new Exception("No se pueden registrar más de 5 sucursales.");
                }
            //Insertat la sucursal en la base de datos
            datosSucursal.InsertarSucursal(sucursal);
            
             }

             // Método para actualizar una sucursal existente
             public int ObtenerSiguienteID() 
            {
              return datosSucursal.ObtenerSiguienteID();
             }
        // Método para obtener la lista de sucursales
        public List<Entidades.Sucursal> ConsultarSucursal()
         {
            try
            {
                return datosSucursal.ObtenerSucursales();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar las sucursales: " + ex.Message);
            }

        }

    }
}
