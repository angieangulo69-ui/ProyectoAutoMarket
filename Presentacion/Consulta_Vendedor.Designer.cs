namespace Presentacion
{
    partial class Consulta_Vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Vendedor));
            data_clientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btn_salir = new Button();
            btn_atras = new Button();
            label4 = new Label();
            btn_registrar = new Button();
            label1 = new Label();
            btn_historial = new Button();
            comboBoxvendedor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)data_clientes).BeginInit();
            SuspendLayout();
            // 
            // data_clientes
            // 
            data_clientes.BackgroundColor = Color.Black;
            data_clientes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            data_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_clientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Column6 });
            data_clientes.GridColor = SystemColors.HighlightText;
            data_clientes.Location = new Point(95, 156);
            data_clientes.Name = "data_clientes";
            data_clientes.RowHeadersWidth = 51;
            data_clientes.Size = new Size(761, 316);
            data_clientes.TabIndex = 64;
            data_clientes.CellContentClick += data_clientes_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id Vendedor";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Identificación";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nombre";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Nacimiento";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ingreso";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Teléfono";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(951, 497);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 63;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(12, 497);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 62;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(138, 100);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 60;
            label4.Text = "Vendedor:";
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = SystemColors.ActiveCaptionText;
            btn_registrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.ForeColor = Color.DeepSkyBlue;
            btn_registrar.Location = new Point(445, 91);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(127, 40);
            btn_registrar.TabIndex = 59;
            btn_registrar.Text = "Consultar";
            btn_registrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(95, 12);
            label1.Name = "label1";
            label1.Size = new Size(401, 46);
            label1.TabIndex = 58;
            label1.Text = "Consulta de Vendedores";
            // 
            // btn_historial
            // 
            btn_historial.BackColor = SystemColors.ActiveCaptionText;
            btn_historial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_historial.ForeColor = Color.DeepSkyBlue;
            btn_historial.Location = new Point(578, 91);
            btn_historial.Name = "btn_historial";
            btn_historial.Size = new Size(127, 40);
            btn_historial.TabIndex = 65;
            btn_historial.Text = "Historial";
            btn_historial.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_historial.UseVisualStyleBackColor = false;
            btn_historial.Click += btn_historial_Click;
            // 
            // comboBoxvendedor
            // 
            comboBoxvendedor.FormattingEnabled = true;
            comboBoxvendedor.Location = new Point(254, 106);
            comboBoxvendedor.Name = "comboBoxvendedor";
            comboBoxvendedor.Size = new Size(151, 28);
            comboBoxvendedor.TabIndex = 66;
            // 
            // Consulta_Vendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1023, 553);
            Controls.Add(comboBoxvendedor);
            Controls.Add(btn_historial);
            Controls.Add(data_clientes);
            Controls.Add(btn_salir);
            Controls.Add(btn_atras);
            Controls.Add(label4);
            Controls.Add(btn_registrar);
            Controls.Add(label1);
            Name = "Consulta_Vendedor";
            Text = "Consulta_Vendedor";
            Load += Consulta_Vendedor_Load;
            ((System.ComponentModel.ISupportInitialize)data_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data_clientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private Button btn_salir;
        private Button btn_atras;
        private Label label4;
        private Button btn_registrar;
        private Label label1;
        private Button btn_historial;
        private ComboBox comboBoxvendedor;
    }
}