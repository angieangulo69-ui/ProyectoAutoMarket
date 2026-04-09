/*
Universidad: UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa un vehículo, con propiedades para el ID,
marca, modelo, año, precio, categoría y estado (nuevo o usado).
Estudiante: Angie Angulo Chacon 
Fecha:22/02/2026
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        private static int contadorId = 1;
        //Propiedades de la clase Vehiculo
        public int IdVehiculo { get; private set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Precio { get; set; }
        public CategoriaVehiculo Categoria { get; set; }
        public char Estado { get; set; }

        //Constructor de la clase Vehiculo para inicializar las propiedades, con validación para el estado
        public Vehiculo(string marca, string modelo, int anio,
                        decimal precio, CategoriaVehiculo categoria, char estado)
        {
            if (estado != 'N' && estado != 'U')
                throw new ArgumentException("Estado inválido. Debe ser 'N' (Nuevo) o 'U' (Usado).");

            IdVehiculo = contadorId++;
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Precio = precio;
            Categoria = categoria;
            Estado = estado;
        }
        //Sobrescribe el método ToString para mostrar la marca, modelo y año del vehículo
        public static int ObtenerSiguienteId()
        {
            return contadorId;
        }

        public override string ToString()
        {
            return Marca + " " + Modelo + " (" + Anio + ")";
        }
    }

}

