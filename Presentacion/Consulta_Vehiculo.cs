using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace Presentacion
{
    public partial class Consulta_Vehiculo : Form
    {
        private LogicaVehiculo logica = new LogicaVehiculo();
        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        public Consulta_Vehiculo()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            try
            {
                // Si la lista no está cargada, cargarla (evita filtrar sobre lista vacía)
                if (listaVehiculos == null || listaVehiculos.Count == 0)
                {
                    CargarDatos();
                }

                if (comboBox_vehiculos.SelectedIndex == -1 && string.IsNullOrWhiteSpace(comboBox_vehiculos.Text))
                {
                    MessageBox.Show("Seleccione una opción o escriba un término para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string valor = (comboBox_vehiculos.Text ?? "").ToLower();

                var filtrado = listaVehiculos
                    .Where(v =>
                        (v.Marca ?? "").ToLower().Contains(valor) ||
                        (v.Modelo ?? "").ToLower().Contains(valor)
                    )
                    .ToList();

                MostrarEnGrid(filtrado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaVehiculos == null || listaVehiculos.Count == 0)
                    CargarDatos();

                MostrarEnGrid(listaVehiculos);
                comboBox_vehiculos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_vehiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (data_vehiculo.Rows[e.RowIndex].Cells[0].Value == null) return;

                int id = Convert.ToInt32(data_vehiculo.Rows[e.RowIndex].Cells[0].Value);
                var v = listaVehiculos.FirstOrDefault(x => x.IdVehiculo == id);

                if (v != null)
                {
                    string categoria = v.Categoria != null ? v.Categoria.NombreCategoria : "";
                    string estado = v.Estado == 'N' ? "Nuevo" : (v.Estado == 'U' ? "Usado" : v.Estado.ToString());

                    MessageBox.Show(
                        $"Marca: {v.Marca}\n" +
                        $"Modelo: {v.Modelo}\n" +
                        $"Año: {v.Ano}\n" +
                        $"Precio: {v.Precio.ToString("C")}\n" +
                        $"Categoría: {categoria}\n" +
                        $"Estado: {estado}",
                        "Detalle del Vehículo"
                    );
                }
            }
        }
        

        private void Consulta_Vehiculo_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarDatos();
        }

        private void ConfigurarGrid()
        {
            data_vehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_vehiculo.ReadOnly = true;
            data_vehiculo.AllowUserToAddRows = false;
            data_vehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (data_vehiculo.Columns.Count == 0)
            {
                data_vehiculo.Columns.Add("IdVehiculo", "ID");
                data_vehiculo.Columns.Add("Marca", "Marca");
                data_vehiculo.Columns.Add("Modelo", "Modelo");
                data_vehiculo.Columns.Add("Ano", "Año");
                data_vehiculo.Columns.Add("Precio", "Precio");
                data_vehiculo.Columns.Add("Categoria", "Categoría");
                data_vehiculo.Columns.Add("Estado", "Estado");
            }
        }
        private void CargarDatos()
        {
            try
            {
                // Cargar la lista completa y guardarla en la variable de clase
                listaVehiculos = logica.ConsultarVehiculo() ?? new List<Vehiculo>();

                // Opciones para el combo: por marca (puedes cambiar a Marca + " " + Modelo)
                var opciones = listaVehiculos
                    .Select(v => v.Marca ?? string.Empty)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList();

                comboBox_vehiculos.DataSource = opciones;
                comboBox_vehiculos.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarEnGrid(List<Vehiculo> lista)
        {
            data_vehiculo.Rows.Clear();

            foreach (var v in lista)
            {
                string categoria = v.Categoria != null ? (v.Categoria.NombreCategoria ?? "") : "";
                string estado = v.Estado == 'N' ? "Nuevo" : (v.Estado == 'U' ? "Usado" : (v.Estado == '\0' ? "" : v.Estado.ToString()));

                data_vehiculo.Rows.Add(
                    v.IdVehiculo,
                    v.Marca ?? "",
                    v.Modelo ?? "",
                    v.Ano,
                    v.Precio.ToString("C"),
                    categoria,
                    estado
                );
            }
        }
    }
}
