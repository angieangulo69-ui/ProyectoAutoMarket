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
    public partial class Consulta_Categoria : Form
    {
        private List<CategoriaVehiculo> categorias; // Lista para almacenar las categorías de vehículos
        public Consulta_Categoria()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            if(comboBoxcategoria.SelectedIndex <= 0)
            {
                MessageBox.Show("Seleccione una categoría para filtrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string categoriaSeleccionada = comboBoxcategoria.Text;
            var resultado = categorias
                .Where(x => string.Equals(x.NombreCategoria, categoriaSeleccionada, StringComparison.OrdinalIgnoreCase))
                .ToList();

            data_categoriavehiculos.Rows.Clear();
            foreach (var c in resultado)
            {
                data_categoriavehiculos.Rows.Add(c.IdCategoria, c.NombreCategoria, c.Descripcion);
            }
            
        }
        

        private void btn_consultacategorias_Click(object sender, EventArgs e)
        {
            CargarDesdeBase();
            CargarGrid();
            CargarComboBox();
        }

        private void comboBoxcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void data_categoriavehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(data_categoriavehiculos.Rows[e.RowIndex].Cells["IdCategoria"].Value);
                var cat = categorias.FirstOrDefault(x => x.IdCategoria == id);
                if (cat != null)
                {
                    MessageBox.Show($"ID: {cat.IdCategoria}\r\nNombre: {cat.NombreCategoria}\r\nDescripción: {cat.Descripcion}", "Detalle");
                }
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de registro
            MenuRegistros Registros = new MenuRegistros();
            Registros.Show();
            Close(); //Cierra la ventana actual
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Consulta_Categoria_Load(object sender, EventArgs e)
        {
            ConfiguracionDataGrid();
            CargarDesdeBase();   // trae todo desde la BD
            //CargarGrid();        // muestra todo en el DataGridView
            CargarComboBox();    // llena el combo con los nombres
        }

        //Métodos
        private void ConfiguracionDataGrid()
        {
            data_categoriavehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_categoriavehiculos.ReadOnly = true;
            data_categoriavehiculos.AllowUserToAddRows = false;

            // Si no definiste columnas en el diseñador, las creamos aquí
            if (data_categoriavehiculos.Columns.Count == 0)
            {
                data_categoriavehiculos.Columns.Add("IdCategoria", "ID");
                data_categoriavehiculos.Columns.Add("NombreCategoria", "Nombre");
                data_categoriavehiculos.Columns.Add("Descripcion", "Descripción");
            }
        }
        private void CargarDesdeBase()
        {
            try
            {
                Logica_CategoriaVehiculo logica = new Logica_CategoriaVehiculo();
                categorias = logica.ConsultarCategorias(); // usa el método que ya tienes en Logica
                if (categorias == null) categorias = new List<CategoriaVehiculo>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                categorias = new List<CategoriaVehiculo>();
            }
        }
        // Carga el ComboBox con los nombres de las categorías
        private void CargarGrid()
        {
            data_categoriavehiculos.Rows.Clear();
            foreach (var c in categorias)
            {
                data_categoriavehiculos.Rows.Add(c.IdCategoria, c.NombreCategoria, c.Descripcion);
            }
            
        }
        // Carga el ComboBox con los nombres de las categorías
        private void CargarComboBox()
        {
            comboBoxcategoria.DataSource = null;
            var listaNombres = new List<string>();
            listaNombres.Add("Seleccione..."); // opción inicial
            foreach (var c in categorias)
            {
                listaNombres.Add(c.NombreCategoria);
            }
            comboBoxcategoria.DataSource = listaNombres;
            comboBoxcategoria.SelectedIndex = 0;
        }
    }
}
