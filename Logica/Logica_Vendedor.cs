using Acceso_Datos;
using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Logica
{
    public class Logica_Vendedor
    {
        private Acceso_Datos.Datos_Vendedor datosVendedor = new Datos_Vendedor();

        // Registro de vendedor
        public void RegistrarVendedor(Vendedor vendedor)
        { 

            // Validar que el vendedor no sea nulo
            if (vendedor == null)
            {
                throw new ArgumentNullException(nameof(vendedor), "El vendedor no puede ser nulo.");
            }
            // Verificar que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(vendedor.NombreCompleto) || string.IsNullOrWhiteSpace(vendedor.Identificacion))
            {
                throw new ArgumentException("Debe completar todos los espacios.");
            }
            // Verificar que el vendedor sea mayor de edad
            var edad = DateTime.Now.Year - vendedor.FechaNacimiento.Year;

            if (edad < 18)
            {
                throw new ArgumentException("Debe ser mayor de edad.");
            }
            // Verificar que la fecha de registro no sea futura
            if (vendedor.FechaIngreso > DateTime.Now)
            {
                throw new ArgumentException("La fecha de registro no puede ser futura.");
            }
            // Verificar si ya existe un vendedor con la misma identificación
            if (datosVendedor.ObtenerVendedor().Any(c => c.Identificacion == vendedor.Identificacion))
            {
                throw new ArgumentException("Ya existe un vendedor con esta identificación.");
            }
           

            datosVendedor.InsertarVendedor(vendedor);
        }

        public int ObtenerSiguienteId()
        {
            return datosVendedor.ObtenerSiguienteId();
        }

        // 
        public List<Vendedor> ConsultarVendedor()
        {
            try
            {
                return datosVendedor.ObtenerVendedor();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los vendedores: " + ex.Message);
            }
        }
    }
}
