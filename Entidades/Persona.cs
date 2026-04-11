/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa una persona, con propiedades para el ID, 
identificación, nombre completo y fecha de nacimiento.
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
    public class Persona
    {
        private static int contadorId = 1; // Contador estático para generar IDs únicos automáticamente 
        //Propiedades de la clase Persona
        public int Id { get; private set; } // get porque puuedo leer desde cualquier parte del programa, pero set es
                                            // privado porque solo se puede asignar dentro de la clase Persona
        public string Identificacion { get; set; }
        public string NombreCompleto { get; set; }

        //Constructor de la clase Persona para inicializar las propiedades
        public Persona(string identificacion, string nombre)
        {    //valida si el campo de identificación está vacío o solo contiene espacios en blanco
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio.");

            Id = contadorId++;
            Identificacion = identificacion;
            NombreCompleto = nombre;

        }
        public Persona()
        {
        }

        //Sobrescribe el método ToString para mostrar el nombre completo de la persona
        public override string ToString()
        {
            return $"{NombreCompleto}({ Identificacion})";
        }
        public virtual string ObtenerTipo()
        {
            return "Persona";
        }
        public static int ObtenerSiguienteId()
        {
            return contadorId;
        }
    }
}

