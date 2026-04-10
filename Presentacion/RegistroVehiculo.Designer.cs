namespace Presentacion
{
    partial class RegistroVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVehiculo));
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_marca = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txt_idvehiculo = new TextBox();
            label4 = new Label();
            btn_registrar = new Button();
            btn_salir = new Button();
            label1 = new Label();
            btn_atras = new Button();
            data_vehiculo = new DataGridView();
            txt_anio = new TextBox();
            txt_modelo = new TextBox();
            txt_precio = new TextBox();
            label8 = new Label();
            combox_categoria = new ComboBox();
            combox_estado = new ComboBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)data_vehiculo).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightCoral;
            label7.Location = new Point(18, 279);
            label7.Name = "label7";
            label7.Size = new Size(70, 25);
            label7.TabIndex = 76;
            label7.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightCoral;
            label6.Location = new Point(18, 202);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 74;
            label6.Text = "Modelo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightCoral;
            label5.Location = new Point(18, 351);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 71;
            label5.Text = "Estado:";
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(125, 174);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(203, 27);
            txt_marca.TabIndex = 70;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(18, 165);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 69;
            label3.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(18, 243);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 68;
            label2.Text = "Año:";
            // 
            // txt_idvehiculo
            // 
            txt_idvehiculo.Location = new Point(126, 141);
            txt_idvehiculo.Name = "txt_idvehiculo";
            txt_idvehiculo.ReadOnly = true;
            txt_idvehiculo.Size = new Size(203, 27);
            txt_idvehiculo.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(15, 136);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 66;
            label4.Text = "Id Vehiculo:";
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = SystemColors.ActiveCaptionText;
            btn_registrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.ForeColor = Color.DeepSkyBlue;
            btn_registrar.Location = new Point(152, 426);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(109, 40);
            btn_registrar.TabIndex = 65;
            btn_registrar.Text = "Registrar";
            btn_registrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(1185, 504);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 64;
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(377, 35);
            label1.Name = "label1";
            label1.Size = new Size(344, 46);
            label1.TabIndex = 63;
            label1.Text = "Registro de Vehiculo";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(17, 504);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 62;
            btn_atras.UseVisualStyleBackColor = false;
            // 
            // data_vehiculo
            // 
            data_vehiculo.BackgroundColor = Color.Black;
            data_vehiculo.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            data_vehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_vehiculo.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column5, Column4, Column6, Column7 });
            data_vehiculo.GridColor = SystemColors.HighlightText;
            data_vehiculo.Location = new Point(354, 106);
            data_vehiculo.Name = "data_vehiculo";
            data_vehiculo.RowHeadersWidth = 51;
            data_vehiculo.Size = new Size(874, 316);
            data_vehiculo.TabIndex = 78;
            // 
            // txt_anio
            // 
            txt_anio.Location = new Point(127, 241);
            txt_anio.Name = "txt_anio";
            txt_anio.Size = new Size(203, 27);
            txt_anio.TabIndex = 79;
            // 
            // txt_modelo
            // 
            txt_modelo.Location = new Point(125, 207);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(203, 27);
            txt_modelo.TabIndex = 80;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(125, 276);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(203, 27);
            txt_precio.TabIndex = 81;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightCoral;
            label8.Location = new Point(18, 317);
            label8.Name = "label8";
            label8.Size = new Size(99, 25);
            label8.TabIndex = 82;
            label8.Text = "Categoría:";
            // 
            // combox_categoria
            // 
            combox_categoria.FormattingEnabled = true;
            combox_categoria.Location = new Point(122, 316);
            combox_categoria.Name = "combox_categoria";
            combox_categoria.Size = new Size(206, 28);
            combox_categoria.TabIndex = 83;
            // 
            // combox_estado
            // 
            combox_estado.FormattingEnabled = true;
            combox_estado.Items.AddRange(new object[] { "Nuevo", "Usado" });
            combox_estado.Location = new Point(122, 352);
            combox_estado.Name = "combox_estado";
            combox_estado.Size = new Size(206, 28);
            combox_estado.TabIndex = 84;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id Vehiculo";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Marca";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Modelo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Año";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Id Categoría";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Estado";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // RegistroVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1261, 570);
            Controls.Add(combox_estado);
            Controls.Add(combox_categoria);
            Controls.Add(label8);
            Controls.Add(txt_precio);
            Controls.Add(txt_modelo);
            Controls.Add(txt_anio);
            Controls.Add(data_vehiculo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_marca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_idvehiculo);
            Controls.Add(label4);
            Controls.Add(btn_registrar);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Name = "RegistroVehiculo";
            Text = "RegistroVehiculo";
            ((System.ComponentModel.ISupportInitialize)data_vehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_marca;
        private Label label3;
        private Label label2;
        private TextBox txt_idvehiculo;
        private Label label4;
        private Button btn_registrar;
        private Button btn_salir;
        private Label label1;
        private Button btn_atras;
        private DataGridView data_vehiculo;
        private TextBox txt_anio;
        private TextBox txt_modelo;
        private TextBox txt_precio;
        private Label label8;
        private ComboBox combox_categoria;
        private ComboBox combox_estado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}