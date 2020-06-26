namespace AyD.Diseño
{
    partial class Control_de_Asistencia
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
            this.l_curso = new System.Windows.Forms.Label();
            this.l_materia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.curso = new System.Windows.Forms.ComboBox();
            this.dateTime_fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.b_guardar_cambios = new System.Windows.Forms.Button();
            this.Panel_lista = new System.Windows.Forms.Panel();
            this.Panel_lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_curso
            // 
            this.l_curso.ForeColor = System.Drawing.Color.Red;
            this.l_curso.Location = new System.Drawing.Point(59, 42);
            this.l_curso.Name = "l_curso";
            this.l_curso.Size = new System.Drawing.Size(149, 21);
            this.l_curso.TabIndex = 89;
            this.l_curso.Text = "* seleccione un curso";
            this.l_curso.Visible = false;
            // 
            // l_materia
            // 
            this.l_materia.ForeColor = System.Drawing.Color.Red;
            this.l_materia.Location = new System.Drawing.Point(291, 42);
            this.l_materia.Name = "l_materia";
            this.l_materia.Size = new System.Drawing.Size(149, 26);
            this.l_materia.TabIndex = 88;
            this.l_materia.Text = "* Seleccione una materia";
            this.l_materia.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(248, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "materia";
            // 
            // materia
            // 
            this.materia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materia.FormattingEnabled = true;
            this.materia.Location = new System.Drawing.Point(294, 18);
            this.materia.Name = "materia";
            this.materia.Size = new System.Drawing.Size(137, 21);
            this.materia.TabIndex = 86;
            this.materia.Text = "--  Seleccione Materia --";
            this.materia.SelectedIndexChanged += new System.EventHandler(this.materia_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "curso";
            // 
            // curso
            // 
            this.curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curso.FormattingEnabled = true;
            this.curso.Location = new System.Drawing.Point(62, 18);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(137, 21);
            this.curso.TabIndex = 84;
            this.curso.Text = "---  Seleccione Curso ---";
            this.curso.SelectedIndexChanged += new System.EventHandler(this.curso_SelectedIndexChanged);
            // 
            // dateTime_fecha
            // 
            this.dateTime_fecha.Location = new System.Drawing.Point(477, 18);
            this.dateTime_fecha.Name = "dateTime_fecha";
            this.dateTime_fecha.Size = new System.Drawing.Size(200, 20);
            this.dateTime_fecha.TabIndex = 91;
            this.dateTime_fecha.ValueChanged += new System.EventHandler(this.dateTime_fecha_ValueChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(17, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 23);
            this.label3.TabIndex = 88;
            this.label3.Text = "N°    Nombres:                                                                   " +
    "                       Asistencia\r\n";
            // 
            // b_guardar_cambios
            // 
            this.b_guardar_cambios.Location = new System.Drawing.Point(538, 288);
            this.b_guardar_cambios.Name = "b_guardar_cambios";
            this.b_guardar_cambios.Size = new System.Drawing.Size(155, 32);
            this.b_guardar_cambios.TabIndex = 93;
            this.b_guardar_cambios.Text = "Guardar Cambios";
            this.b_guardar_cambios.UseVisualStyleBackColor = true;
            this.b_guardar_cambios.Click += new System.EventHandler(this.b_guardar_cambios_Click);
            // 
            // Panel_lista
            // 
            this.Panel_lista.AutoScroll = true;
            this.Panel_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.Panel_lista.Controls.Add(this.label3);
            this.Panel_lista.Location = new System.Drawing.Point(20, 88);
            this.Panel_lista.Name = "Panel_lista";
            this.Panel_lista.Size = new System.Drawing.Size(452, 247);
            this.Panel_lista.TabIndex = 90;
            // 
            // Control_de_Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(759, 348);
            this.Controls.Add(this.b_guardar_cambios);
            this.Controls.Add(this.dateTime_fecha);
            this.Controls.Add(this.Panel_lista);
            this.Controls.Add(this.l_curso);
            this.Controls.Add(this.l_materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.curso);
            this.Name = "Control_de_Asistencia";
            this.Text = "Control_de_Asistencia";
            this.Panel_lista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_curso;
        private System.Windows.Forms.Label l_materia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox materia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox curso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTime_fecha;
        private System.Windows.Forms.Button b_guardar_cambios;
        private System.Windows.Forms.Panel Panel_lista;
    }
}