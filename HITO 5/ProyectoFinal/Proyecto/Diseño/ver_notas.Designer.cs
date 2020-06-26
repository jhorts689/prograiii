namespace AyD.Diseño
{
    partial class ver_notas
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
            this.Panel_de_asistencia = new System.Windows.Forms.Panel();
            this.CI_de_profesor = new System.Windows.Forms.Label();
            this.Nombre_Profesor = new System.Windows.Forms.Label();
            this.Apellido_paterno = new System.Windows.Forms.Label();
            this.Apellido_materno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.Buscador_tutor = new System.Windows.Forms.TextBox();
            this.Panel_de_asistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_de_asistencia
            // 
            this.Panel_de_asistencia.AutoScroll = true;
            this.Panel_de_asistencia.BackColor = System.Drawing.Color.Black;
            this.Panel_de_asistencia.Controls.Add(this.CI_de_profesor);
            this.Panel_de_asistencia.Controls.Add(this.Nombre_Profesor);
            this.Panel_de_asistencia.Controls.Add(this.Apellido_paterno);
            this.Panel_de_asistencia.Controls.Add(this.Apellido_materno);
            this.Panel_de_asistencia.Location = new System.Drawing.Point(121, 71);
            this.Panel_de_asistencia.Name = "Panel_de_asistencia";
            this.Panel_de_asistencia.Size = new System.Drawing.Size(457, 230);
            this.Panel_de_asistencia.TabIndex = 16;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Introduzca el CI del tutor -->\r\n";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(499, 23);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 14;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Buscador_tutor
            // 
            this.Buscador_tutor.Location = new System.Drawing.Point(283, 25);
            this.Buscador_tutor.Name = "Buscador_tutor";
            this.Buscador_tutor.Size = new System.Drawing.Size(210, 20);
            this.Buscador_tutor.TabIndex = 13;
            // 
            // ver_notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(759, 348);
            this.Controls.Add(this.Panel_de_asistencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Buscador_tutor);
            this.Name = "ver_notas";
            this.Text = "ver_notas";
            this.Panel_de_asistencia.ResumeLayout(false);
            this.Panel_de_asistencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_de_asistencia;
        private System.Windows.Forms.Label CI_de_profesor;
        private System.Windows.Forms.Label Nombre_Profesor;
        private System.Windows.Forms.Label Apellido_paterno;
        private System.Windows.Forms.Label Apellido_materno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox Buscador_tutor;
    }
}