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
            RegistroCategoVehiculos RegistroCategoVehiculos = new RegistroCategoVehiculos();
            RegistroCategoVehiculos.Show();
            this.Close(); //Cierra la ventana actual

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de  Registrar Clientes
            RegistroCliente RegistroClientes = new RegistroCliente();
            RegistroClientes.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vendedor_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de  Registrar de vehiculos
            Registro_Vendedor Registro_Vendedores = new Registro_Vendedor();
            Registro_Vendedores.Show();
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
            // Llamo a la ventana de  Registrarde sucursales
            RegistroSucursal Registrar_Sucursales = new RegistroSucursal();
            Registrar_Sucursales.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vehiculo_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de Registrar de vehiculos
            RegistroVehiculo Registro_Vehiculos = new RegistroVehiculo();
            Registro_Vehiculos.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_vehiculosucursal_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de  Registrar de sucursales
            Vehiculo_Sucursal Registrar_Vehiculo_Sucursal = new Vehiculo_Sucursal();
            Registrar_Vehiculo_Sucursal.Show();
            this.Close(); //Cierra la ventana actual
        }
    }
}

