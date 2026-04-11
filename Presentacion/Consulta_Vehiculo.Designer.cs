namespace Presentacion
{
    partial class Consulta_Vehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Vehiculo));
            data_vehiculo = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            txt_idvehiculo = new TextBox();
            label4 = new Label();
            btn_consultar = new Button();
            btn_salir = new Button();
            label1 = new Label();
            btn_atras = new Button();
            ((System.ComponentModel.ISupportInitialize)data_vehiculo).BeginInit();
            SuspendLayout();
            // 
            // data_vehiculo
            // 
            data_vehiculo.BackgroundColor = Color.Black;
            data_vehiculo.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            data_vehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_vehiculo.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column2, Column5, Column4, Column6, Column7 });
            data_vehiculo.GridColor = SystemColors.HighlightText;
            data_vehiculo.Location = new Point(32, 176);
            data_vehiculo.Name = "data_vehiculo";
            data_vehiculo.RowHeadersWidth = 51;
            data_vehiculo.Size = new Size(874, 316);
            data_vehiculo.TabIndex = 85;
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
            // txt_idvehiculo
            // 
            txt_idvehiculo.Location = new Point(218, 104);
            txt_idvehiculo.Name = "txt_idvehiculo";
            txt_idvehiculo.ReadOnly = true;
            txt_idvehiculo.Size = new Size(203, 27);
            txt_idvehiculo.TabIndex = 84;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(100, 106);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 83;
            label4.Text = "Id Vehiculo:";
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = SystemColors.ActiveCaptionText;
            btn_consultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar.ForeColor = Color.DeepSkyBlue;
            btn_consultar.Location = new Point(454, 97);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(127, 40);
            btn_consultar.TabIndex = 82;
            btn_consultar.Text = "Consultar";
            btn_consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_consultar.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(908, 524);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 81;
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(328, 29);
            label1.Name = "label1";
            label1.Size = new Size(364, 46);
            label1.TabIndex = 80;
            label1.Text = "Consulta  de Vehiculo";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(23, 514);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 79;
            btn_atras.UseVisualStyleBackColor = false;
            // 
            // Consulta_Vehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 580);
            Controls.Add(data_vehiculo);
            Controls.Add(txt_idvehiculo);
            Controls.Add(label4);
            Controls.Add(btn_consultar);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Name = "Consulta_Vehiculo";
            Text = "Consulta_Vehiculo";
            ((System.ComponentModel.ISupportInitialize)data_vehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data_vehiculo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox txt_idvehiculo;
        private Label label4;
        private Button btn_consultar;
        private Button btn_salir;
        private Label label1;
        private Button btn_atras;
    }
}