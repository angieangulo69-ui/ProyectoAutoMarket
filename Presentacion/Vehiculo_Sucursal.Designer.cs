namespace Presentacion
{
    partial class Vehiculo_Sucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehiculo_Sucursal));
            data_sucursalxVehiculo = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_registrar = new Button();
            btn_salir = new Button();
            label1 = new Label();
            btn_atras = new Button();
            comboBox_idsucursal = new ComboBox();
            comboBox_idvehiculo = new ComboBox();
            txt_cantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)data_sucursalxVehiculo).BeginInit();
            SuspendLayout();
            // 
            // data_sucursalxVehiculo
            // 
            data_sucursalxVehiculo.BackgroundColor = Color.Black;
            data_sucursalxVehiculo.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            data_sucursalxVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_sucursalxVehiculo.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2 });
            data_sucursalxVehiculo.GridColor = SystemColors.HighlightText;
            data_sucursalxVehiculo.Location = new Point(400, 143);
            data_sucursalxVehiculo.Name = "data_sucursalxVehiculo";
            data_sucursalxVehiculo.RowHeadersWidth = 51;
            data_sucursalxVehiculo.Size = new Size(423, 316);
            data_sucursalxVehiculo.TabIndex = 45;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id Sucursal";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Id Vehiculo";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cantidad";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightCoral;
            label6.Location = new Point(13, 233);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 84;
            label6.Text = "Cantidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(13, 197);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 81;
            label3.Text = "Id Vehiculo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(10, 154);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 79;
            label4.Text = "Id Sucursal:";
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = SystemColors.ActiveCaptionText;
            btn_registrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.ForeColor = Color.DeepSkyBlue;
            btn_registrar.Location = new Point(109, 316);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(109, 40);
            btn_registrar.TabIndex = 78;
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
            btn_salir.Location = new Point(828, 533);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 77;
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(230, 37);
            label1.Name = "label1";
            label1.Size = new Size(497, 46);
            label1.TabIndex = 76;
            label1.Text = "Registro de Vehiculo /Sucursal";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(12, 522);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 75;
            btn_atras.UseVisualStyleBackColor = false;
            // 
            // comboBox_idsucursal
            // 
            comboBox_idsucursal.FormattingEnabled = true;
            comboBox_idsucursal.Location = new Point(148, 154);
            comboBox_idsucursal.Name = "comboBox_idsucursal";
            comboBox_idsucursal.Size = new Size(151, 28);
            comboBox_idsucursal.TabIndex = 85;
            // 
            // comboBox_idvehiculo
            // 
            comboBox_idvehiculo.FormattingEnabled = true;
            comboBox_idvehiculo.Location = new Point(147, 200);
            comboBox_idvehiculo.Name = "comboBox_idvehiculo";
            comboBox_idvehiculo.Size = new Size(151, 28);
            comboBox_idvehiculo.TabIndex = 86;
            // 
            // txt_cantidad
            // 
            txt_cantidad.Location = new Point(151, 238);
            txt_cantidad.Name = "txt_cantidad";
            txt_cantidad.Size = new Size(147, 27);
            txt_cantidad.TabIndex = 87;
            // 
            // Vehiculo_Sucursal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(976, 610);
            Controls.Add(txt_cantidad);
            Controls.Add(comboBox_idvehiculo);
            Controls.Add(comboBox_idsucursal);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(btn_registrar);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Controls.Add(data_sucursalxVehiculo);
            Name = "Vehiculo_Sucursal";
            Text = "Vehiculo_Sucursal";
            ((System.ComponentModel.ISupportInitialize)data_sucursalxVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data_sucursalxVehiculo;
        private Label label6;
        private Label label3;
        private Label label4;
        private Button btn_registrar;
        private Button btn_salir;
        private Label label1;
        private Button btn_atras;
        private ComboBox comboBox_idsucursal;
        private ComboBox comboBox_idvehiculo;
        private TextBox txt_cantidad;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
    }
}