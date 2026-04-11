namespace Presentacion
{
    partial class RegistroSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroSucursal));
            checkBox_activo = new CheckBox();
            mastb_telefono = new MaskedTextBox();
            label5 = new Label();
            txt_nombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txt_idsucursal = new TextBox();
            label4 = new Label();
            btn_registrar = new Button();
            data_sucursal = new DataGridView();
            btn_salir = new Button();
            label1 = new Label();
            btn_atras = new Button();
            txt_direccion = new TextBox();
            label6 = new Label();
            label7 = new Label();
            comboBox_encargado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)data_sucursal).BeginInit();
            SuspendLayout();
            // 
            // checkBox_activo
            // 
            checkBox_activo.AutoSize = true;
            checkBox_activo.Location = new Point(148, 313);
            checkBox_activo.Name = "checkBox_activo";
            checkBox_activo.Size = new Size(43, 24);
            checkBox_activo.TabIndex = 57;
            checkBox_activo.Text = "Si";
            checkBox_activo.UseVisualStyleBackColor = true;
            // 
            // mastb_telefono
            // 
            mastb_telefono.Location = new Point(148, 242);
            mastb_telefono.Mask = "0000-0000";
            mastb_telefono.Name = "mastb_telefono";
            mastb_telefono.Size = new Size(203, 27);
            mastb_telefono.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightCoral;
            label5.Location = new Point(9, 244);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 51;
            label5.Text = "Teléfono:";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(147, 157);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(203, 27);
            txt_nombre.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(13, 152);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 49;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(11, 310);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 48;
            label2.Text = "Activo:";
            // 
            // txt_idsucursal
            // 
            txt_idsucursal.Location = new Point(148, 124);
            txt_idsucursal.Name = "txt_idsucursal";
            txt_idsucursal.ReadOnly = true;
            txt_idsucursal.Size = new Size(203, 27);
            txt_idsucursal.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(10, 123);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 46;
            label4.Text = "Id Sucursal:";
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = SystemColors.ActiveCaptionText;
            btn_registrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.ForeColor = Color.DeepSkyBlue;
            btn_registrar.Location = new Point(147, 383);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(109, 40);
            btn_registrar.TabIndex = 45;
            btn_registrar.Text = "Registrar";
            btn_registrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // data_sucursal
            // 
            data_sucursal.BackgroundColor = Color.Black;
            data_sucursal.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            data_sucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_sucursal.GridColor = SystemColors.HighlightText;
            data_sucursal.Location = new Point(393, 102);
            data_sucursal.Name = "data_sucursal";
            data_sucursal.RowHeadersWidth = 51;
            data_sucursal.Size = new Size(761, 316);
            data_sucursal.TabIndex = 44;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(1127, 491);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 43;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(372, 22);
            label1.Name = "label1";
            label1.Size = new Size(371, 46);
            label1.TabIndex = 42;
            label1.Text = "Registro de Sucursales";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(12, 491);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 41;
            btn_atras.UseVisualStyleBackColor = false;
            btn_atras.Click += btn_atras_Click;
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(147, 194);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(204, 27);
            txt_direccion.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightCoral;
            label6.Location = new Point(13, 189);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 58;
            label6.Text = "Dirección:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightCoral;
            label7.Location = new Point(9, 279);
            label7.Name = "label7";
            label7.Size = new Size(107, 25);
            label7.TabIndex = 60;
            label7.Text = "Encargado:";
            // 
            // comboBox_encargado
            // 
            comboBox_encargado.FormattingEnabled = true;
            comboBox_encargado.Location = new Point(147, 278);
            comboBox_encargado.Name = "comboBox_encargado";
            comboBox_encargado.Size = new Size(205, 28);
            comboBox_encargado.TabIndex = 61;
            // 
            // RegistroSucursal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 547);
            Controls.Add(comboBox_encargado);
            Controls.Add(label7);
            Controls.Add(txt_direccion);
            Controls.Add(label6);
            Controls.Add(checkBox_activo);
            Controls.Add(mastb_telefono);
            Controls.Add(label5);
            Controls.Add(txt_nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_idsucursal);
            Controls.Add(label4);
            Controls.Add(btn_registrar);
            Controls.Add(data_sucursal);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Name = "RegistroSucursal";
            Text = "RegistroSucursal";
            Load += RegistroSucursal_Load;
            ((System.ComponentModel.ISupportInitialize)data_sucursal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox_activo;
        private MaskedTextBox mastb_telefono;
        private Label label5;
        private TextBox txt_nombre;
        private Label label3;
        private Label label2;
        private TextBox txt_idsucursal;
        private Label label4;
        private Button btn_registrar;
        private DataGridView data_sucursal;
        private Button btn_salir;
        private Label label1;
        private Button btn_atras;
        private TextBox txt_direccion;
        private Label label6;
        private Label label7;
        private ComboBox comboBox_encargado;
    }
}