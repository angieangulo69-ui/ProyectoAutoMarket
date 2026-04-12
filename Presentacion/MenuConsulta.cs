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
    public partial class MenuConsulta : Form
    {
        public MenuConsulta()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void MenuConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {//Llamo a la ventana de  Registrar de categoria de vehiculos
            Consulta_Categoria ConsultaCategoVehiculos = new Consulta_Categoria();
            ConsultaCategoVehiculos.Show();
            this.Close(); //Cierra la ventana actual

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de  Consulta Clientes
            Consulta_Cliente ConsultaClientes = new Consulta_Cliente();
            ConsultaClientes.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vendedor_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de  Consulta de vehiculos
            Consulta_Vendedor Consulta_Vendedores = new Consulta_Vendedor();
            Consulta_Vendedores.Show();
            this.Close(); //Cierra la ventana actual
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

        private void btn_sucursal_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de  Consulta de sucursales
            Consulta_Sucursal ConsultaSucursales = new Consulta_Sucursal();
            ConsultaSucursales.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vehiculo_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de Consulta de vehiculos
            Consulta_Vehiculo Consulta_Vehiculos = new Consulta_Vehiculo();
            Consulta_Vehiculos.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vehiculosucursal_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de  Consulta de vehiculos por sucursal
            Consulta_vehiculoxsucursal ConsultaVehiculoXSucursal = new Consulta_vehiculoxsucursal();
            ConsultaVehiculoXSucursal.Show();
            this.Close(); //Cierra la ventana actual
        }
    }
}

