using Acceso_Datos;
using Entidades;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Logica
{
    public class Logica_VehiculoSucursal
    {
        private Datos_VehiculoSucursal datosVehiculoSucursal = new Datos_VehiculoSucursal();
        private Datos_Sucursal datosSucursal = new Datos_Sucursal();
        private Datos_Vehiculo datosVehiculo = new Datos_Vehiculo();

        public void RegistrarVehiculoSucursal(Vehiculo_Sucursal vehiculossucursal)
        {
            // 🔹 VALIDACIONES
            if (vehiculossucursal == null)
                throw new Exception("La asociación no puede ser nula.");

            if (vehiculossucursal.IdSucursal <= 0)
                throw new Exception("Seleccione una sucursal válida.");

            if (vehiculossucursal.IdVehiculo <= 0)
                throw new Exception("Seleccione un vehículo válido.");

            if (vehiculossucursal.Cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor que cero.");

            // 🔹 VALIDAR SUCURSAL
            var sucursal = datosSucursal.ObtenerPorId(vehiculossucursal.IdSucursal);
            if (sucursal == null)
                throw new Exception("La sucursal no existe.");

            if (!sucursal.Activo)
                throw new Exception("La sucursal está inactiva.");

            // 🔹 VALIDAR VEHÍCULO
            var vehiculo = datosVehiculo.ObtenerPorId(vehiculossucursal.IdVehiculo);
            if (vehiculo == null)
                throw new Exception("El vehículo no existe.");
           

            // 🔹 VERIFICAR SI YA EXISTE (CLAVE COMPUESTA)
            var existente = datosVehiculoSucursal.ObtenerPorIds(
                vehiculossucursal.IdSucursal,
                vehiculossucursal.IdVehiculo
            );

            if (existente != null)
            {
                // 🔹 ACTUALIZAR (SUMAR CANTIDAD)
                int nuevaCantidad = existente.Cantidad + vehiculossucursal.Cantidad;

                bool actualizado = datosVehiculoSucursal.ActualizarCantidad(
                    vehiculossucursal.IdSucursal,
                    vehiculossucursal.IdVehiculo,
                    nuevaCantidad
                );

                if (!actualizado)
                    throw new Exception("No se pudo actualizar la cantidad.");
            }
            else
            {
                // 🔹 INSERTAR NUEVO
                bool insertado = datosVehiculoSucursal.InsertarVehiculoSucursal(vehiculossucursal);

                if (!insertado)
                    throw new Exception("No se pudo insertar el vehículo en la sucursal.");
            }
        }
        public Sucursal ObtenerPorId(int idSucursal)
        {
            try
            {
                return datosSucursal.ObtenerPorId(idSucursal);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la lógica al obtener sucursal por Id: " + ex.Message, ex);
            }

        }
    }
}