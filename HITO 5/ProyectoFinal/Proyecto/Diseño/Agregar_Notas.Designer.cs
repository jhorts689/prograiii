namespace AyD.Diseño
{
    partial class Agregar_Notas
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
            this.Panel_lista = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.ComboBox();
            this.l_curso = new System.Windows.Forms.Label();
            this.l_materia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materia = new System.Windows.Forms.ComboBox();
            this.curso = new System.Windows.Forms.ComboBox();
            this.b_guardar = new System.Windows.Forms.Button();
            this.Panel_lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_lista
            // 
            this.Panel_lista.AutoScroll = true;
            this.Panel_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.Panel_lista.Controls.Add(this.label3);
            this.Panel_lista.Location = new System.Drawing.Point(31, 73);
            this.Panel_lista.Name = "Panel_lista";
            this.Panel_lista.Size = new System.Drawing.Size(423, 247);
            this.Panel_lista.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(414, 23);
            this.label3.TabIndex = 89;
            this.label3.Text = "N°    Nombres:                                                                   " +
    "                       Nota\r\n\r\n";
            // 
            // Titulo
            // 
            this.Titulo.FormattingEnabled = true;
            this.Titulo.Location = new System.Drawing.Point(453, 12);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(138, 21);
            this.Titulo.TabIndex = 92;
            this.Titulo.Text = "----Seleccione la tarea---";
            this.Titulo.Visible = false;
            this.Titulo.SelectedIndexChanged += new System.EventHandler(this.Titulo_SelectedIndexChanged);
            // 
            // l_curso
            // 
            this.l_curso.ForeColor = System.Drawing.Color.Red;
            this.l_curso.Location = new System.Drawing.Point(41, 41);
            this.l_curso.Name = "l_curso";
            this.l_curso.Size = new System.Drawing.Size(149, 21);
            this.l_curso.TabIndex = 100;
            this.l_curso.Text = "* seleccione un curso";
            this.l_curso.Visible = false;
            // 
            // l_materia
            // 
            this.l_materia.ForeColor = System.Drawing.Color.Red;
            this.l_materia.Location = new System.Drawing.Point(273, 41);
            this.l_materia.Name = "l_materia";
            this.l_materia.Size = new System.Drawing.Size(149, 21);
            this.l_materia.TabIndex = 99;
            this.l_materia.Text = "* Seleccione una materia";
            this.l_materia.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(230, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "materia";
            // 
            // materia
            // 
            this.materia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materia.FormattingEnabled = true;
            this.materia.Location = new System.Drawing.Point(276, 12);
            this.materia.Name = "materia";
            this.materia.Size = new System.Drawing.Size(137, 21);
            this.materia.TabIndex = 97;
            this.materia.Text = "--  Seleccione Materia --";
            this.materia.SelectedIndexChanged += new System.EventHandler(this.materia_SelectedIndexChanged);
            // 
            // curso
            // 
            this.curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curso.FormattingEnabled = true;
            this.curso.Location = new System.Drawing.Point(44, 12);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(137, 21);
            this.curso.TabIndex = 96;
            this.curso.Text = "---  Seleccione Curso ---";
            this.curso.SelectedIndexChanged += new System.EventHandler(this.curso_SelectedIndexChanged);
            // 
            // b_guardar
            // 
            this.b_guardar.Location = new System.Drawing.Point(536, 290);
            this.b_guardar.Name = "b_guardar";
            this.b_guardar.Size = new System.Drawing.Size(103, 30);
            this.b_guardar.TabIndex = 102;
            this.b_guardar.Text = "Guardar";
            this.b_guardar.UseVisualStyleBackColor = true;
            this.b_guardar.Click += new System.EventHandler(this.b_guardar_Click);
            // 
            // Agregar_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(759, 348);
            this.Controls.Add(this.b_guardar);
            this.Controls.Add(this.l_curso);
            this.Controls.Add(this.l_materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materia);
            this.Controls.Add(this.curso);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Panel_lista);
            this.Name = "Agregar_Notas";
            this.Text = "Agregar_Notas";
            this.Panel_lista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_lista;
        private System.Windows.Forms.ComboBox Titulo;
        private System.Windows.Forms.Label l_curso;
        private System.Windows.Forms.Label l_materia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox materia;
        private System.Windows.Forms.ComboBox curso;
        private System.Windows.Forms.Button b_guardar;
        private System.Windows.Forms.Label label3;
    }
}