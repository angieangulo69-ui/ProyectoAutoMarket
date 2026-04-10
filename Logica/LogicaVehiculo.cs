using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LogicaVehiculo
    {
        private Acceso_Datos.Datos_Vehiculo datosVehiculo = new Acceso_Datos.Datos_Vehiculo();

        public void RegistrarVehiculo(Entidades.Vehiculo vehiculo)
        {

            // Validar que el vehiculo no sea nulo
            if (vehiculo == null)
            {
                throw new ArgumentNullException(nameof(vehiculo), "El vehiculo no puede ser nulo.");
            }
            // Verificar que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(vehiculo.Marca) || string.IsNullOrWhiteSpace(vehiculo.Modelo))
            {
                throw new ArgumentException("Debe completar todos los espacios.");
            }

            datosVehiculo.InsertarVehiculo(vehiculo);
        }


        // Método para obtener el siguiente ID disponible para un nuevo vehiculo.
        public int ObtenerSiguienteId()
        {
            return datosVehiculo.ObtenerSiguienteId();
        }
        // Consulta todos los vehiculos
        public List<Entidades.Vehiculo> ConsultarVehiculo()
        {
            try
            {
                return datosVehiculo.ObtenerVehiculo();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cosultar el Vehiculo" + ex.Message);
            }
        }
    }
}

