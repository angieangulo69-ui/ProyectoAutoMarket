/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa una sucursal, con propiedades para el ID, 
nombre, dirección, teléfono, vendedor encargado y estado (activo o inactivo).
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
    public class Sucursal
    {
        private static int idcontador = 1; //ID automatico

        //Propiedades de la clase Sucursal
        public int IdSucursal { get; private set; }

        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Vendedor VendedorEncargado { get; set; } // Relación con la clase Vendedor, cada sucursal
                                                        // tiene un vendedor encargado
        public bool Activo { get; set; }
        //Constructor de la clase Sucursal para inicializar las propiedades
        public Sucursal(string nombre, string direccion, string telefono, Vendedor vendedorEncargado, bool activo)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre de la sucursal es obligatorio.");
            IdSucursal = idcontador++;

            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            VendedorEncargado = vendedorEncargado;
            Activo = activo;
        }
        public override string ToString()
        {
            return Nombre;
        }
        public static int ObtenerSiguienteId()
        {
            return idcontador;
        }


    }

}

