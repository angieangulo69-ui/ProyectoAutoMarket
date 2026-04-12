using System;
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
    
    public partial class Consulta_Vendedor : Form

    {
        private Logica_Vendedor logica = new Logica_Vendedor();
        private List<Vendedor> listaVendedores = new List<Vendedor>();
        public Consulta_Vendedor()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxvendedor.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione un vendedor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Si listaVendedores está vacía (por ejemplo si solo cargaste el combo con nombres),
                // la usamos para filtrar porque ya contiene los objetos Vendedor.
                string nombre = comboBoxvendedor.Text;

                var filtrado = (listaVendedores ?? new List<Vendedor>())
                    .Where(v => v.NombreCompleto.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                MostrarEnGrid(filtrado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void data_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_historial_Click(object sender, EventArgs e)
        {
            try
            {
                // Si la lista ya fue cargada en el combo al inicio, listaVendedores ya tiene datos.
                // Aseguramos que esté actualizada y la mostramos.
                if (listaVendedores == null || listaVendedores.Count == 0)
                {
                    CargarDatos();
                    CargarCombo(); // opcional: refrescar combo si hubo cambios
                }

                MostrarEnGrid(listaVendedores);
                comboBoxvendedor.SelectedIndex = -1;
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

        private void Consulta_Vendedor_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();         
            CargarCombo();
        }
        private void ConfigurarGrid()
        {
            data_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_clientes.ReadOnly = true;
            data_clientes.AllowUserToAddRows = false;
            data_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (data_clientes.Columns.Count == 0)
            {
                data_clientes.Columns.Add("IdVendedor", "ID");
                data_clientes.Columns.Add("Identificacion", "Identificación");
                data_clientes.Columns.Add("Nombre", "Nombre");
                data_clientes.Columns.Add("Nacimiento", "Nacimiento");
                data_clientes.Columns.Add("Ingreso", "Ingreso");
                data_clientes.Columns.Add("Telefono", "Teléfono");
            }
        }
        private void CargarCombo()
        {
            try
            {
                // 
                listaVendedores = logica.ConsultarVendedor() ?? new List<Vendedor>();

                comboBoxvendedor.DataSource = null;
                comboBoxvendedor.DataSource = listaVendedores;
                comboBoxvendedor.DisplayMember = "NombreCompleto";
                comboBoxvendedor.ValueMember = "IdVendedor";
                comboBoxvendedor.SelectedIndex = -1; // sin selección 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el combo de vendedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarDatos()
        {
            try
            {
                listaVendedores = logica.ConsultarVendedor() ?? new List<Vendedor>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener vendedores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEnGrid(List<Vendedor> lista)
        {
            data_clientes.Rows.Clear();

            foreach (var v in lista)
            {
                data_clientes.Rows.Add(
                    v.IdVendedor,
                    v.Identificacion,
                    v.NombreCompleto,
                    v.FechaNacimiento.ToShortDateString(),
                    v.FechaIngreso.ToShortDateString(),
                    v.Telefono
                );
            }
        }
    }
}
