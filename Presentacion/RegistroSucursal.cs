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
                if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_direccion.Text))
                {
                    MessageBox.Show("Complete todos los campos.");
                    return;
                }

                if (!mastb_telefono.MaskCompleted)
                {
                    MessageBox.Show("Teléfono incompleto.");
                    return;
                }

                if (comboBox_encargado.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione vendedor.");
                    return;
                }

                int nuevoId = logica.ObtenerSiguienteID();

                Vendedor vendedorSeleccionado =
                    (Vendedor)comboBox_encargado.SelectedItem;

                Sucursal nuevaSucursal = new Sucursal(
                    nuevoId,
                    txt_nombre.Text,
                    txt_direccion.Text,
                    mastb_telefono.Text,
                    vendedorSeleccionado,
                    checkBox_activo.Checked
                );

                logica.registrarSucursal(nuevaSucursal);

                CargarGrid_Sucursal();
                LimpiarCampos();

                MessageBox.Show("Sucursal registrada correctamente");
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
            txt_idsucursal.Text = logica.ObtenerSiguienteID().ToString();
            CargarVendedores();
            CargarGrid_Sucursal();

            MessageBox.Show(logica.ConsultarSucursal().Count.ToString());
        }
        private void configurarDataGridView()
        {
            // Configura el DataGridView para mostrar los clientes de manera ordenada
            data_sucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Ajusta el tamaño de las filas para mostrar todo el contenido
            data_sucursal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Configura el DataGridView para que no se puedan editar las celdas ni agregar filas directamente
            data_sucursal.ReadOnly = true;
            data_sucursal.AllowUserToAddRows = false;

            data_sucursal.AutoGenerateColumns = true;
        }
        private void LimpiarCampos()

        { // Limpia los campos del formulario

            txt_nombre.Clear();
            txt_direccion.Clear();
            mastb_telefono.Clear();
            comboBox_encargado.SelectedIndex = -1;
            checkBox_activo.Checked = false;
            txt_idsucursal.Text = logica.ObtenerSiguienteID().ToString(); // Actualiza el ID para la siguiente sucursal

        }
        private void CargarVendedores()
        {

            try
            {
                comboBox_encargado.DataSource = logicaVendedor.ConsultarVendedor();
                comboBox_encargado.DisplayMember = "NombreCompleto";
                comboBox_encargado.ValueMember = "IdVendedor";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando vendedores: " + ex.Message);
            }
        }
        private void CargarGrid_Sucursal()
        {
            try
            {
                Logica_Sucursal logica = new Logica_Sucursal();
                var lista = logica.ConsultarSucursal();
                foreach (var sucursal in lista)
                {
                    data_sucursal.Rows.Add(
                        sucursal.IdSucursal,
                        sucursal.Nombre,
                        sucursal.Direccion,
                        sucursal.Telefono,
                        sucursal.VendedorEncargado != null
                ? sucursal.VendedorEncargado.NombreCompleto
                : "SIN VENDEDOR",
                        sucursal.Activo ? "Sí" : "No");                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message);
            }
        }

    }
}




        
    

