/*
Universidad:UNED
I Cuatrimestre
Proyecto: AutoMarket
Descripción: Clase que representa un cliente, con propiedades para el ID, identificación, 
nombre completo, fecha de nacimiento, fecha de registro y estado activo. Incluye un constructor 
para inicializar estas propiedades y un método ToString para mostrar la informacióndel cliente 
de manera legible. Esta clase se utilizará para gestionar los clientes del sistema,
con validaciones para campos vacíos, ID único y límite de registros.
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
    public class Cliente : Persona
    { //Propiedades de la clase Cliente, heredando de Persona
        public int IdCliente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
 
        //Constructor de la clase Cliente, llamando al constructor de la clase
        //base Persona para inicializar las propiedades heredadas
        public Cliente(string identificacion, string nombre, DateTime fechaNacimiento, DateTime fechaRegistro, bool activo)
            : base(identificacion, nombre)
        {
            FechaNacimiento = fechaNacimiento;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }
        public Cliente(int idcliente,string identificacion, string nombre, DateTime fechaNacimiento, DateTime fechaRegistro, bool activo)
            : base(identificacion, nombre)
        {
            IdCliente = idcliente;
            FechaNacimiento = fechaNacimiento;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }

        public Cliente()
        {
        }

        //Sobrescribe el método ToString para mostrar el nombre completo y el estado del cliente
        public override string ToString()
        {
            return NombreCompleto + " - Cliente";
        }
      
        public override string ObtenerTipo()
        {
            return "Cliente";
        }

    }

}

