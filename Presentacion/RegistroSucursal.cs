using Logica;
using Entidades;

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
    public partial class RegistroSucursal : Form
    {
       private Logica_Sucursal logica = new Logica_Sucursal();
        public RegistroSucursal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos vacíos
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    txt_nombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_direccion.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                // Validar formato de teléfono
                if (!mastb_telefono.MaskCompleted)
                {
                    MessageBox.Show("Complete correctamente el teléfono.");
                    return;
                }
                // Validar selección de vendedor
                if (comboBox_encargado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un vendedor encargado.");
                    return;
                }

                int nuevoId = logica.ObtenerSiguienteID(); // Obtener el siguiente ID disponible
                                                           
                // Obtener vendedor seleccionado
                Vendedor vendedorSeleccionado = (Vendedor)comboBox_encargado.SelectedItem;

                Sucursal nuevasucursal = new Sucursal(txt_nombre.Text,txt_direccion.Text, mastb_telefono.Text, vendedorSeleccionado, checkBox_activo.Checked);
                nuevasucursal.IdSucursal = nuevoId; // Asignar el ID a la nueva sucursal

                logica.registrarSucursal(nuevasucursal); // Registrar la sucursal 
                CargarGrid_Sucursal(); // Actualizar el DataGridView
                LimpiarCampos(); // Limpiar los campos del formulario

                MessageBox.Show("Sucursal registrada exitosamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar sucursal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CargarGrid_Sucursal();
        }
        private void configurarDataGridView()
        {
            // Configura el DataGridView para mostrar los clientes de manera ordenada
            data_sucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Ajusta el tamaño de las filas para mostrar todo el contenido
            data_sucursal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Configura el DataGridView para que no se puedan editar las celdas ni agregar filas directamente
            data_sucursal.ReadOnly = true;
            //data_clientes.AutoGenerateColumns = true;
            data_sucursal.AllowUserToAddRows = false;
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

        private void CargarGrid_Sucursal()
        {
            try
            {
                Logica_Sucursal logica = new Logica_Sucursal();
                var listasucursal = logica.ConsultarSucursal(); // Obtener la lista de sucursales desde la lógica
                data_sucursal.Rows.Clear(); // Limpiar el DataGridView antes de cargar los datos
                foreach (var sucursal in listasucursal)
                {
                    data_sucursal.Rows.Add(sucursal.IdSucursal, sucursal.Nombre, sucursal.Direccion, sucursal.Telefono, sucursal.VendedorEncargado.NombreCompleto, sucursal.Activo ? "Sí" : "No");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
