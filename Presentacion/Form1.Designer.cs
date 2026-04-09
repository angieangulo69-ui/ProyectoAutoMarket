namespace Presentacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btn_registros = new Button();
            btn_consulta = new Button();
            btn_salir = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Snap ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSpringGreen;
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 51);
            label1.TabIndex = 0;
            label1.Text = "AutoMarket";
            // 
            // btn_registros
            // 
            btn_registros.BackColor = Color.Black;
            btn_registros.BackgroundImage = (Image)resources.GetObject("btn_registros.BackgroundImage");
            btn_registros.BackgroundImageLayout = ImageLayout.Stretch;
            btn_registros.Location = new Point(192, 154);
            btn_registros.Name = "btn_registros";
            btn_registros.Size = new Size(84, 78);
            btn_registros.TabIndex = 1;
            btn_registros.UseVisualStyleBackColor = false;
            btn_registros.Click += btn_registros_Click;
            // 
            // btn_consulta
            // 
            btn_consulta.BackColor = Color.Black;
            btn_consulta.BackgroundImage = (Image)resources.GetObject("btn_consulta.BackgroundImage");
            btn_consulta.BackgroundImageLayout = ImageLayout.Stretch;
            btn_consulta.Location = new Point(525, 154);
            btn_consulta.Name = "btn_consulta";
            btn_consulta.Size = new Size(84, 78);
            btn_consulta.TabIndex = 2;
            btn_consulta.UseVisualStyleBackColor = false;
            btn_consulta.Click += btn_consulta_Click;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.Black;
            btn_salir.BackgroundImage = (Image)resources.GetObject("btn_salir.BackgroundImage");
            btn_salir.BackgroundImageLayout = ImageLayout.Stretch;
            btn_salir.Location = new Point(21, 392);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(50, 46);
            btn_salir.TabIndex = 3;
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(192, 235);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 4;
            label2.Text = "Registrar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(525, 235);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 5;
            label3.Text = "Consultar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Salmon;
            label4.Location = new Point(12, 69);
            label4.Name = "label4";
            label4.Size = new Size(220, 36);
            label4.TabIndex = 6;
            label4.Text = "Bienvenidos(a):";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_salir);
            Controls.Add(btn_consulta);
            Controls.Add(btn_registros);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_registros;
        private Button btn_consulta;
        private Button btn_salir;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}