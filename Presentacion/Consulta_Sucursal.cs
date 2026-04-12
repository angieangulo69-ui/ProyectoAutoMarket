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
    public partial class Consulta_Sucursal : Form
    {
        private List<Sucursal> Sucursalesregistradas; // lista en memoria con las sucursales
        private Logica_Sucursal logica = new Logica_Sucursal();
        public Consulta_Sucursal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void comboBox_sucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

            if (comboBox_sucursales.SelectedIndex <= 0)
    {
        MessageBox.Show("Seleccione una sucursal para filtrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
    }

     string seleccionado = comboBox_sucursales.Text;
    var resultado = Sucursalesregistradas
        .Where(x => string.Equals(x.Nombre, seleccionado, StringComparison.OrdinalIgnoreCase))
        .ToList();

    MostrarListaEnGrid(resultado);

        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            CargarDesdeBase();
            CargarGrid();
            CargarComboBox();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void data_sucursal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cellValue = data_sucursal.Rows[e.RowIndex].Cells["IdSucursal"].Value;
            if (cellValue == null) return;

            if (!int.TryParse(cellValue.ToString(), out int id)) return;

            var suc = Sucursalesregistradas.FirstOrDefault(x => x.IdSucursal == id);
            if (suc != null)
            {
                string vendedor = suc.Vendedor != null ? suc.Vendedor.NombreCompleto : "Sin vendedor";
                MessageBox.Show(
                    $"ID: {suc.IdSucursal}\r\n" +
                    $"Nombre: {suc.Nombre}\r\n" +
                    $"Dirección: {suc.Direccion}\r\n" +
                    $"Teléfono: {suc.Telefono}\r\n" +
                    $"Vendedor: {vendedor}\r\n" +
                    $"Activo: {(suc.Activo ? "Sí" : "No")}",
                    "Detalle Sucursal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

            }
        }

        private void Consulta_Sucursal_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();

            CargarDesdeBase();

            CargarComboBox();
            data_sucursal.Rows.Clear();

        }

        //Metodos
        private void ConfigurarGrid()
        {
            data_sucursal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_sucursal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_sucursal.ReadOnly = true;
            data_sucursal.AllowUserToAddRows = false;
            data_sucursal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_sucursal.MultiSelect = false;
           
        }
        private void CargarDesdeBase()
        {
            try
            {
                // Usamos la lógica para consultar las sucursales
                Sucursalesregistradas = logica.ObtenerSucursales() ?? new List<Sucursal>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales desde la base: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Sucursalesregistradas = new List<Sucursal>();
            }
        }
        private void CargarGrid()
        {
            MostrarListaEnGrid(Sucursalesregistradas);

        }
        private void MostrarListaEnGrid(List<Sucursal> lista)
        {
            data_sucursal.Rows.Clear();
            foreach (var s in lista)
            {
                string vendedor = s.Vendedor != null ? s.Vendedor.NombreCompleto : "SIN VENDEDOR";
                string telefono = s.Telefono ?? string.Empty;
                string activo = s.Activo ? "Sí" : "No";

                data_sucursal.Rows.Add(
                    s.IdSucursal,
                    s.Nombre ?? string.Empty,
                    s.Direccion ?? string.Empty,
                    telefono,
                    vendedor,
                    activo
                );
            }
        }
        private void CargarComboBox()
        {
           // comboBox_sucursales.SelectedIndexChanged -= comboBox_sucursales_SelectedIndexChanged;

            var lista = new List<string> { "Seleccione..." };

            if (Sucursalesregistradas != null && Sucursalesregistradas.Count > 0)
            {
                lista.AddRange(Sucursalesregistradas
                    .Select(x => x.Nombre ?? string.Empty)
                    .Distinct(StringComparer.OrdinalIgnoreCase) 
                    .OrderBy(x => x, StringComparer.OrdinalIgnoreCase));
            }

            comboBox_sucursales.DataSource = lista;
            comboBox_sucursales.SelectedIndex = 0;

            comboBox_sucursales.SelectedIndexChanged += comboBox_sucursales_SelectedIndexChanged;
        }

    }
}
