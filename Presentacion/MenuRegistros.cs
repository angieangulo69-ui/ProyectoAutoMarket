using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class MenuRegistros : Form
    {
        public MenuRegistros()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }
        private void btn_atras_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana principal del menu
            Form1 Menu = new Form1();
            Menu.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de  Registrar de categoria de vehiculos
            RegistroCategoVehiculos RegistroCategoVehiculos = new RegistroCategoVehiculos();
            RegistroCategoVehiculos.Show();
            this.Close(); //Cierra la ventana actual
        }
    }
}
