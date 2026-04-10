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
    public partial class Registro_Vendedor : Form
    {
        private Logica_Vendedor logica = new Logica_Vendedor();
        public Registro_Vendedor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
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
                Vendedor nuevoVendedor = new Vendedor(mask_identificacion.Text, txt_nombre.Text, dateTimeNacimiento.Value, dateTimeIngreso.Value, mask_telefono.Text);

                nuevoVendedor.IdVendedor = nuevoId;

                logica.RegistrarVendedor(nuevoVendedor); // Registrar el vendedor
                CargarGrid_Vendedor();
                LimpiarCampos();

                MessageBox.Show("Vendedor registrado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el vendedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void CargarGrid_Vendedor()
        {
            try
            {
                Logica_Vendedor logica = new Logica_Vendedor();
                var listaVendedores = logica.ConsultarVendedor(); // Obtener la lista de vendedores desde la lógica
                data_clientes.Rows.Clear(); // Limpiar las filas existentes en el DataGridView
                foreach (var vendedor in listaVendedores)
                {
                    data_clientes.Rows.Add(vendedor.IdVendedor, vendedor.Identificacion, vendedor.NombreCompleto, vendedor.FechaNacimiento.ToShortDateString(), vendedor.FechaIngreso.ToShortDateString(), vendedor.Telefono);
                }

                //data_clientes.DataSource = logica.ConsultarCliente(); // Cargar los clientes en el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar vendedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            mask_identificacion.Clear();
            txt_nombre.Clear();
            dateTimeNacimiento.Value = DateTime.Now;
            dateTimeIngreso.Value = DateTime.Now;
            mask_telefono.Clear();

            txt_idvendedor.Text = logica.ObtenerSiguienteId().ToString(); // Actualizar el ID para el próximo cliente
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

        private void Registro_Vendedor_Load(object sender, EventArgs e)
        {
            configurarDataGridView();
            txt_idvendedor.Text = logica.ObtenerSiguienteId().ToString();
            CargarGrid_Vendedor();
        }

        //Metodos

    }
}
