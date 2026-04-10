namespace Presentacion
{
    partial class Registro_Vendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Vendedor));
            dateTimeNacimiento = new DateTimePicker();
            dateTimeIngreso = new DateTimePicker();
            mask_identificacion = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txt_nombre = new TextBox();
            label3 = new Label();
            txt_idvendedor = new TextBox();
            label4 = new Label();
            btn_registrar = new Button();
            label1 = new Label();
            data_clientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btn_salir = new Button();
            btn_atras = new Button();
            label2 = new Label();
            mask_telefono = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)data_clientes).BeginInit();
            SuspendLayout();
            // 
            // dateTimeNacimiento
            // 
            dateTimeNacimiento.Location = new Point(180, 328);
            dateTimeNacimiento.Name = "dateTimeNacimiento";
            dateTimeNacimiento.Size = new Size(173, 27);
            dateTimeNacimiento.TabIndex = 53;
            // 
            // dateTimeIngreso
            // 
            dateTimeIngreso.Location = new Point(182, 295);
            dateTimeIngreso.Name = "dateTimeIngreso";
            dateTimeIngreso.Size = new Size(173, 27);
            dateTimeIngreso.TabIndex = 52;
            // 
            // mask_identificacion
            // 
            mask_identificacion.Location = new Point(181, 185);
            mask_identificacion.Mask = "0-0000-0000";
            mask_identificacion.Name = "mask_identificacion";
            mask_identificacion.Size = new Size(172, 27);
            mask_identificacion.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightCoral;
            label7.Location = new Point(12, 324);
            label7.Name = "label7";
            label7.Size = new Size(169, 25);
            label7.TabIndex = 50;
            label7.Text = "Fecha Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightCoral;
            label6.Location = new Point(12, 290);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 49;
            label6.Text = "Fecha Ingreso:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightCoral;
            label5.Location = new Point(12, 183);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 48;
            label5.Text = "Identificación:";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(181, 221);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(172, 27);
            txt_nombre.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(12, 220);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 46;
            label3.Text = "Nombre:";
            // 
            // txt_idvendedor
            // 
            txt_idvendedor.Location = new Point(181, 144);
            txt_idvendedor.Name = "txt_idvendedor";
            txt_idvendedor.ReadOnly = true;
            txt_idvendedor.Size = new Size(172, 27);
            txt_idvendedor.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 43;
            label4.Text = "Id Vendedor:";
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = SystemColors.ActiveCaptionText;
            btn_registrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.ForeColor = Color.DeepSkyBlue;
            btn_registrar.Location = new Point(147, 381);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(109, 40);
            btn_registrar.TabIndex = 42;
            btn_registrar.Text = "Registrar";
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
            label1.Location = new Point(32, 52);
            label1.Name = "label1";
            label1.Size = new Size(390, 46);
            label1.TabIndex = 41;
            label1.Text = "Registro de Vendedores";
            // 
            // data_clientes
            // 
            data_clientes.BackgroundColor = Color.Black;
            data_clientes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            data_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_clientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Column6 });
            data_clientes.GridColor = SystemColors.HighlightText;
            data_clientes.Location = new Point(382, 105);
            data_clientes.Name = "data_clientes";
            data_clientes.RowHeadersWidth = 51;
            data_clientes.Size = new Size(761, 316);
            data_clientes.TabIndex = 57;
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
            btn_salir.Location = new Point(1153, 529);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 56;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(12, 529);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 55;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(12, 258);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 59;
            label2.Text = "Teléfono:";
            // 
            // mask_telefono
            // 
            mask_telefono.Location = new Point(183, 261);
            mask_telefono.Mask = "0000-0000";
            mask_telefono.Name = "mask_telefono";
            mask_telefono.Size = new Size(172, 27);
            mask_telefono.TabIndex = 60;
            // 
            // Registro_Vendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1217, 585);
            Controls.Add(mask_telefono);
            Controls.Add(label2);
            Controls.Add(data_clientes);
            Controls.Add(btn_salir);
            Controls.Add(btn_atras);
            Controls.Add(dateTimeNacimiento);
            Controls.Add(dateTimeIngreso);
            Controls.Add(mask_identificacion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_nombre);
            Controls.Add(label3);
            Controls.Add(txt_idvendedor);
            Controls.Add(label4);
            Controls.Add(btn_registrar);
            Controls.Add(label1);
            Name = "Registro_Vendedor";
            Text = "Registro_Vendedor";
            Load += Registro_Vendedor_Load;
            ((System.ComponentModel.ISupportInitialize)data_clientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimeNacimiento;
        private DateTimePicker dateTimeIngreso;
        private MaskedTextBox mask_identificacion;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txt_nombre;
        private Label label3;
        private TextBox txt_idvendedor;
        private Label label4;
        private Button btn_registrar;
        private Label label1;
        private DataGridView data_clientes;
        private Button btn_salir;
        private Button btn_atras;
        private Label label2;
        private MaskedTextBox mask_telefono;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
    }
}