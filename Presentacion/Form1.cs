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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void btn_registros_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de registro
            MenuRegistros registros = new MenuRegistros();
            registros.Show(); // Asegúrate de que Registros hereda de Form
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de consultas
            MenuConsulta Consultas = new MenuConsulta();
            Consultas.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }
    }
}
