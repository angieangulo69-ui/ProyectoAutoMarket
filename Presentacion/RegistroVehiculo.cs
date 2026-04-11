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
    public partial class RegistroVehiculo : Form
    {
        LogicaVehiculo logica = new LogicaVehiculo();
        public RegistroVehiculo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_marca.Text) ||
                 string.IsNullOrWhiteSpace(txt_modelo.Text) ||
                 string.IsNullOrWhiteSpace(txt_anio.Text) ||
                 string.IsNullOrWhiteSpace(txt_precio.Text) ||
                 combox_categoria.SelectedIndex == -1 ||
                 combox_estado.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe completar todos los campos");
                    return;
                }

                int anio = int.Parse(txt_anio.Text);
                decimal precio = decimal.Parse(txt_precio.Text);

                if (anio < 1900 || anio > DateTime.Now.Year)
                {
                    MessageBox.Show("Año inválido");
                    return;
                }

                if (precio <= 0)
                {
                    MessageBox.Show("Precio inválido");
                    return;
                }

                int nuevoId = logica.ObtenerSiguienteId();

                Vehiculo v = new Vehiculo
                {
                    IdVehiculo = logica.ObtenerSiguienteId(),
                    Marca = txt_marca.Text,
                    Modelo = txt_modelo.Text,
                    Ano = int.Parse(txt_anio.Text),
                    Precio = decimal.Parse(txt_precio.Text),
                    IdCategoria = (int)combox_categoria.SelectedValue,
                    Estado = combox_estado.Text == "Nuevo" ? 'N' : 'U'
                };

                logica.RegistrarVehiculo(v);

                CargarGrid_Vehiculo();
                LimpiarCampos();

                MessageBox.Show("Vehículo registrado correctamente");
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

        private void RegistroVehiculo_Load(object sender, EventArgs e)
        {
            configurarDataGridView();
            txt_idvehiculo.Text = logica.ObtenerSiguienteId().ToString();
            
            CargarCategorias();
            CargarEstados();
            CargarGrid_Vehiculo();
        }
      private void configurarDataGridView()
        {
            // Configura el DataGridView para mostrar los clientes de manera ordenada
            data_vehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Ajusta el tamaño de las filas para mostrar todo el contenido
            data_vehiculo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            // Configura el DataGridView para que no se puedan editar las celdas ni agregar filas directamente
            data_vehiculo.ReadOnly = true;
            //data_vehiculo.AutoGenerateColumns = true;
            data_vehiculo.AllowUserToAddRows = false;
        }
        private void CargarCategorias()
        {
            try
            {
                combox_categoria.DataSource = logica.ConsultarCategoria();
                combox_categoria.DisplayMember = "NombreCategoria";
                combox_categoria.ValueMember = "IdCategoria";
                combox_categoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando categorías: " + ex.Message);
            }
        }
        private void CargarEstados()
        {
            combox_estado.Items.Clear();
            combox_estado.Items.Add("Nuevo");
            combox_estado.Items.Add("Usado");
        }
        private void CargarGrid_Vehiculo()
        {
            try
            {
                var lista = logica.ConsultarVehiculo();

                data_vehiculo.Rows.Clear();

                foreach (var v in lista)
                {
                    data_vehiculo.Rows.Add(
                        v.IdVehiculo,
                        v.Marca,
                        v.Modelo,
                        v.Ano,
                        v.Precio.ToString("C"),
                        v.Categoria.NombreCategoria,
                        v.Estado == 'N' ? "Nuevo" : "Usado"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    
        private void LimpiarCampos()
        {
            txt_marca.Clear();
            txt_modelo.Clear();
            txt_anio.Clear();
            txt_precio.Clear();

            combox_categoria.SelectedIndex = -1;
            combox_estado.SelectedIndex = -1;

            txt_idvehiculo.Text = logica.ObtenerSiguienteId().ToString();
        }

    }
}