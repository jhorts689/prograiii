namespace AyD.Diseño
{
    partial class Buscar_Profesor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CI_de_profesor = new System.Windows.Forms.Label();
            this.Nombre_Profesor = new System.Windows.Forms.Label();
            this.Apellido_paterno = new System.Windows.Forms.Label();
            this.Apellido_materno = new System.Windows.Forms.Label();
            this.Buscador_profe = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.panel_de_horario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CI_de_profesor);
            this.panel1.Controls.Add(this.Nombre_Profesor);
            this.panel1.Controls.Add(this.Apellido_paterno);
            this.panel1.Controls.Add(this.Apellido_materno);
            this.panel1.Location = new System.Drawing.Point(184, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 141);
            this.panel1.TabIndex = 0;
            // 
            // CI_de_profesor
            // 
            this.CI_de_profesor.AutoSize = true;
            this.CI_de_profesor.Location = new System.Drawing.Point(44, 99);
            this.CI_de_profesor.Name = "CI_de_profesor";
            this.CI_de_profesor.Size = new System.Drawing.Size(0, 13);
            this.CI_de_profesor.TabIndex = 3;
            // 
            // Nombre_Profesor
            // 
            this.Nombre_Profesor.AutoSize = true;
            this.Nombre_Profesor.Location = new System.Drawing.Point(44, 24);
            this.Nombre_Profesor.Name = "Nombre_Profesor";
            this.Nombre_Profesor.Size = new System.Drawing.Size(0, 13);
            this.Nombre_Profesor.TabIndex = 0;
            this.Nombre_Profesor.Click += new System.EventHandler(this.Nombre_Profesor_Click);
            // 
            // Apellido_paterno
            // 
            this.Apellido_paterno.AutoSize = true;
            this.Apellido_paterno.Location = new System.Drawing.Point(44, 48);
            this.Apellido_paterno.Name = "Apellido_paterno";
            this.Apellido_paterno.Size = new System.Drawing.Size(0, 13);
            this.Apellido_paterno.TabIndex = 2;
            // 
            // Apellido_materno
            // 
            this.Apellido_materno.AutoSize = true;
            this.Apellido_materno.Location = new System.Drawing.Point(44, 73);
            this.Apellido_materno.Name = "Apellido_materno";
            this.Apellido_materno.Size = new System.Drawing.Size(0, 13);
            this.Apellido_materno.TabIndex = 1;
            // 
            // Buscador_profe
            // 
            this.Buscador_profe.Location = new System.Drawing.Point(307, 26);
            this.Buscador_profe.Name = "Buscador_profe";
            this.Buscador_profe.Size = new System.Drawing.Size(210, 20);
            this.Buscador_profe.TabIndex = 1;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(523, 24);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_de_horario
            // 
            this.panel_de_horario.AutoScroll = true;
            this.panel_de_horario.Location = new System.Drawing.Point(490, 70);
            this.panel_de_horario.Name = "panel_de_horario";
            this.panel_de_horario.Size = new System.Drawing.Size(250, 260);
            this.panel_de_horario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduzca el CI del profesor -->\r\n";
            // 
            // Buscar_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(759, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_de_horario);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Buscador_profe);
            this.Controls.Add(this.panel1);
            this.Name = "Buscar_Profesor";
            this.Text = "Buscar_Profesor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Apellido_paterno;
        private System.Windows.Forms.Label Apellido_materno;
        private System.Windows.Forms.Label Nombre_Profesor;
        private System.Windows.Forms.TextBox Buscador_profe;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Panel panel_de_horario;
        private System.Windows.Forms.Label CI_de_profesor;
        private System.Windows.Forms.Label label1;
    }
}