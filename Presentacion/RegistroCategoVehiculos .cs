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
    public partial class RegistroCategoVehiculos : Form
    {
        public RegistroCategoVehiculos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana al abrir
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                    string.IsNullOrWhiteSpace(txt_descripcion.Text))
                {
                    MessageBox.Show("Debe completar todos los campos.");
                    return;
                }
                // Crear objeto de lógica para interactuar con la capa de negocio****
                Logica_CategoriaVehiculo logica = new Logica_CategoriaVehiculo();

                // Obtener ID desde la BD (NO usar contador)
                int nuevoId = logica.ObtenerSiguienteId();

                // Crear objeto
                CategoriaVehiculo nueva = new CategoriaVehiculo(

                    txt_nombre.Text.Trim(),
                    txt_descripcion.Text.Trim()
                );

                nueva.IdCategoria = nuevoId;
                logica.RegistrarCategoria(nueva);

                CargarGrid_Categorias();
                LimpiarCampos();

                txt_idcategoria.Text = logica.ObtenerSiguienteId().ToString();

                MessageBox.Show("Categoría registrada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //CArgar el grid con las categorías de vehículos
        private void CargarGrid_Categorias()
        {
            try
            {
                Logica_CategoriaVehiculo logica = new Logica_CategoriaVehiculo();

                var lista = logica.ConsultarCategorias();

                data_categoriavehiculos.Rows.Clear();

                foreach (var cat in lista)
                {
                    data_categoriavehiculos.Rows.Add(
                        cat.IdCategoria,
                        cat.NombreCategoria,
                        cat.Descripcion
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }
        private void ConfigurarGrid()
        {
            // Ajuiste del GridView
            data_categoriavehiculos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_categoriavehiculos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_categoriavehiculos.ReadOnly = true;
            data_categoriavehiculos.AllowUserToAddRows = false;
        }
        private void data_categoriavehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LimpiarCampos()
        { // Limpiar los campos de texto después de guardar

            txt_nombre.Clear();
            txt_descripcion.Clear();
            txt_nombre.Focus(); // Establecer el foco en el campo de categoría para facilitar la entrada de datos
        }

        private void RegistroCategoVehiculos_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            // Obtener el siguiente ID para mostrarlo en el campo de texto
            Logica_CategoriaVehiculo logica = new Logica_CategoriaVehiculo();
            txt_idcategoria.Text = logica.ObtenerSiguienteId().ToString();

            CargarGrid_Categorias();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            //Llamo a la ventana de registro
            MenuRegistros Registros = new MenuRegistros();
            Registros.Show();
            Close(); //Cierra la ventana actual
        }
    }

}
