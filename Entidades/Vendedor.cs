/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa un vendedor, que hereda de la clase Persona y agrega propiedades específicas
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
    public class Vendedor : Persona
    {
        //Atributos
        public int IdVendedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }

        // Constructor de la clase Vendedor que llama al constructor de la clase base (Persona)
        public Vendedor(string identificacion, string nombre, DateTime fechaNacimiento, DateTime fechaIngreso, string telefono)
          : base(identificacion, nombre)
        {
            FechaNacimiento = fechaNacimiento;
            FechaIngreso = fechaIngreso;
            Telefono = telefono;    
        }
            
        public Vendedor()
        {
        }
        // Sobrescribe el método ToString para mostrar el nombre completo del vendedor junto con su rol
        public override string ToString()
        {
            return NombreCompleto + " - Vendedor";
        }
        public override string ObtenerTipo()
        {
            return "Vendedor";
        }
    }
}
