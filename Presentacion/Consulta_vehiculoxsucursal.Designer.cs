namespace Presentacion
{
    partial class Consulta_vehiculoxsucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_vehiculoxsucursal));
            comboBox_idsucursal = new ComboBox();
            label4 = new Label();
            btn_consultar = new Button();
            btn_salir = new Button();
            label1 = new Label();
            btn_atras = new Button();
            data_sucursalxVehiculo = new DataGridView();
            IdSucursal = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Vehiculo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)data_sucursalxVehiculo).BeginInit();
            SuspendLayout();
            // 
            // comboBox_idsucursal
            // 
            comboBox_idsucursal.FormattingEnabled = true;
            comboBox_idsucursal.Location = new Point(181, 136);
            comboBox_idsucursal.Name = "comboBox_idsucursal";
            comboBox_idsucursal.Size = new Size(151, 28);
            comboBox_idsucursal.TabIndex = 96;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(73, 139);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 93;
            label4.Text = "Sucursal:";
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = SystemColors.ActiveCaptionText;
            btn_consultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar.ForeColor = Color.DeepSkyBlue;
            btn_consultar.Location = new Point(366, 119);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(131, 45);
            btn_consultar.TabIndex = 92;
            btn_consultar.Text = "Consultar";
            btn_consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_consultar.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(815, 502);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 91;
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(211, 27);
            label1.Name = "label1";
            label1.Size = new Size(508, 46);
            label1.TabIndex = 90;
            label1.Text = "Consulta de Vehiculo /Sucursal";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(-1, 491);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 89;
            btn_atras.UseVisualStyleBackColor = false;
            // 
            // data_sucursalxVehiculo
            // 
            data_sucursalxVehiculo.BackgroundColor = Color.Black;
            data_sucursalxVehiculo.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            data_sucursalxVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_sucursalxVehiculo.Columns.AddRange(new DataGridViewColumn[] { IdSucursal, Nombre, Vehiculo, Cantidad });
            data_sucursalxVehiculo.GridColor = SystemColors.HighlightText;
            data_sucursalxVehiculo.Location = new Point(181, 203);
            data_sucursalxVehiculo.Name = "data_sucursalxVehiculo";
            data_sucursalxVehiculo.RowHeadersWidth = 51;
            data_sucursalxVehiculo.Size = new Size(554, 316);
            data_sucursalxVehiculo.TabIndex = 88;
            // 
            // IdSucursal
            // 
            IdSucursal.HeaderText = "Id Sucursal";
            IdSucursal.MinimumWidth = 6;
            IdSucursal.Name = "IdSucursal";
            IdSucursal.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Sucursal";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Vehiculo
            // 
            Vehiculo.HeaderText = "Vehiculo";
            Vehiculo.MinimumWidth = 6;
            Vehiculo.Name = "Vehiculo";
            Vehiculo.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Consulta_vehiculoxsucursal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(891, 564);
            Controls.Add(comboBox_idsucursal);
            Controls.Add(label4);
            Controls.Add(btn_consultar);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Controls.Add(data_sucursalxVehiculo);
            Name = "Consulta_vehiculoxsucursal";
            Text = "Consulta_vehiculoxsucursal";
            ((System.ComponentModel.ISupportInitialize)data_sucursalxVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox_idsucursal;
        private Label label4;
        private Button btn_consultar;
        private Button btn_salir;
        private Label label1;
        private Button btn_atras;
        private DataGridView data_sucursalxVehiculo;
        private DataGridViewTextBoxColumn IdSucursal;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Vehiculo;
        private DataGridViewTextBoxColumn Cantidad;
    }
}