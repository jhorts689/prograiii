namespace AyD.Diseño
{
    partial class Buscar_Estudiantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel_de_horario = new System.Windows.Forms.Panel();
            this.Buscar = new System.Windows.Forms.Button();
            this.Buscador_tutor = new System.Windows.Forms.TextBox();
            this.Panel_de_asistencia = new System.Windows.Forms.Panel();
            this.CI_de_profesor = new System.Windows.Forms.Label();
            this.Nombre_Profesor = new System.Windows.Forms.Label();
            this.Apellido_paterno = new System.Windows.Forms.Label();
            this.Apellido_materno = new System.Windows.Forms.Label();
            this.Panel_de_asistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Introduzca el CI del tutor -->\r\n";
            // 
            // panel_de_horario
            // 
            this.panel_de_horario.AutoScroll = true;
            this.panel_de_horario.Location = new System.Drawing.Point(428, 67);
            this.panel_de_horario.Name = "panel_de_horario";
            this.panel_de_horario.Size = new System.Drawing.Size(250, 260);
            this.panel_de_horario.TabIndex = 5;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(461, 21);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 7;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Buscador_tutor
            // 
            this.Buscador_tutor.Location = new System.Drawing.Point(245, 23);
            this.Buscador_tutor.Name = "Buscador_tutor";
            this.Buscador_tutor.Size = new System.Drawing.Size(210, 20);
            this.Buscador_tutor.TabIndex = 6;
            // 
            // Panel_de_asistencia
            // 
            this.Panel_de_asistencia.AutoScroll = true;
            this.Panel_de_asistencia.BackColor = System.Drawing.Color.Black;
            this.Panel_de_asistencia.Controls.Add(this.CI_de_profesor);
            this.Panel_de_asistencia.Controls.Add(this.Nombre_Profesor);
            this.Panel_de_asistencia.Controls.Add(this.Apellido_paterno);
            this.Panel_de_asistencia.Controls.Add(this.Apellido_materno);
            this.Panel_de_asistencia.Location = new System.Drawing.Point(75, 70);
            this.Panel_de_asistencia.Name = "Panel_de_asistencia";
            this.Panel_de_asistencia.Size = new System.Drawing.Size(342, 141);
            this.Panel_de_asistencia.TabIndex = 4;
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
            // Buscar_Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(759, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_de_horario);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Buscador_tutor);
            this.Controls.Add(this.Panel_de_asistencia);
            this.Name = "Buscar_Estudiantes";
            this.Text = "Buscar_Estudiante";
            this.Panel_de_asistencia.ResumeLayout(false);
            this.Panel_de_asistencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_de_horario;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox Buscador_tutor;
        private System.Windows.Forms.Panel Panel_de_asistencia;
        private System.Windows.Forms.Label CI_de_profesor;
        private System.Windows.Forms.Label Nombre_Profesor;
        private System.Windows.Forms.Label Apellido_paterno;
        private System.Windows.Forms.Label Apellido_materno;
    }
}