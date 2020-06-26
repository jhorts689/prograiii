namespace AyD
{
    partial class Registro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.CB_seleccion = new System.Windows.Forms.ComboBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TRcontraseña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Id_colegio = new System.Windows.Forms.TextBox();
            this.LCOREC_CONTRA = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Lusuario = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.B_atras = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.l_seleccion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_seleccion
            // 
            this.CB_seleccion.FormattingEnabled = true;
            this.CB_seleccion.Items.AddRange(new object[] {
            "Padre",
            "Maestro",
            "Director",
            "Secretaria"});
            this.CB_seleccion.Location = new System.Drawing.Point(359, 327);
            this.CB_seleccion.Margin = new System.Windows.Forms.Padding(2);
            this.CB_seleccion.Name = "CB_seleccion";
            this.CB_seleccion.Size = new System.Drawing.Size(165, 21);
            this.CB_seleccion.TabIndex = 1;
            this.CB_seleccion.Text = "---- seleccione una opcion ---";
            this.CB_seleccion.SelectedIndexChanged += new System.EventHandler(this.CB_seleccion_SelectedIndexChanged);
            this.CB_seleccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CB_seleccion_KeyPress);
            // 
            // contraseña
            // 
            this.contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contraseña.Location = new System.Drawing.Point(359, 230);
            this.contraseña.Margin = new System.Windows.Forms.Padding(2);
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(173, 13);
            this.contraseña.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.label2.Location = new System.Drawing.Point(293, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label3.Location = new System.Drawing.Point(311, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // Nombre
            // 
            this.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre.Location = new System.Drawing.Point(359, 87);
            this.Nombre.Margin = new System.Windows.Forms.Padding(2);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(173, 13);
            this.Nombre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label4.Location = new System.Drawing.Point(272, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido paterno";
            // 
            // ApellidoPaterno
            // 
            this.ApellidoPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApellidoPaterno.Location = new System.Drawing.Point(359, 123);
            this.ApellidoPaterno.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoPaterno.Name = "ApellidoPaterno";
            this.ApellidoPaterno.Size = new System.Drawing.Size(173, 13);
            this.ApellidoPaterno.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label5.Location = new System.Drawing.Point(270, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Apellido materno";
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApellidoMaterno.Location = new System.Drawing.Point(359, 162);
            this.ApellidoMaterno.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.Size = new System.Drawing.Size(173, 13);
            this.ApellidoMaterno.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.label1.Location = new System.Drawing.Point(257, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Repetir Contraseña";
            // 
            // TRcontraseña
            // 
            this.TRcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TRcontraseña.Location = new System.Drawing.Point(359, 264);
            this.TRcontraseña.Margin = new System.Windows.Forms.Padding(2);
            this.TRcontraseña.Name = "TRcontraseña";
            this.TRcontraseña.PasswordChar = '*';
            this.TRcontraseña.Size = new System.Drawing.Size(173, 13);
            this.TRcontraseña.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.label6.Location = new System.Drawing.Point(299, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Id_colegio";
            // 
            // Id_colegio
            // 
            this.Id_colegio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_colegio.Location = new System.Drawing.Point(359, 55);
            this.Id_colegio.Name = "Id_colegio";
            this.Id_colegio.Size = new System.Drawing.Size(173, 13);
            this.Id_colegio.TabIndex = 15;
            // 
            // LCOREC_CONTRA
            // 
            this.LCOREC_CONTRA.AutoSize = true;
            this.LCOREC_CONTRA.ForeColor = System.Drawing.Color.Red;
            this.LCOREC_CONTRA.Location = new System.Drawing.Point(548, 269);
            this.LCOREC_CONTRA.Name = "LCOREC_CONTRA";
            this.LCOREC_CONTRA.Size = new System.Drawing.Size(133, 13);
            this.LCOREC_CONTRA.TabIndex = 18;
            this.LCOREC_CONTRA.Text = "La contraseña no coincide";
            this.LCOREC_CONTRA.Visible = false;
            // 
            // Usuario
            // 
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Location = new System.Drawing.Point(359, 198);
            this.Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(173, 13);
            this.Usuario.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.label7.Location = new System.Drawing.Point(311, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Usuario";
            // 
            // Lusuario
            // 
            this.Lusuario.AutoSize = true;
            this.Lusuario.ForeColor = System.Drawing.Color.Red;
            this.Lusuario.Location = new System.Drawing.Point(548, 198);
            this.Lusuario.Name = "Lusuario";
            this.Lusuario.Size = new System.Drawing.Size(96, 13);
            this.Lusuario.TabIndex = 21;
            this.Lusuario.Text = "el usuario ya existe";
            this.Lusuario.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(359, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 22;
            this.button1.Text = "guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(267, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 32);
            this.label8.TabIndex = 23;
            this.label8.Text = "REGISTER";
            // 
            // btncerrar
            // 
            this.btncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("btncerrar.Image")));
            this.btncerrar.Location = new System.Drawing.Point(670, 9);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(15, 15);
            this.btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btncerrar.TabIndex = 25;
            this.btncerrar.TabStop = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.B_atras);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 455);
            this.panel1.TabIndex = 26;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // B_atras
            // 
            this.B_atras.BackColor = System.Drawing.Color.SteelBlue;
            this.B_atras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.B_atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.B_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.B_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_atras.ForeColor = System.Drawing.Color.LightGray;
            this.B_atras.Location = new System.Drawing.Point(3, 412);
            this.B_atras.Name = "B_atras";
            this.B_atras.Size = new System.Drawing.Size(43, 31);
            this.B_atras.TabIndex = 27;
            this.B_atras.Text = "Atras";
            this.B_atras.UseVisualStyleBackColor = false;
            this.B_atras.Click += new System.EventHandler(this.B_atras_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(59, 118);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // l_seleccion
            // 
            this.l_seleccion.AutoSize = true;
            this.l_seleccion.ForeColor = System.Drawing.Color.Red;
            this.l_seleccion.Location = new System.Drawing.Point(548, 330);
            this.l_seleccion.Name = "l_seleccion";
            this.l_seleccion.Size = new System.Drawing.Size(99, 13);
            this.l_seleccion.TabIndex = 27;
            this.l_seleccion.Text = "*Escoja una opcion\r\n";
            this.l_seleccion.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(548, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 30;
            this.label9.Visible = false;
            // 
            // CI
            // 
            this.CI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CI.Location = new System.Drawing.Point(359, 294);
            this.CI.Margin = new System.Windows.Forms.Padding(2);
            this.CI.Name = "CI";
            this.CI.Size = new System.Drawing.Size(173, 13);
            this.CI.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(101)))), ((int)(((byte)(143)))));
            this.label10.Location = new System.Drawing.Point(327, 294);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "CI\r\n";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(16)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(697, 455);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CI);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.l_seleccion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lusuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.LCOREC_CONTRA);
            this.Controls.Add(this.Id_colegio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TRcontraseña);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ApellidoMaterno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ApellidoPaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.CB_seleccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.btncerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_seleccion;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ApellidoPaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ApellidoMaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TRcontraseña;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Id_colegio;
        private System.Windows.Forms.Label LCOREC_CONTRA;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lusuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btncerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button B_atras;
        private System.Windows.Forms.Label l_seleccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CI;
        private System.Windows.Forms.Label label10;
    }
}

