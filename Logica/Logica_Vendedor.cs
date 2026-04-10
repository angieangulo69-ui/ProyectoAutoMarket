using Acceso_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Vendedor
    {
        private Acceso_Datos.Datos_Vendedor datosVendedor = new Acceso_Datos.Datos_Vendedor();

        public void RegistrarVendedor(Entidades.Vendedor vendedor)
        {

            // Validar que el cliente no sea nulo
            if (vendedor == null)
            {
                throw new ArgumentNullException(nameof(vendedor), "El cliente no puede ser nulo.");
            }
            // Verificar que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(vendedor.NombreCompleto) || string.IsNullOrWhiteSpace(vendedor.Identificacion))
            {
                throw new ArgumentException("Debe completar todos los espacios.");
            }
            // Verificar que el cliente sea mayor de edad
            var edad = DateTime.Now.Year - vendedor.FechaNacimiento.Year;

            if (edad < 18)
            {
                throw new ArgumentException("Debe ser mayor de edad.");
            }
            // Verificar que la fecha de registro no sea futura
            if (vendedor.FechaIngreso > DateTime.Now)
            {
                throw new ArgumentException("La fecha de ingreso no puede ser futura.");
            }
            // Verificar si ya existe un vendedor con la misma identificación
            if (datosVendedor.ObtenerVendedor().Any(c => c.Identificacion == vendedor.Identificacion))
            {
                throw new ArgumentException("Ya existe un vendedor con esta identificación.");
            }
            // Validar que no se registren más de 20 categorías de vehículos
            var listaregistros = datosVendedor.ObtenerVendedor();
            if (listaregistros.Count >= 20) //count me cuenta los registros que hay en la base de datos, si es mayor o igual a 20 no se pueden registrar más categorías
            {
                throw new Exception("No se pueden registrar más de 20 categorías de vehículos.");
            }

            datosVendedor.InsertarVendedor(vendedor);
        }


        // Método para obtener el siguiente ID disponible para un nuevo cliente.
        public int ObtenerSiguienteId()
        {
            return datosVendedor.ObtenerSiguienteId();
        }
        // Consulta todos los vendedores
        public List<Entidades.Vendedor> ConsultarVendedor()
        {
            try
            {
                return datosVendedor.ObtenerVendedor();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el vendedor" + ex.Message);
            }
        }
    }

}

