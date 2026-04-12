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
        public int IdSucursal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public int IdVendedor { get; set; }
        public Vendedor Vendedor { get; set; }

        public bool Activo { get; set; }

        public Sucursal(int id, string nombre, string direccion, string telefono, Vendedor vendedor, bool activo)
        {
            IdSucursal = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Vendedor = vendedor;

            if (vendedor != null)
            {
                IdVendedor = vendedor.IdVendedor;
            }
            else
            {
                IdVendedor = 0; // o puedes dejarlo en null si lo cambias a int?
            }

            Activo = activo;
           

            Activo = activo;
        }

        public Sucursal() { }
    }

}



