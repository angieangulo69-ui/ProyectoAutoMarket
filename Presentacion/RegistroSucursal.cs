using Entidades;
using Logica;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion
{
    public partial class RegistroSucursal : Form
    {
        private Logica_Sucursal logica = new Logica_Sucursal();
        Logica_Vendedor logicaVendedor = new Logica_Vendedor();
        public RegistroSucursal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Logica_Sucursal logica = new Logica_Sucursal();

                Sucursal sucursal = new Sucursal
                {
                    IdSucursal = logica.ObtenerSiguienteId(),
                    Nombre = txt_nombre.Text,
                    Direccion = txt_direccion.Text,
                    Telefono = mastb_telefono.Text,
                    IdVendedor = Convert.ToInt32(comboBox_encargado.SelectedValue),
                    Activo = checkBox_activo.Checked
                };

                bool resultado = logica.InsertarSucursal(sucursal);

                if (resultado)
                {
                    MessageBox.Show("Sucursal registrada correctamente.");
                    LimpiarCampos();
                    CargarGrid_Sucursal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void btn_atras_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de registro
            MenuRegistros Registros = new MenuRegistros();
            Registros.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistroSucursal_Load(object sender, EventArgs e)
        {
            
            configurarDataGridView();
            txt_idsucursal.Text = logica.ObtenerSiguienteId().ToString();
            CargarVendedores();
            CargarGrid_Sucursal();

            
        }
        private void configurarDataGridView()
        {
            data_sucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_sucursal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_sucursal.ReadOnly = true;
            data_sucursal.AllowUserToAddRows = false;
            data_sucursal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_sucursal.MultiSelect = false;

            // Usaremos Rows.Add, por eso AutoGenerateColumns = false
            data_sucursal.AutoGenerateColumns = false;
        }
        private void LimpiarCampos()

        { // Limpia los campos del formulario

            txt_nombre.Clear();
            txt_direccion.Clear();
            mastb_telefono.Clear();
            comboBox_encargado.SelectedIndex = -1;
            checkBox_activo.Checked = false;
            txt_idsucursal.Text = logica.ObtenerSiguienteId().ToString(); // Actualiza el ID para la siguiente sucursal

        }
        private void CargarVendedores()
        {
            try
            {
                var vendedores = logicaVendedor.ConsultarVendedor() ?? new List<Vendedor>();
                comboBox_encargado.DataSource = null;
                comboBox_encargado.DataSource = vendedores;
                comboBox_encargado.DisplayMember = "NombreCompleto";
                comboBox_encargado.ValueMember = "IdVendedor";
                comboBox_encargado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando vendedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarGrid_Sucursal()
        {

            try
            {
                var lista = logica.ObtenerSucursales() ?? new List<Sucursal>();
                data_sucursal.Rows.Clear();

                foreach (var s in lista)
                {
                    string vendedor = s.Vendedor != null ? s.Vendedor.NombreCompleto : "SIN VENDEDOR";
                    string activo = s.Activo ? "Sí" : "No";

                    data_sucursal.Rows.Add(
                        s.IdSucursal,
                        s.Nombre ?? string.Empty,
                        s.Direccion ?? string.Empty,
                        s.Telefono ?? string.Empty,
                        vendedor,
                        activo
                    );
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message);
            }
        }
    }
}




        
    

