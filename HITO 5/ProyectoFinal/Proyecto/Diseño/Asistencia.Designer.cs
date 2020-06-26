namespace AyD.Diseño
{
    partial class Asistencia
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
            this.panel_de_horario = new System.Windows.Forms.Panel();
            this.Panel_de_asistencia = new System.Windows.Forms.Panel();
            this.CI_de_profesor = new System.Windows.Forms.Label();
            this.Nombre_Profesor = new System.Windows.Forms.Label();
            this.Apellido_paterno = new System.Windows.Forms.Label();
            this.Apellido_materno = new System.Windows.Forms.Label();
            this.Panel_de_asistencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_de_horario
            // 
            this.panel_de_horario.AutoScroll = true;
            this.panel_de_horario.Location = new System.Drawing.Point(431, 67);
            this.panel_de_horario.Name = "panel_de_horario";
            this.panel_de_horario.Size = new System.Drawing.Size(250, 260);
            this.panel_de_horario.TabIndex = 10;
            // 
            // Panel_de_asistencia
            // 
            this.Panel_de_asistencia.AutoScroll = true;
            this.Panel_de_asistencia.Controls.Add(this.CI_de_profesor);
            this.Panel_de_asistencia.Controls.Add(this.Nombre_Profesor);
            this.Panel_de_asistencia.Controls.Add(this.Apellido_paterno);
            this.Panel_de_asistencia.Controls.Add(this.Apellido_materno);
            this.Panel_de_asistencia.Location = new System.Drawing.Point(78, 70);
            this.Panel_de_asistencia.Name = "Panel_de_asistencia";
            this.Panel_de_asistencia.Size = new System.Drawing.Size(342, 141);
            this.Panel_de_asistencia.TabIndex = 9;
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
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(759, 348);
            this.Controls.Add(this.panel_de_horario);
            this.Controls.Add(this.Panel_de_asistencia);
            this.Name = "Asistencia";
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.Asistencia_Load);
            this.Panel_de_asistencia.ResumeLayout(false);
            this.Panel_de_asistencia.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_de_horario;
        private System.Windows.Forms.Panel Panel_de_asistencia;
        private System.Windows.Forms.Label CI_de_profesor;
        private System.Windows.Forms.Label Nombre_Profesor;
        private System.Windows.Forms.Label Apellido_paterno;
        private System.Windows.Forms.Label Apellido_materno;
    }
}