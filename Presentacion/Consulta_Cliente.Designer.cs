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
            txt_idcliente = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)data_clientes).BeginInit();
            SuspendLayout();
            // 
            // txt_idcliente
            // 
            txt_idcliente.Location = new Point(173, 123);
            txt_idcliente.Name = "txt_idcliente";
            txt_idcliente.ReadOnly = true;
            txt_idcliente.Size = new Size(172, 27);
            txt_idcliente.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(69, 116);
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
            btn_consultar.Text = "Registrar";
            btn_consultar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_consultar.UseVisualStyleBackColor = false;
            // 
            // data_clientes
            // 
            data_clientes.BackgroundColor = Color.Black;
            data_clientes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            data_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_clientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Column6 });
            data_clientes.GridColor = SystemColors.HighlightText;
            data_clientes.Location = new Point(216, 180);
            data_clientes.Name = "data_clientes";
            data_clientes.RowHeadersWidth = 51;
            data_clientes.Size = new Size(761, 316);
            data_clientes.TabIndex = 31;
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
            btn_salir.Location = new Point(1102, 474);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 30;
            btn_salir.UseVisualStyleBackColor = false;
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
            btn_atras.Location = new Point(4, 474);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 28;
            btn_atras.UseVisualStyleBackColor = false;
            // 
            // Consulta_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1148, 549);
            Controls.Add(txt_idcliente);
            Controls.Add(label4);
            Controls.Add(btn_consultar);
            Controls.Add(data_clientes);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Name = "Consulta_Cliente";
            Text = "Consulta_Cliente";
            ((System.ComponentModel.ISupportInitialize)data_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_idcliente;
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
    }
}