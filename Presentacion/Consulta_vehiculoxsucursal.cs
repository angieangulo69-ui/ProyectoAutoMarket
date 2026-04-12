using Acceso_Datos;
using Entidades;
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
    public partial class Consulta_vehiculoxsucursal : Form
    {
        private Datos_VehiculoSucursal datosVS = new Datos_VehiculoSucursal();
        private Datos_Sucursal datosSucursal = new Datos_Sucursal();
        public Consulta_vehiculoxsucursal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void comboBox_idsucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_idsucursal.SelectedValue == null)
                    return;

                int idSucursal = Convert.ToInt32(comboBox_idsucursal.SelectedValue);

                var lista = datosVS.ObtenerVehiculoSucursal();

                var filtrado = lista
                    .Where(x => x.IdSucursal == idSucursal)
                    .ToList();

                data_sucursalxVehiculo.DataSource = filtrado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private void Consulta_vehiculoxsucursal_Load(object sender, EventArgs e)
        {

            CargarSucursales();
            //CargarGrid();
        }
        private void CargarSucursales()
        {
            var lista = datosSucursal.ObtenerSucursales();

            comboBox_idsucursal.DataSource = lista;
            comboBox_idsucursal.DisplayMember = "Nombre";
            comboBox_idsucursal.ValueMember = "IdSucursal";
        }
        private void CargarGrid()
        {
            var lista = datosVS.ObtenerVehiculoSucursal();
            data_sucursalxVehiculo.DataSource = lista;
        }
    }
}
