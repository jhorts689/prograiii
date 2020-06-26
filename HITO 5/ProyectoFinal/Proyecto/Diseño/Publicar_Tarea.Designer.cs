namespace AyD.Diseño
{
    partial class Publicar_Tarea
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
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.B_publicar = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_curso
            // 
            this.l_curso.ForeColor = System.Drawing.Color.Red;
            this.l_curso.Location = new System.Drawing.Point(118, 45);
            this.l_curso.Name = "l_curso";
            this.l_curso.Size = new System.Drawing.Size(149, 21);
            this.l_curso.TabIndex = 95;
            this.l_curso.Text = "* seleccione un curso";
            this.l_curso.Visible = false;
            // 
            // l_materia
            // 
            this.l_materia.ForeColor = System.Drawing.Color.Red;
            this.l_materia.Location = new System.Drawing.Point(350, 45);
            this.l_materia.Name = "l_materia";
            this.l_materia.Size = new System.Drawing.Size(149, 21);
            this.l_materia.TabIndex = 94;
            this.l_materia.Text = "* Seleccione una materia";
            this.l_materia.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(307, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 93;
            this.label2.Text = "materia";
            // 
            // materia
            // 
            this.materia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materia.FormattingEnabled = true;
            this.materia.Items.AddRange(new object[] {
            "primeroA"});
            this.materia.Location = new System.Drawing.Point(353, 16);
            this.materia.Name = "materia";
            this.materia.Size = new System.Drawing.Size(137, 21);
            this.materia.TabIndex = 92;
            this.materia.Text = "--  Seleccione Materia --";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(83, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 91;
            this.label9.Text = "curso";
            // 
            // curso
            // 
            this.curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curso.FormattingEnabled = true;
            this.curso.Location = new System.Drawing.Point(121, 16);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(137, 21);
            this.curso.TabIndex = 90;
            this.curso.Text = "---  Seleccione Curso ---";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(121, 278);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 96;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(121, 138);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(432, 107);
            this.descripcion.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 98;
            this.label1.Text = "Fecha De Entrega";
            // 
            // B_publicar
            // 
            this.B_publicar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.B_publicar.Location = new System.Drawing.Point(651, 303);
            this.B_publicar.Name = "B_publicar";
            this.B_publicar.Size = new System.Drawing.Size(75, 23);
            this.B_publicar.TabIndex = 99;
            this.B_publicar.Text = "PUBLICAR";
            this.B_publicar.UseVisualStyleBackColor = true;
            this.B_publicar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(121, 95);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(167, 20);
            this.Titulo.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(120, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(121, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 102;
            this.label4.Text = "Titulo";
            // 
            // Publicar_Tarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(759, 348);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.B_publicar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.l_curso);
            this.Controls.Add(this.l_materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.curso);
            this.Name = "Publicar_Tarea";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Publicar_Tarea_Load);
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
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_publicar;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}