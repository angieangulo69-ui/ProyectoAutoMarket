/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa una categoría de vehículo, con propiedades para el ID, nombre 
y descripción de la categoría. Incluye un constructor para inicializar estas propiedades y un 
método ToString para mostrar la información de la categoría de manera legible.
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
    public class CategoriaVehiculo
    {       
            private static int contadorId = 1;

            //atributos de la clase
            public int IdCategoria { get; set; }
            public string NombreCategoria { get; set; }
            public string Descripcion { get; set; }

        //Constructor de la clase
        public CategoriaVehiculo(int id,string nombre, string descripcion)
            {
                //Constructor de la clase
                IdCategoria = contadorId++;
                NombreCategoria = nombre;
                Descripcion = descripcion;
            }
        //sobrecarga del constructor para no tener que pasar el id al crear una nueva categoría, el id se asigna automáticamente
        public CategoriaVehiculo(string nombre, string descripcion)
        { 
                IdCategoria = contadorId++;
                NombreCategoria = nombre;
                Descripcion = descripcion;
        }
           public static int ObtenerSiguienteId()
           { 
                return contadorId;
        }

            public override string ToString()
            {
                return NombreCategoria;
            }
        }
    }



