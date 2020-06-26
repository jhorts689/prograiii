using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AyD.Diseño;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AyD.Diseño
{
    public partial class DIRECTOR : Form
    {
        public string CI;
        public DIRECTOR()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Registrar_estudiante"] == null)
                button1.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["RegistrarProfesor"] == null)
                button2.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["CrearHorario"] == null)
                button3.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Buscar_Profesor"] == null)
                button4.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Control_de_Asistencia"] == null)
                button5.BackColor = Color.FromArgb(4, 41, 68); 
            if (Application.OpenForms["Buscar_Estudiantes"] == null)
                button6.BackColor = Color.FromArgb(4, 41, 68);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Registrar_estudiante>();
            button1.BackColor = Color.FromArgb(12, 61, 92);
            button2.BackColor = Color.FromArgb(7, 16, 25);
            button3.BackColor = Color.FromArgb(7, 16, 25);
            button4.BackColor = Color.FromArgb(7, 16, 25);
            button5.BackColor = Color.FromArgb(7, 16, 25);
            button6.BackColor = Color.FromArgb(7, 16, 25);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<RegistrarProfesor>();
            button2.BackColor = Color.FromArgb(12, 61, 92);
            button1.BackColor = Color.FromArgb(7, 16, 25);
            button3.BackColor = Color.FromArgb(7, 16, 25);
            button4.BackColor = Color.FromArgb(7, 16, 25);
            button5.BackColor = Color.FromArgb(7, 16, 25);
            button6.BackColor = Color.FromArgb(7, 16, 25);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<CrearHorario>();
            button3.BackColor = Color.FromArgb(12, 61, 92);
            button2.BackColor = Color.FromArgb(7, 16, 25);
            button1.BackColor = Color.FromArgb(7, 16, 25);
            button4.BackColor = Color.FromArgb(7, 16, 25);
            button5.BackColor = Color.FromArgb(7, 16, 25);
            button6.BackColor = Color.FromArgb(7, 16, 25);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Buscar_Profesor>();
            button4.BackColor = Color.FromArgb(12, 61, 92);
            button2.BackColor = Color.FromArgb(7, 16, 25);
            button3.BackColor = Color.FromArgb(7, 16, 25);
            button1.BackColor = Color.FromArgb(7, 16, 25);
            button5.BackColor = Color.FromArgb(7, 16, 25);
            button6.BackColor = Color.FromArgb(7, 16, 25);
        }

        private void DIRECTOR_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelformularios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Control_de_Asistencia>();
            button5.BackColor = Color.FromArgb(12, 61, 92);
            button2.BackColor = Color.FromArgb(7, 16, 25);
            button3.BackColor = Color.FromArgb(7, 16, 25);
            button4.BackColor = Color.FromArgb(7, 16, 25);
            button1.BackColor = Color.FromArgb(7, 16, 25);
            button6.BackColor = Color.FromArgb(7, 16, 25);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Buscar_Estudiantes>();
            button6.BackColor = Color.FromArgb(12, 61, 92);
            button2.BackColor = Color.FromArgb(7, 16, 25);
            button1.BackColor = Color.FromArgb(7, 16, 25);
            button3.BackColor = Color.FromArgb(7, 16, 25);
            button4.BackColor = Color.FromArgb(7, 16, 25);
            button5.BackColor = Color.FromArgb(7, 16, 25);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
