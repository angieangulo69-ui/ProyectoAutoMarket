using Acceso_Datos;
using Entidades;
using Logica;
using Logica;
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
    public partial class Vehiculo_Sucursal : Form
    {
        private Logica_VehiculoSucursal logica = new Logica_VehiculoSucursal();
        public Vehiculo_Sucursal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;


        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.Vehiculo_Sucursal vehiculoSucursal = new Entidades.Vehiculo_Sucursal();

                vehiculoSucursal.IdSucursal = Convert.ToInt32(comboBox_idsucursal.SelectedValue);
                vehiculoSucursal.IdVehiculo = Convert.ToInt32(comboBox_idvehiculo.SelectedValue);
                vehiculoSucursal.Cantidad = int.Parse(txt_cantidad.Text);

                logica.RegistrarVehiculoSucursal(vehiculoSucursal);

                MessageBox.Show("Registro exitoso");

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Vehiculo_Sucursal_Load(object sender, EventArgs e)
        {
            CargarSucursales();
            CargarVehiculos();
        }

        private void comboBox_idsucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_idvehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void data_sucursalxVehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarCampos()
        {
            comboBox_idsucursal.SelectedIndex = 0;
            comboBox_idvehiculo.SelectedIndex = 0;
            txt_cantidad.Clear();
        }
        private void CargarSucursales()
        {
            Datos_Sucursal datos = new Datos_Sucursal();
            var lista = datos.ObtenerSucursales();

            comboBox_idsucursal.DataSource = lista;
            comboBox_idsucursal.DisplayMember = "Nombre";
            comboBox_idsucursal.ValueMember = "IdSucursal";
        }
        private void CargarVehiculos()
        {
            Datos_Vehiculo datos = new Datos_Vehiculo();
            var lista = datos.ObtenerVehiculo();

            comboBox_idvehiculo.DataSource = lista;
            comboBox_idvehiculo.DisplayMember = "Modelo"; // o Marca si prefieres
            comboBox_idvehiculo.ValueMember = "IdVehiculo";
        }
    }
}
