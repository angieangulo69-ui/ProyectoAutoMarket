namespace Presentacion
{
    partial class Consulta_Categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Categoria));
            txt_idcategoria = new TextBox();
            label4 = new Label();
            btn_registrar = new Button();
            data_categoriavehiculos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            btn_salir = new Button();
            label1 = new Label();
            btn_atras = new Button();
            ((System.ComponentModel.ISupportInitialize)data_categoriavehiculos).BeginInit();
            SuspendLayout();
            // 
            // txt_idcategoria
            // 
            txt_idcategoria.Location = new Point(161, 105);
            txt_idcategoria.Name = "txt_idcategoria";
            txt_idcategoria.ReadOnly = true;
            txt_idcategoria.Size = new Size(125, 27);
            txt_idcategoria.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightCoral;
            label4.Location = new Point(48, 107);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 30;
            label4.Text = "Categoría:";
            // 
            // btn_registrar
            // 
            btn_registrar.BackColor = SystemColors.ActiveCaptionText;
            btn_registrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar.ForeColor = Color.DeepSkyBlue;
            btn_registrar.Location = new Point(319, 92);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(109, 40);
            btn_registrar.TabIndex = 29;
            btn_registrar.Text = "Registrar";
            btn_registrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_registrar.UseVisualStyleBackColor = false;
            // 
            // data_categoriavehiculos
            // 
            data_categoriavehiculos.BackgroundColor = Color.Black;
            data_categoriavehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_categoriavehiculos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Descripción });
            data_categoriavehiculos.GridColor = SystemColors.HighlightText;
            data_categoriavehiculos.Location = new Point(161, 168);
            data_categoriavehiculos.Name = "data_categoriavehiculos";
            data_categoriavehiculos.RowHeadersWidth = 51;
            data_categoriavehiculos.Size = new Size(395, 188);
            data_categoriavehiculos.TabIndex = 28;
            // 
            // Id
            // 
            Id.HeaderText = "Id Categoría";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.MinimumWidth = 6;
            Descripción.Name = "Descripción";
            Descripción.Width = 125;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(745, 391);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(43, 44);
            btn_salir.TabIndex = 24;
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orange;
            label1.Location = new Point(85, 27);
            label1.Name = "label1";
            label1.Size = new Size(584, 46);
            label1.TabIndex = 22;
            label1.Text = "Consulta de Categoría de Vehiculos:";
            // 
            // btn_atras
            // 
            btn_atras.BackColor = Color.Black;
            btn_atras.BackgroundImage = (Image)resources.GetObject("btn_atras.BackgroundImage");
            btn_atras.BackgroundImageLayout = ImageLayout.Stretch;
            btn_atras.Location = new Point(12, 391);
            btn_atras.Name = "btn_atras";
            btn_atras.Size = new Size(43, 44);
            btn_atras.TabIndex = 21;
            btn_atras.UseVisualStyleBackColor = false;
            // 
            // Consulta_Categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(txt_idcategoria);
            Controls.Add(label4);
            Controls.Add(btn_registrar);
            Controls.Add(data_categoriavehiculos);
            Controls.Add(btn_salir);
            Controls.Add(label1);
            Controls.Add(btn_atras);
            Name = "Consulta_Categoria";
            Text = "Consulta_Categoria";
            ((System.ComponentModel.ISupportInitialize)data_categoriavehiculos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_idcategoria;
        private Label label4;
        private Button btn_registrar;
        private DataGridView data_categoriavehiculos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripción;
        private Button btn_salir;
        private Label label1;
        private Button btn_atras;
    }
}