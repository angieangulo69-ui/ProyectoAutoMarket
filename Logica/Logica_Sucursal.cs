using Entidades;
using Acceso_Datos;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class Logica_Sucursal
    {
        private Datos_Sucursal datosSucursal = new Datos_Sucursal();

        // Insertar con validaciones
        public bool InsertarSucursal(Sucursal sucursal)
        {
            if (string.IsNullOrWhiteSpace(sucursal.Nombre))
                throw new Exception("El nombre de la sucursal es obligatorio.");

            if (string.IsNullOrWhiteSpace(sucursal.Direccion))
                throw new Exception("La dirección es obligatoria.");

            if (string.IsNullOrWhiteSpace(sucursal.Telefono))
                throw new Exception("El teléfono es obligatorio.");

            if (sucursal.IdVendedor <= 0)
                throw new Exception("Debe asignar un vendedor encargado válido.");

            // Regla: máximo 5 sucursales
            var lista = datosSucursal.ObtenerSucursales();
            if (lista.Count >= 5)
                throw new Exception("No se pueden registrar más de 5 sucursales.");

            return datosSucursal.InsertarSucursal(sucursal);
        }

        // Obtener todas las sucursales
        public List<Sucursal> ObtenerSucursales()
        {
            return datosSucursal.ObtenerSucursales();
        }

        // Obtener una sucursal por ID
        public Sucursal ObtenerPorId(int idSucursal)
        {
            if (idSucursal <= 0)
                throw new Exception("El ID de la sucursal no es válido.");

            return datosSucursal.ObtenerPorId(idSucursal);
        }

        // Obtener siguiente ID
        public int ObtenerSiguienteId()
        {
            return datosSucursal.ObtenerSiguienteId();
        }
    }
}
