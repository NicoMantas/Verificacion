namespace Form_verificador
{
    partial class F_verificacion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_verificacion));
            tb_nombre = new TextBox();
            tb_edad = new TextBox();
            tb_resultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tb_historial = new TextBox();
            b_historial = new Button();
            b_limpiar_datos = new Button();
            SuspendLayout();
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(54, 96);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(191, 31);
            tb_nombre.TabIndex = 0;
            tb_nombre.TextChanged += tb_nombre_TextChanged;
            // 
            // tb_edad
            // 
            tb_edad.Location = new Point(54, 189);
            tb_edad.Name = "tb_edad";
            tb_edad.Size = new Size(188, 31);
            tb_edad.TabIndex = 1;
            tb_edad.TextChanged += tb_edad_TextChanged;
            // 
            // tb_resultado
            // 
            tb_resultado.Location = new Point(57, 313);
            tb_resultado.Multiline = true;
            tb_resultado.Name = "tb_resultado";
            tb_resultado.ReadOnly = true;
            tb_resultado.Size = new Size(408, 159);
            tb_resultado.TabIndex = 2;
            tb_resultado.TextChanged += tb_resultado_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 60);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 158);
            label2.Name = "label2";
            label2.Size = new Size(58, 30);
            label2.TabIndex = 4;
            label2.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveBorder;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(66, 280);
            label3.Name = "label3";
            label3.Size = new Size(285, 32);
            label3.TabIndex = 5;
            label3.Text = "Resultados de la Evaluacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveBorder;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(552, 28);
            label4.Name = "label4";
            label4.Size = new Size(205, 32);
            label4.TabIndex = 6;
            label4.Text = "Historial Registros";
            // 
            // tb_historial
            // 
            tb_historial.Location = new Point(504, 73);
            tb_historial.Multiline = true;
            tb_historial.Name = "tb_historial";
            tb_historial.ReadOnly = true;
            tb_historial.Size = new Size(284, 351);
            tb_historial.TabIndex = 7;
            tb_historial.TextChanged += tb_historial_TextChanged;
            // 
            // b_historial
            // 
            b_historial.Location = new Point(608, 430);
            b_historial.Name = "b_historial";
            b_historial.Size = new Size(97, 42);
            b_historial.TabIndex = 8;
            b_historial.Text = "Historial";
            b_historial.UseVisualStyleBackColor = true;
            b_historial.Click += b_historial_Click;
            // 
            // b_limpiar_datos
            // 
            b_limpiar_datos.Location = new Point(277, 217);
            b_limpiar_datos.Name = "b_limpiar_datos";
            b_limpiar_datos.Size = new Size(148, 36);
            b_limpiar_datos.TabIndex = 9;
            b_limpiar_datos.Text = "Limpiar Datos";
            b_limpiar_datos.UseVisualStyleBackColor = true;
            b_limpiar_datos.Click += b_limpiar_datos_Click;
            // 
            // F_verificacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 503);
            Controls.Add(b_limpiar_datos);
            Controls.Add(b_historial);
            Controls.Add(tb_historial);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_resultado);
            Controls.Add(tb_edad);
            Controls.Add(tb_nombre);
            MaximizeBox = false;
            Name = "F_verificacion";
            Text = "Formulario Verificacion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_nombre;
        private TextBox tb_edad;
        private TextBox tb_resultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb_historial;
        private Button b_historial;
        private Button b_limpiar_datos;
    }
}
