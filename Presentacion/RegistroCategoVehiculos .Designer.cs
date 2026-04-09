namespace Presentacion
{
    partial class RegistroCategoVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCategoVehiculos));
            label2 = new Label();
            label1 = new Label();
            btn_atras = new Button();
            btn_salir = new Button();
            label3 = new Label();
            txt_nombre = new TextBox();
            txt_descripcion = new TextBox();
            data_categoriavehiculos = new DataGridView();
            btn_registrar = new Button();
            label4 = new Label();
            txt_idcategoria = new TextBox();
            ((System.ComponentModel.ISupportInitialize)data_categoriavehiculos).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(61, 141);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 12;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(573, 46);
            label1.TabIndex = 11;
            label1.Text = "Registro de Categoría de Vehiculos:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(12, 394);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 10;
            btn_atras.UseVisualStyleBackColor = false;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(745, 394);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 13;
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(36, 177);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 14;
            label3.Text = "Descripción:";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(161, 145);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(125, 27);
            txt_nombre.TabIndex = 15;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(161, 178);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(125, 27);
            txt_descripcion.TabIndex = 16;
            // 
            // data_categoriavehiculos
            // 
            data_categoriavehiculos.BackgroundColor = Color.Black;
            data_categoriavehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_categoriavehiculos.GridColor = SystemColors.HighlightText;
            data_categoriavehiculos.Location = new Point(393, 99);
            data_categoriavehiculos.Name = "data_categoriavehiculos";
            data_categoriavehiculos.RowHeadersWidth = 51;
            data_categoriavehiculos.Size = new Size(300, 188);
            data_categoriavehiculos.TabIndex = 17;
            data_categoriavehiculos.CellContentClick += data_categoriavehiculos_CellContentClick;
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = SystemColors.ActiveCaptionText;
            btn_registrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.ForeColor = Color.DeepSkyBlue;
            btn_registrar.Location = new Point(44, 273);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(109, 40);
            btn_registrar.TabIndex = 18;
            btn_registrar.Text = "Registrar";
            btn_registrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_registrar.UseVisualStyleBackColor = false;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(113, 107);
            label4.Name = "label4";
            label4.Size = new Size(34, 25);
            label4.TabIndex = 19;
            label4.Text = "Id:";
            // 
            // txt_idcategoria
            // 
            txt_idcategoria.Location = new Point(161, 108);
            txt_idcategoria.Name = "txt_idcategoria";
            txt_idcategoria.ReadOnly = true;
            txt_idcategoria.Size = new Size(125, 27);
            txt_idcategoria.TabIndex = 20;
            // 
            // RegistroCategoVehiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(txt_idcategoria);
            Controls.Add(label4);
            Controls.Add(btn_registrar);
            Controls.Add(data_categoriavehiculos);
            Controls.Add(txt_descripcion);
            Controls.Add(txt_nombre);
            Controls.Add(label3);
            Controls.Add(btn_salir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Name = "RegistroCategoVehiculos";
            Text = "RegistroCategoVehiculos";
            ((System.ComponentModel.ISupportInitialize)data_categoriavehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btn_atras;
        private Button btn_salir;
        private Label label3;
        private TextBox txt_nombre;
        private TextBox txt_descripcion;
        private DataGridView data_categoriavehiculos;
        private Button btn_registrar;
        private Label label4;
        private TextBox txt_idcategoria;
    }
}