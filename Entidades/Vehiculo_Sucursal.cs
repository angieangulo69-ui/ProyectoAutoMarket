/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción:Clase que representa la relación entre vehículos y 
sucursales, indicando la cantidad de cada vehículo disponible en 
cada sucursal. Esta clase es fundamental para gestionar el inventario 
de vehículos en las diferentes sucursales de AutoMarket, permitiendo una mejor 
organización y control de los recursos disponibles.
Estudiante: Angie Angulo Chacón 
Fecha:22/02/2026
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo_Sucursal
    {      
            public Sucursal Sucursal { get; set; }
            public Vehiculo Vehiculo { get; set; }
            public int Cantidad { get; set; }

            public Vehiculo_Sucursal(Sucursal sucursal, Vehiculo vehiculo, int cantidad)
            {   //valida que  no se usen sucursales inactivas y que la cantidad sea mayor que cero
                if (!sucursal.Activo)
                    throw new ArgumentException("No se pueden asociar vehículos a sucursales inactivas.");

                if (cantidad <= 0)
                    throw new ArgumentException("La cantidad debe ser mayor que cero.");

                Sucursal = sucursal;
                Vehiculo = vehiculo;
                Cantidad = cantidad;
            }
        }
    }

