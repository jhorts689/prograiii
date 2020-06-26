namespace AyD.Diseño
{
    partial class CrearHorario
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
            this.label10 = new System.Windows.Forms.Label();
            this.de_minutos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.de_hora = new System.Windows.Forms.ComboBox();
            this.Lhorario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.materia = new System.Windows.Forms.ComboBox();
            this.B_Crear_Horario = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.curso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CI_de_profesor = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_materia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmateria = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_curso = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hasta_minutos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hasta_hora = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dia = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.L_error_CI = new System.Windows.Forms.Label();
            this.l_materia = new System.Windows.Forms.Label();
            this.l_curso = new System.Windows.Forms.Label();
            this.l_dia = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label10.Location = new System.Drawing.Point(401, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "min.";
            // 
            // de_minutos
            // 
            this.de_minutos.FormattingEnabled = true;
            this.de_minutos.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.de_minutos.Location = new System.Drawing.Point(358, 229);
            this.de_minutos.Name = "de_minutos";
            this.de_minutos.Size = new System.Drawing.Size(43, 21);
            this.de_minutos.TabIndex = 67;
            this.de_minutos.Text = "00";
            this.de_minutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.de_minutos_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label8.Location = new System.Drawing.Point(327, 234);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Hrs.";
            // 
            // de_hora
            // 
            this.de_hora.FormattingEnabled = true;
            this.de_hora.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.de_hora.Location = new System.Drawing.Point(284, 229);
            this.de_hora.Name = "de_hora";
            this.de_hora.Size = new System.Drawing.Size(43, 21);
            this.de_hora.TabIndex = 65;
            this.de_hora.Text = "00";
            this.de_hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.de_hora_KeyPress);
            // 
            // Lhorario
            // 
            this.Lhorario.AutoSize = true;
            this.Lhorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.Lhorario.ForeColor = System.Drawing.Color.Black;
            this.Lhorario.Location = new System.Drawing.Point(209, 212);
            this.Lhorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lhorario.Name = "Lhorario";
            this.Lhorario.Size = new System.Drawing.Size(41, 13);
            this.Lhorario.TabIndex = 64;
            this.Lhorario.Text = "Horario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(206, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "materia";
            // 
            // materia
            // 
            this.materia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materia.FormattingEnabled = true;
            this.materia.Location = new System.Drawing.Point(255, 135);
            this.materia.Name = "materia";
            this.materia.Size = new System.Drawing.Size(137, 21);
            this.materia.TabIndex = 61;
            this.materia.Text = "--  Seleccione Materia --";
            this.materia.SelectedIndexChanged += new System.EventHandler(this.materia_SelectedIndexChanged);
            this.materia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materia_KeyPress);
            // 
            // B_Crear_Horario
            // 
            this.B_Crear_Horario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.B_Crear_Horario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.B_Crear_Horario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.B_Crear_Horario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.B_Crear_Horario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Crear_Horario.ForeColor = System.Drawing.Color.LightGray;
            this.B_Crear_Horario.Location = new System.Drawing.Point(265, 305);
            this.B_Crear_Horario.Name = "B_Crear_Horario";
            this.B_Crear_Horario.Size = new System.Drawing.Size(88, 31);
            this.B_Crear_Horario.TabIndex = 60;
            this.B_Crear_Horario.Text = "Agregar";
            this.B_Crear_Horario.UseVisualStyleBackColor = false;
            this.B_Crear_Horario.Click += new System.EventHandler(this.B_Crear_Horario_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(214, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "curso";
            // 
            // curso
            // 
            this.curso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.curso.FormattingEnabled = true;
            this.curso.Location = new System.Drawing.Point(255, 100);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(137, 21);
            this.curso.TabIndex = 58;
            this.curso.Text = "---  Seleccione Curso ---";
            this.curso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.curso_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(89, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "CI: del profesor que dara la clase";
            // 
            // CI_de_profesor
            // 
            this.CI_de_profesor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CI_de_profesor.Location = new System.Drawing.Point(255, 67);
            this.CI_de_profesor.Margin = new System.Windows.Forms.Padding(2);
            this.CI_de_profesor.Name = "CI_de_profesor";
            this.CI_de_profesor.Size = new System.Drawing.Size(137, 13);
            this.CI_de_profesor.TabIndex = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.b_materia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtmateria);
            this.panel1.Location = new System.Drawing.Point(556, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 165);
            this.panel1.TabIndex = 71;
            // 
            // b_materia
            // 
            this.b_materia.Location = new System.Drawing.Point(69, 82);
            this.b_materia.Name = "b_materia";
            this.b_materia.Size = new System.Drawing.Size(75, 23);
            this.b_materia.TabIndex = 3;
            this.b_materia.Text = "Añadir";
            this.b_materia.UseVisualStyleBackColor = true;
            this.b_materia.Click += new System.EventHandler(this.bagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar nueva materia";
            // 
            // txtmateria
            // 
            this.txtmateria.Location = new System.Drawing.Point(43, 56);
            this.txtmateria.Name = "txtmateria";
            this.txtmateria.Size = new System.Drawing.Size(126, 20);
            this.txtmateria.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.b_curso);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCurso);
            this.panel2.Location = new System.Drawing.Point(558, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 170);
            this.panel2.TabIndex = 72;
            // 
            // b_curso
            // 
            this.b_curso.Location = new System.Drawing.Point(67, 82);
            this.b_curso.Name = "b_curso";
            this.b_curso.Size = new System.Drawing.Size(75, 23);
            this.b_curso.TabIndex = 3;
            this.b_curso.Text = "Añadir";
            this.b_curso.UseVisualStyleBackColor = true;
            this.b_curso.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Agregar nuevo curso";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(41, 56);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(126, 20);
            this.txtCurso.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(401, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "min.";
            // 
            // hasta_minutos
            // 
            this.hasta_minutos.FormattingEnabled = true;
            this.hasta_minutos.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.hasta_minutos.Location = new System.Drawing.Point(358, 267);
            this.hasta_minutos.Name = "hasta_minutos";
            this.hasta_minutos.Size = new System.Drawing.Size(43, 21);
            this.hasta_minutos.TabIndex = 75;
            this.hasta_minutos.Text = "00";
            this.hasta_minutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hasta_minutos_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(327, 272);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Hrs.";
            // 
            // hasta_hora
            // 
            this.hasta_hora.FormattingEnabled = true;
            this.hasta_hora.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.hasta_hora.Location = new System.Drawing.Point(284, 267);
            this.hasta_hora.Name = "hasta_hora";
            this.hasta_hora.Size = new System.Drawing.Size(43, 21);
            this.hasta_hora.TabIndex = 73;
            this.hasta_hora.Text = "00";
            this.hasta_hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hasta_hora_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(251, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "De:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(239, 272);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = "Hasta:";
            // 
            // dia
            // 
            this.dia.AutoCompleteCustomSource.AddRange(new string[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.dia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dia.FormattingEnabled = true;
            this.dia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.dia.Location = new System.Drawing.Point(255, 176);
            this.dia.Name = "dia";
            this.dia.Size = new System.Drawing.Size(137, 21);
            this.dia.TabIndex = 79;
            this.dia.Text = "-----  Seleccione Dia -----";
            this.dia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dia_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(224, 179);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 80;
            this.label12.Text = "Dia";
            // 
            // L_error_CI
            // 
            this.L_error_CI.ForeColor = System.Drawing.Color.Red;
            this.L_error_CI.Location = new System.Drawing.Point(399, 68);
            this.L_error_CI.Name = "L_error_CI";
            this.L_error_CI.Size = new System.Drawing.Size(149, 29);
            this.L_error_CI.TabIndex = 81;
            this.L_error_CI.Text = "* El CI del profesor no existe o esta mal escrita";
            this.L_error_CI.Visible = false;
            // 
            // l_materia
            // 
            this.l_materia.ForeColor = System.Drawing.Color.Red;
            this.l_materia.Location = new System.Drawing.Point(398, 135);
            this.l_materia.Name = "l_materia";
            this.l_materia.Size = new System.Drawing.Size(149, 26);
            this.l_materia.TabIndex = 82;
            this.l_materia.Text = "* Seleccione una materia";
            this.l_materia.Visible = false;
            // 
            // l_curso
            // 
            this.l_curso.ForeColor = System.Drawing.Color.Red;
            this.l_curso.Location = new System.Drawing.Point(398, 100);
            this.l_curso.Name = "l_curso";
            this.l_curso.Size = new System.Drawing.Size(149, 21);
            this.l_curso.TabIndex = 83;
            this.l_curso.Text = "* seleccione un curso";
            this.l_curso.Visible = false;
            // 
            // l_dia
            // 
            this.l_dia.ForeColor = System.Drawing.Color.Red;
            this.l_dia.Location = new System.Drawing.Point(401, 179);
            this.l_dia.Name = "l_dia";
            this.l_dia.Size = new System.Drawing.Size(149, 26);
            this.l_dia.TabIndex = 84;
            this.l_dia.Text = "* Seleccione el dia";
            this.l_dia.Visible = false;
            // 
            // CrearHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(759, 348);
            this.Controls.Add(this.l_dia);
            this.Controls.Add(this.l_curso);
            this.Controls.Add(this.l_materia);
            this.Controls.Add(this.L_error_CI);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hasta_minutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hasta_hora);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CI_de_profesor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.de_minutos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.de_hora);
            this.Controls.Add(this.Lhorario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.materia);
            this.Controls.Add(this.B_Crear_Horario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.curso);
            this.Name = "CrearHorario";
            this.Text = "CrearHorario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox de_minutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox de_hora;
        private System.Windows.Forms.Label Lhorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox materia;
        private System.Windows.Forms.Button B_Crear_Horario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox curso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CI_de_profesor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_materia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmateria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_curso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox hasta_minutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox hasta_hora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox dia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label L_error_CI;
        private System.Windows.Forms.Label l_materia;
        private System.Windows.Forms.Label l_curso;
        private System.Windows.Forms.Label l_dia;
    }
}