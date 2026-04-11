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
        public string Sucursal { get; set; }
        public string  Vehiculo { get; set; }
        public int Cantidad { get; set; }

        public Vehiculo_Sucursal(string sucursal, string vehiculo, int cantidad)
        {
            Sucursal = sucursal;
            Vehiculo = vehiculo;
            Cantidad = cantidad;
        }
    }
}

