using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunicacion
{
    public class Mensaje
    {
        public string Accion { get; set; }
        public string Tipo { get; set; }
        public string Datos { get; set; }
       
      
        public Mensaje()
        {
            Accion = string.Empty;
            Datos = string.Empty;
            Tipo = string.Empty;
        }
    public Mensaje (string accion, string tipo ,string datos)
        {
            Accion = accion;
            Datos = datos;
            Tipo = tipo;
        }
    }
}
