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
        //Propiedades de la clase Vehiculo
        public int IdVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal Precio { get; set; }
        // 
        public int IdCategoria { get; set; }
        public CategoriaVehiculo Categoria { get; set; }
        public char Estado { get; set; }


        // constructores
        //vacio para cargar desde la base de datos
        public Vehiculo()
        {
        }
        //
        public Vehiculo(int id, string? marca, string? modelo, int ano, decimal precio, int idcategoria, char estado)
        {
            this.IdVehiculo = id;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Precio = precio;
            IdCategoria = idcategoria;
            Estado = estado;
        }

        public override string ToString()
        {
            return $"{Marca} {Modelo} ({Ano})";
        }

    }
}
