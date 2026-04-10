using Entidades;
using Logica;
using Microsoft.Win32;
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
    public partial class RegistroCliente : Form
    {
        private Logica_Cliente logica = new Logica_Cliente();

        public RegistroCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            // Llamo a la ventana de registro
            MenuRegistros Registros = new MenuRegistros();
            Registros.Show();
            this.Close(); //Cierra la ventana actual
        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            configurarDataGridView();
            txt_idcliente.Text = logica.ObtenerSiguienteId().ToString();
            CargarGrid_Cliente();

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que los campos no estén vacíos
                if (string.IsNullOrWhiteSpace(txt_nombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio");
                    txt_nombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(mask_identificacion.Text))
                {
                    MessageBox.Show("La identificación es obligatoria");
                    mask_identificacion.Focus();
                    return;
                }
                int nuevoId = logica.ObtenerSiguienteId();
                Cliente nuevoCliente = new Cliente(mask_identificacion.Text, txt_nombre.Text, dateTimeNacimiento.Value, dateTimeRegistro.Value, checkBox_activo.Checked);

                nuevoCliente.IdCliente = nuevoId;
               
                logica.RegistrarCliente(nuevoCliente); // Registrar el cliente 
                CargarGrid_Cliente();
                LimpiarCampos();
                
                MessageBox.Show("Cliente registrado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void configurarDataGridView()
        {
            // Configura el DataGridView para mostrar los clientes de manera ordenada
            data_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Ajusta el tamaño de las filas para mostrar todo el contenido
            data_clientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Configura el DataGridView para que no se puedan editar las celdas ni agregar filas directamente
            data_clientes.ReadOnly = true;
            //data_clientes.AutoGenerateColumns = true;
            data_clientes.AllowUserToAddRows = false;
        }
        private void CargarGrid_Cliente()
        {
            try
            {   Logica_Cliente logica = new Logica_Cliente();
                var listaClientes = logica.ConsultarCliente(); // Obtener la lista de clientes desde la lógica
                data_clientes.Rows.Clear(); // Limpiar las filas existentes en el DataGridView
                foreach (var cliente in listaClientes)
                {
                    data_clientes.Rows.Add(cliente.IdCliente, cliente.Identificacion, cliente.NombreCompleto, cliente.FechaNacimiento.ToShortDateString(), cliente.FechaRegistro.ToShortDateString(), cliente.Activo ? "Sí" : "No");
                }

                //data_clientes.DataSource = logica.ConsultarCliente(); // Cargar los clientes en el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            mask_identificacion.Clear();
            txt_nombre.Clear();
            dateTimeNacimiento.Value = DateTime.Now;
            dateTimeRegistro.Value = DateTime.Now;
            checkBox_activo.Checked = false;

            txt_idcliente.Text = logica.ObtenerSiguienteId().ToString(); // Actualizar el ID para el próximo cliente
        }

        private void checkBox_activo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

}
