using Acceso_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Acceso_Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class Logica_VehiculoSucursal
    {
        private Datos_VehiculoSucursal datos;
        public Logica_VehiculoSucursal()
        {
            datos = new Datos_VehiculoSucursal();
        }
        public void RegistrarVehiculoSucursal(Vehiculo_Sucursal vehiculossucursal)
        {
            if (vehiculossucursal == null)
                throw new Exception("Objeto vacío");

            if (vehiculossucursal.Sucursal == null)
                throw new Exception("Sucursal requerida");

            if (vehiculossucursal.Vehiculo == null)
                throw new Exception("Vehículo requerido");

            if (vehiculossucursal.Cantidad <= 0)
                throw new Exception("Cantidad inválida");

            // 🔥 VALIDACIÓN DESDE BD (correcto)
            Datos_Sucursal datosSucursal = new Datos_Sucursal();

            var sucursal = datosSucursal.ObtenerPorId(
                vehiculossucursal.Sucursal.IdSucursal
            );

            if (sucursal == null)
                throw new Exception("Sucursal no existe");

            if (!sucursal.Activo)
                throw new Exception("No se pueden asignar vehículos a sucursales inactivas");

            // 🔥 INSERT EN BD
            datos.InsertarVehiculoSucursal(vehiculossucursal);
        }
    }
}
