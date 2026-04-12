namespace Presentacion
{
    partial class Consulta_Sucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Sucursal));
            label4 = new Label();
            btn_consultar = new Button();
            data_sucursal = new DataGridView();
            btn_salir = new Button();
            label1 = new Label();
            btn_atras = new Button();
            comboBox_sucursales = new ComboBox();
            btn_historial = new Button();
            IdSucursal = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Vendedor = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)data_sucursal).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(89, 143);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 53;
            label4.Text = "Sucursal:";
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = SystemColors.ActiveCaptionText;
            btn_consultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar.ForeColor = Color.DeepSkyBlue;
            btn_consultar.Location = new Point(416, 128);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(109, 40);
            btn_consultar.TabIndex = 52;
            btn_consultar.Text = "Consulta";
            btn_consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // data_sucursal
            // 
            data_sucursal.BackgroundColor = Color.White;
            data_sucursal.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            data_sucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_sucursal.Columns.AddRange(new DataGridViewColumn[] { IdSucursal, Nombre, Direccion, Telefono, Vendedor, Activo });
            data_sucursal.GridColor = SystemColors.HighlightText;
            data_sucursal.Location = new Point(129, 204);
            data_sucursal.Name = "data_sucursal";
            data_sucursal.RowHeadersWidth = 51;
            data_sucursal.Size = new Size(761, 259);
            data_sucursal.TabIndex = 51;
            data_sucursal.CellContentClick += data_sucursal_CellContentClick;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(973, 530);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 50;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(258, 42);
            label1.Name = "label1";
            label1.Size = new Size(382, 46);
            label1.TabIndex = 49;
            label1.Text = "Consulta de Sucursales";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(60, 510);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 48;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // comboBox_sucursales
            // 
            comboBox_sucursales.FormattingEnabled = true;
            comboBox_sucursales.Location = new Point(205, 141);
            comboBox_sucursales.Name = "comboBox_sucursales";
            comboBox_sucursales.Size = new Size(151, 28);
            comboBox_sucursales.TabIndex = 54;
            comboBox_sucursales.SelectedIndexChanged += comboBox_sucursales_SelectedIndexChanged;
            // 
            // btn_historial
            // 
            btn_historial.BackColor = SystemColors.ActiveCaptionText;
            btn_historial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_historial.ForeColor = Color.DeepSkyBlue;
            btn_historial.Location = new Point(544, 128);
            btn_historial.Name = "btn_historial";
            btn_historial.Size = new Size(109, 40);
            btn_historial.TabIndex = 55;
            btn_historial.Text = "Historial";
            btn_historial.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_historial.UseVisualStyleBackColor = false;
            btn_historial.Click += btn_historial_Click;
            // 
            // IdSucursal
            // 
            IdSucursal.HeaderText = "Id";
            IdSucursal.MinimumWidth = 6;
            IdSucursal.Name = "IdSucursal";
            IdSucursal.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.Width = 125;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Teléfono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.Width = 125;
            // 
            // Vendedor
            // 
            Vendedor.HeaderText = "Vendedor";
            Vendedor.MinimumWidth = 6;
            Vendedor.Name = "Vendedor";
            Vendedor.Width = 125;
            // 
            // Activo
            // 
            Activo.HeaderText = "Activo";
            Activo.MinimumWidth = 6;
            Activo.Name = "Activo";
            Activo.Width = 125;
            // 
            // Consulta_Sucursal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1047, 601);
            Controls.Add(btn_historial);
            Controls.Add(comboBox_sucursales);
            Controls.Add(label4);
            Controls.Add(btn_consultar);
            Controls.Add(data_sucursal);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Name = "Consulta_Sucursal";
            Text = "Categoria_Sucursal";
            Load += Consulta_Sucursal_Load;
            ((System.ComponentModel.ISupportInitialize)data_sucursal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Button btn_consultar;
        private DataGridView data_sucursal;
        private Button btn_salir;
        private Label label1;
        private Button btn_atras;
        private ComboBox comboBox_sucursales;
        private Button btn_historial;
        private DataGridViewTextBoxColumn IdSucursal;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Vendedor;
        private DataGridViewTextBoxColumn Activo;
    }
}