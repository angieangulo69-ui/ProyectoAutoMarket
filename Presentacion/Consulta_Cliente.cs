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
    public partial class Consulta_Cliente : Form
    {
        private List<Cliente> clientesregistrados; // lista en memoria con los clientes
        public Consulta_Cliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void comboBoxcliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (comboBoxcliente.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione un cliente para filtrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string seleccionado = comboBoxcliente.Text;
            var resultado = clientesregistrados
                .Where(x => string.Equals(x.NombreCompleto, seleccionado, StringComparison.OrdinalIgnoreCase))
                .ToList();

            data_clientes.Rows.Clear();
            foreach (var c in resultado)
            {
                data_clientes.Rows.Add(
                    c.IdCliente,
                    c.Identificacion,
                    c.NombreCompleto,
                    c.FechaNacimiento.ToShortDateString(),
                    c.FechaRegistro.ToShortDateString(),
                    c.Activo ? "Sí" : "No"
                );
            }

            lbl_info.Text = $"Mostrando {resultado.Count} registro(s) para '{seleccionado}'";
        }
        

        private void btn_historial_Click(object sender, EventArgs e)
        {
            CargarDesdeBase();
            CargarGrid();
            CargarComboBox();
        }

        private void data_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(data_clientes.Rows[e.RowIndex].Cells["IdCliente"].Value);
            var cliente = clientesregistrados.FirstOrDefault(x => x.IdCliente == id);
            if (cliente != null)
            {
                string info = $"ID: {cliente.IdCliente}\r\nIdentificación: {cliente.Identificacion}\r\nNombre: {cliente.NombreCompleto}\r\nFecha Nac.: {cliente.FechaNacimiento:d}\r\nFecha Reg.: {cliente.FechaRegistro:d}\r\nActivo: {(cliente.Activo ? "Sí" : "No")}";
                MessageBox.Show(info, "Detalle del cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Consulta_Cliente_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarDesdeBase();
            //CargarGrid();
            CargarComboBox();
        }

        // Métodos 
        private void ConfigurarGrid()
        {
            data_clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_clientes.ReadOnly = true;
            data_clientes.AllowUserToAddRows = false;
            data_clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_clientes.MultiSelect = false;

            if (data_clientes.Columns.Count == 0)
            {
                data_clientes.Columns.Add("IdCliente", "ID");
                data_clientes.Columns.Add("Identificacion", "Identificación");
                data_clientes.Columns.Add("NombreCompleto", "Nombre");
                data_clientes.Columns.Add("FechaNacimiento", "Fecha Nac.");
                data_clientes.Columns.Add("FechaRegistro", "Fecha Reg.");
                data_clientes.Columns.Add("Activo", "Activo");
            }
        }
        private void CargarDesdeBase()
        {
            try
            {
                Logica_Cliente logica = new Logica_Cliente();
                clientesregistrados = logica.ConsultarCliente();
                if (clientesregistrados == null) clientesregistrados = new List<Cliente>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clientesregistrados = new List<Cliente>();
            }
        }
        private void CargarGrid()
        {
            data_clientes.Rows.Clear();
            foreach (var c in clientesregistrados)
            {
                data_clientes.Rows.Add(
                    c.IdCliente,
                    c.Identificacion,
                    c.NombreCompleto,
                    c.FechaNacimiento.ToShortDateString(),
                    c.FechaRegistro.ToShortDateString(),
                    c.Activo ? "Sí" : "No"
                );
            }
            lbl_info.Text = $"Registros: {clientesregistrados.Count}";
        }
        private void CargarComboBox()
        {
            comboBoxcliente.DataSource = null;
            var lista = new List<string> { "Seleccione..." };
            lista.AddRange(clientesregistrados.Select(x => x.NombreCompleto));
            comboBoxcliente.DataSource = lista;
            comboBoxcliente.SelectedIndex = 0;
        }



    }
}
