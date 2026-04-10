using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Logica_Cliente
    {
       private Acceso_Datos.Datos_Cliente datosCliente = new Acceso_Datos.Datos_Cliente();

        public void RegistrarCliente(Entidades.Cliente cliente)
        {
           
               // Validar que el cliente no sea nulo
                if (cliente == null)
                {
                    throw new ArgumentNullException(nameof(cliente), "El cliente no puede ser nulo.");
                }
                // Verificar que los campos obligatorios no estén vacíos
                if (string.IsNullOrWhiteSpace(cliente.NombreCompleto) || string.IsNullOrWhiteSpace(cliente.Identificacion))
                {
                    throw new ArgumentException("Debe completar todos los espacios.");
                }
                // Verificar que el cliente sea mayor de edad
                var edad = DateTime.Now.Year - cliente.FechaNacimiento.Year;
               
                if (edad < 18)
                {
                    throw new ArgumentException("Debe ser mayor de edad.");
                }
                // Verificar que la fecha de registro no sea futura
                if (cliente.FechaRegistro > DateTime.Now)
                {
                    throw new ArgumentException("La fecha de registro no puede ser futura.");
                }
                // Verificar si ya existe un cliente con la misma identificación
                if (datosCliente.ObtenerClientes().Any(c => c.Identificacion == cliente.Identificacion))
                {
                    throw new ArgumentException("Ya existe un cliente con esta identificación.");
                }

                datosCliente.InsertarCliente(cliente);                          
        }
            
        
        // Método para obtener el siguiente ID disponible para un nuevo cliente.
        public int ObtenerSiguienteId()
        {            
            return datosCliente.ObtenerSiguienteId();
        }
        // Consulta todos los clientes
        public List<Entidades.Cliente> ConsultarCliente()
        {
            try
            {
                return datosCliente.ObtenerClientes();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cosnultar el cliente" + ex.Message);
            }
        }
    }
}
