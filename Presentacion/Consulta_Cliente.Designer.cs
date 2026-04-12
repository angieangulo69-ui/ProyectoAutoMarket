namespace Presentacion
{
    partial class Consulta_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Cliente));
            label4 = new Label();
            btn_consultar = new Button();
            data_clientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btn_salir = new Button();
            label1 = new Label();
            btn_atras = new Button();
            comboBoxcliente = new ComboBox();
            btn_historial = new Button();
            lbl_info = new Label();
            ((System.ComponentModel.ISupportInitialize)data_clientes).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(95, 117);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 33;
            label4.Text = "Cliente:";
            // 
            // btn_consultar
            // 
            btn_consultar.BackColor = SystemColors.ActiveCaptionText;
            btn_consultar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_consultar.ForeColor = Color.DeepSkyBlue;
            btn_consultar.Location = new Point(389, 107);
            btn_consultar.Name = "btn_consultar";
            btn_consultar.Size = new Size(109, 40);
            btn_consultar.TabIndex = 32;
            btn_consultar.Text = "Consultar";
            btn_consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_consultar.UseVisualStyleBackColor = false;
            btn_consultar.Click += btn_consultar_Click;
            // 
            // data_clientes
            // 
            data_clientes.BackgroundColor = Color.Black;
            data_clientes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            data_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_clientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Column6 });
            data_clientes.GridColor = SystemColors.HighlightText;
            data_clientes.Location = new Point(133, 202);
            data_clientes.Name = "data_clientes";
            data_clientes.RowHeadersWidth = 51;
            data_clientes.Size = new Size(761, 316);
            data_clientes.TabIndex = 31;
            data_clientes.CellContentClick += data_clientes_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id Cliente";
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
            Column5.HeaderText = " Nacimiento";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = " Registro";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Activo";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(917, 483);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 30;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(335, 20);
            label1.Name = "label1";
            label1.Size = new Size(344, 46);
            label1.TabIndex = 29;
            label1.Text = "Consulta de Clientes";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(12, 483);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 28;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // comboBoxcliente
            // 
            comboBoxcliente.FormattingEnabled = true;
            comboBoxcliente.Location = new Point(186, 117);
            comboBoxcliente.Name = "comboBoxcliente";
            comboBoxcliente.Size = new Size(174, 28);
            comboBoxcliente.TabIndex = 34;
            comboBoxcliente.SelectedIndexChanged += comboBoxcliente_SelectedIndexChanged;
            // 
            // btn_historial
            // 
            btn_historial.BackColor = SystemColors.ActiveCaptionText;
            btn_historial.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_historial.ForeColor = Color.DeepSkyBlue;
            btn_historial.Location = new Point(517, 107);
            btn_historial.Name = "btn_historial";
            btn_historial.Size = new Size(109, 40);
            btn_historial.TabIndex = 35;
            btn_historial.Text = "Historial";
            btn_historial.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_historial.UseVisualStyleBackColor = false;
            btn_historial.Click += btn_historial_Click;
            // 
            // lbl_info
            // 
            lbl_info.AutoSize = true;
            lbl_info.Location = new Point(110, 154);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(0, 20);
            lbl_info.TabIndex = 36;
            // 
            // Consulta_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(985, 549);
            Controls.Add(lbl_info);
            Controls.Add(btn_historial);
            Controls.Add(comboBoxcliente);
            Controls.Add(label4);
            Controls.Add(btn_consultar);
            Controls.Add(data_clientes);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Name = "Consulta_Cliente";
            Text = "Consulta_Cliente";
            Load += Consulta_Cliente_Load;
            ((System.ComponentModel.ISupportInitialize)data_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Button btn_consultar;
        private DataGridView data_clientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private Button btn_salir;
        private Label label1;
        private Button btn_atras;
        private ComboBox comboBoxcliente;
        private Button btn_historial;
        private Label lbl_info;
    }
}