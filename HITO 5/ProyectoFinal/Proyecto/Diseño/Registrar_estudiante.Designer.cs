namespace AyD.Diseño
{
    partial class Registrar_estudiante
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
            this.bagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.curso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CI_de_tutor = new System.Windows.Forms.TextBox();
            this.Nombre_del_estudiante = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Apellido_materno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Apellido_paterno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Bregistrar_estudiante = new System.Windows.Forms.Button();
            this.l_ci = new System.Windows.Forms.Label();
            this.l_curso = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bagregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCurso);
            this.panel1.Location = new System.Drawing.Point(558, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 219);
            this.panel1.TabIndex = 0;
            // 
            // bagregar
            // 
            this.bagregar.Location = new System.Drawing.Point(52, 131);
            this.bagregar.Name = "bagregar";
            this.bagregar.Size = new System.Drawing.Size(75, 23);
            this.bagregar.TabIndex = 3;
            this.bagregar.Text = "Agregar";
            this.bagregar.UseVisualStyleBackColor = true;
            this.bagregar.Click += new System.EventHandler(this.bagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar nuevo curso";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(24, 84);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(126, 20);
            this.txtCurso.TabIndex = 1;
            // 
            // curso
            // 
            this.curso.FormattingEnabled = true;
            this.curso.Location = new System.Drawing.Point(205, 200);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(137, 21);
            this.curso.TabIndex = 1;
            this.curso.Text = "----  seleccione curso ----";
            this.curso.SelectedIndexChanged += new System.EventHandler(this.curso_SelectedIndexChanged);
            this.curso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.curso_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label7.Location = new System.Drawing.Point(100, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "CI: del padre o tutor";
            // 
            // CI_de_tutor
            // 
            this.CI_de_tutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CI_de_tutor.Location = new System.Drawing.Point(205, 165);
            this.CI_de_tutor.Margin = new System.Windows.Forms.Padding(2);
            this.CI_de_tutor.Name = "CI_de_tutor";
            this.CI_de_tutor.Size = new System.Drawing.Size(173, 13);
            this.CI_de_tutor.TabIndex = 35;
            // 
            // Nombre_del_estudiante
            // 
            this.Nombre_del_estudiante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre_del_estudiante.Location = new System.Drawing.Point(205, 75);
            this.Nombre_del_estudiante.Name = "Nombre_del_estudiante";
            this.Nombre_del_estudiante.Size = new System.Drawing.Size(173, 13);
            this.Nombre_del_estudiante.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label6.Location = new System.Drawing.Point(88, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Nombre del estudiante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(116, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Apellido materno";
            // 
            // Apellido_materno
            // 
            this.Apellido_materno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellido_materno.Location = new System.Drawing.Point(205, 134);
            this.Apellido_materno.Margin = new System.Windows.Forms.Padding(2);
            this.Apellido_materno.Name = "Apellido_materno";
            this.Apellido_materno.Size = new System.Drawing.Size(173, 13);
            this.Apellido_materno.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(118, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Apellido paterno";
            // 
            // Apellido_paterno
            // 
            this.Apellido_paterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellido_paterno.Location = new System.Drawing.Point(205, 104);
            this.Apellido_paterno.Margin = new System.Windows.Forms.Padding(2);
            this.Apellido_paterno.Name = "Apellido_paterno";
            this.Apellido_paterno.Size = new System.Drawing.Size(173, 13);
            this.Apellido_paterno.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label9.Location = new System.Drawing.Point(167, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Curso";
            // 
            // Bregistrar_estudiante
            // 
            this.Bregistrar_estudiante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.Bregistrar_estudiante.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.Bregistrar_estudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Bregistrar_estudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.Bregistrar_estudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bregistrar_estudiante.ForeColor = System.Drawing.Color.LightGray;
            this.Bregistrar_estudiante.Location = new System.Drawing.Point(205, 255);
            this.Bregistrar_estudiante.Name = "Bregistrar_estudiante";
            this.Bregistrar_estudiante.Size = new System.Drawing.Size(88, 31);
            this.Bregistrar_estudiante.TabIndex = 37;
            this.Bregistrar_estudiante.Text = "guardar";
            this.Bregistrar_estudiante.UseVisualStyleBackColor = false;
            this.Bregistrar_estudiante.Click += new System.EventHandler(this.button2_Click);
            // 
            // l_ci
            // 
            this.l_ci.AutoSize = true;
            this.l_ci.ForeColor = System.Drawing.Color.Red;
            this.l_ci.Location = new System.Drawing.Point(383, 165);
            this.l_ci.Name = "l_ci";
            this.l_ci.Size = new System.Drawing.Size(155, 13);
            this.l_ci.TabIndex = 38;
            this.l_ci.Text = "*ingrese solo valores numericos";
            this.l_ci.Visible = false;
            // 
            // l_curso
            // 
            this.l_curso.AutoSize = true;
            this.l_curso.ForeColor = System.Drawing.Color.Red;
            this.l_curso.Location = new System.Drawing.Point(350, 205);
            this.l_curso.Name = "l_curso";
            this.l_curso.Size = new System.Drawing.Size(106, 13);
            this.l_curso.TabIndex = 39;
            this.l_curso.Text = "*seleccione un curso";
            this.l_curso.Visible = false;
            // 
            // Registrar_estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(759, 348);
            this.Controls.Add(this.l_curso);
            this.Controls.Add(this.l_ci);
            this.Controls.Add(this.Bregistrar_estudiante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CI_de_tutor);
            this.Controls.Add(this.Nombre_del_estudiante);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Apellido_materno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Apellido_paterno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.curso);
            this.Controls.Add(this.panel1);
            this.Name = "Registrar_estudiante";
            this.Text = "Registrar_estudiante";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bagregar;
        private System.Windows.Forms.ComboBox curso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CI_de_tutor;
        private System.Windows.Forms.TextBox Nombre_del_estudiante;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Apellido_materno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Apellido_paterno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Bregistrar_estudiante;
        private System.Windows.Forms.Label l_ci;
        private System.Windows.Forms.Label l_curso;
    }
}