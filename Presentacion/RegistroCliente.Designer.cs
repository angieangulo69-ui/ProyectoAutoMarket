
namespace Presentacion
{
    partial class RegistroCliente
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCliente));
            txt_idcliente = new TextBox();
            label4 = new Label();
            btn_registrar = new Button();
            data_clientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            logicaClienteBindingSource = new BindingSource(components);
            btn_salir = new Button();
            label1 = new Label();
            btn_atras = new Button();
            label2 = new Label();
            txt_nombre = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            mask_identificacion = new MaskedTextBox();
            dateTimeRegistro = new DateTimePicker();
            dateTimeNacimiento = new DateTimePicker();
            checkBox_activo = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)data_clientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logicaClienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txt_idcliente
            // 
            txt_idcliente.Location = new Point(181, 108);
            txt_idcliente.Name = "txt_idcliente";
            txt_idcliente.ReadOnly = true;
            txt_idcliente.Size = new Size(172, 27);
            txt_idcliente.TabIndex = 27;
            txt_idcliente.TextChanged += txt_idcliente_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(12, 107);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 26;
            label4.Text = "Id Cliente:";
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = SystemColors.ActiveCaptionText;
            btn_registrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.ForeColor = Color.DeepSkyBlue;
            btn_registrar.Location = new Point(147, 345);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(109, 40);
            btn_registrar.TabIndex = 25;
            btn_registrar.Text = "Registrar";
            btn_registrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // data_clientes
            // 
            data_clientes.BackgroundColor = Color.Black;
            data_clientes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            data_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_clientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column5, Column4, Column6 });
            data_clientes.GridColor = SystemColors.HighlightText;
            data_clientes.Location = new Point(392, 91);
            data_clientes.Name = "data_clientes";
            data_clientes.RowHeadersWidth = 51;
            data_clientes.Size = new Size(761, 316);
            data_clientes.TabIndex = 24;
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
            // logicaClienteBindingSource
            // 
            logicaClienteBindingSource.DataSource = typeof(Logica.Logica_Cliente);
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(1110, 459);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 23;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(32, 16);
            label1.Name = "label1";
            label1.Size = new Size(333, 46);
            label1.TabIndex = 22;
            label1.Text = "Registro de Clientes";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(12, 459);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 21;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 28;
            label2.Text = "Activo:";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(181, 185);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(172, 27);
            txt_nombre.TabIndex = 31;
            txt_nombre.TextChanged += txt_nombre_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 30;
            label3.Text = "Nombre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightCoral;
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 32;
            label5.Text = "Identificación:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightCoral;
            label6.Location = new Point(12, 254);
            label6.Name = "label6";
            label6.Size = new Size(142, 25);
            label6.TabIndex = 34;
            label6.Text = "Fecha Registro:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightCoral;
            label7.Location = new Point(12, 288);
            label7.Name = "label7";
            label7.Size = new Size(169, 25);
            label7.TabIndex = 35;
            label7.Text = "Fecha Nacimiento:";
            // 
            // mask_identificacion
            // 
            mask_identificacion.Location = new Point(181, 149);
            mask_identificacion.Mask = "0-0000-0000";
            mask_identificacion.Name = "mask_identificacion";
            mask_identificacion.Size = new Size(172, 27);
            mask_identificacion.TabIndex = 36;
            // 
            // dateTimeRegistro
            // 
            dateTimeRegistro.Location = new Point(182, 259);
            dateTimeRegistro.Name = "dateTimeRegistro";
            dateTimeRegistro.Size = new Size(173, 27);
            dateTimeRegistro.TabIndex = 37;
            // 
            // dateTimeNacimiento
            // 
            dateTimeNacimiento.Location = new Point(180, 292);
            dateTimeNacimiento.Name = "dateTimeNacimiento";
            dateTimeNacimiento.Size = new Size(173, 27);
            dateTimeNacimiento.TabIndex = 38;
            // 
            // checkBox_activo
            // 
            checkBox_activo.AutoSize = true;
            checkBox_activo.Location = new Point(182, 221);
            checkBox_activo.Name = "checkBox_activo";
            checkBox_activo.Size = new Size(43, 24);
            checkBox_activo.TabIndex = 40;
            checkBox_activo.Text = "Si";
            checkBox_activo.UseVisualStyleBackColor = true;
            checkBox_activo.CheckedChanged += checkBox_activo_CheckedChanged;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1165, 515);
            Controls.Add(checkBox_activo);
            Controls.Add(dateTimeNacimiento);
            Controls.Add(dateTimeRegistro);
            Controls.Add(mask_identificacion);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_idcliente);
            Controls.Add(label4);
            Controls.Add(btn_registrar);
            Controls.Add(data_clientes);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Name = "RegistroCliente";
            Text = "RegistroCliente";
            Load += RegistroCliente_Load;
            ((System.ComponentModel.ISupportInitialize)data_clientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)logicaClienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void checkListBox_activo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void data_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dateTimeNacimiento_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimeRegistro_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void mask_identificacion_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void txt_idcliente_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
           
        }

        #endregion

        private TextBox txt_idcliente;
        private Label label4;
        private Button btn_registrar;
        private DataGridView data_clientes;
        private Button btn_salir;
        private Label label1;
        private Button btn_atras;
        private Label label2;
        private TextBox txt_nombre;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private MaskedTextBox mask_identificacion;
        private DateTimePicker dateTimeRegistro;
        private DateTimePicker dateTimeNacimiento;
        private CheckBox checkBox_activo;
        private BindingSource logicaClienteBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
    }
}