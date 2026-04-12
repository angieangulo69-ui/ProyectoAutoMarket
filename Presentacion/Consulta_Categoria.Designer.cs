namespace Presentacion
{
    partial class Consulta_Categoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Categoria));
            label4 = new Label();
            btn_consultar = new Button();
            data_categoriavehiculos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            btn_salir = new Button();
            label1 = new Label();
            btn_atras = new Button();
            comboBoxcategoria = new ComboBox();
            btn_consultacategorias = new Button();
            ((System.ComponentModel.ISupportInitialize)data_categoriavehiculos).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(48, 107);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 30;
            label4.Text = "Categoría:";
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = SystemColors.ActiveCaptionText;
            btn_consultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar.ForeColor = Color.DeepSkyBlue;
            btn_consultar.Location = new Point(319, 92);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(109, 40);
            btn_consultar.TabIndex = 29;
            btn_consultar.Text = "Consulta";
            btn_consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consulta_Click;
            // 
            // data_categoriavehiculos
            // 
            data_categoriavehiculos.BackgroundColor = Color.Black;
            data_categoriavehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_categoriavehiculos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripción });
            data_categoriavehiculos.GridColor = SystemColors.HighlightText;
            data_categoriavehiculos.Location = new Point(149, 204);
            data_categoriavehiculos.Name = "data_categoriavehiculos";
            data_categoriavehiculos.RowHeadersWidth = 51;
            data_categoriavehiculos.Size = new Size(395, 188);
            data_categoriavehiculos.TabIndex = 28;
            data_categoriavehiculos.CellContentClick += data_categoriavehiculos_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id Categoría";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.MinimumWidth = 6;
            Descripción.Name = "Descripción";
            Descripción.Width = 125;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(745, 391);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 24;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(85, 27);
            label1.Name = "label1";
            label1.Size = new Size(584, 46);
            label1.TabIndex = 22;
            label1.Text = "Consulta de Categoría de Vehiculos:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(12, 391);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 21;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // comboBoxcategoria
            // 
            comboBoxcategoria.FormattingEnabled = true;
            comboBoxcategoria.Location = new Point(161, 102);
            comboBoxcategoria.Name = "comboBoxcategoria";
            comboBoxcategoria.Size = new Size(151, 28);
            comboBoxcategoria.TabIndex = 32;
            comboBoxcategoria.SelectedIndexChanged += comboBoxcategoria_SelectedIndexChanged;
            // 
            // btn_consultacategorias
            // 
            btn_consultacategorias.BackColor = SystemColors.ActiveCaptionText;
            btn_consultacategorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultacategorias.ForeColor = Color.DeepSkyBlue;
            btn_consultacategorias.Location = new Point(447, 90);
            btn_consultacategorias.Name = "btn_consultacategorias";
            btn_consultacategorias.Size = new Size(109, 40);
            btn_consultacategorias.TabIndex = 33;
            btn_consultacategorias.Text = "Historial";
            btn_consultacategorias.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_consultacategorias.UseVisualStyleBackColor = false;
            btn_consultacategorias.Click += btn_consultacategorias_Click;
            // 
            // Consulta_Categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btn_consultacategorias);
            Controls.Add(comboBoxcategoria);
            Controls.Add(label4);
            Controls.Add(btn_consultar);
            Controls.Add(data_categoriavehiculos);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Name = "Consulta_Categoria";
            Text = "Consulta_Categoria";
            Load += Consulta_Categoria_Load;
            ((System.ComponentModel.ISupportInitialize)data_categoriavehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Button btn_consultar;
        private DataGridView data_categoriavehiculos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripción;
        private Button btn_salir;
        private Label label1;
        private Button btn_atras;
        private ComboBox comboBoxcategoria;
        private Button btn_consultacategorias;
    }
}