using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyD.Diseño
{
    public partial class PROFESOR : Form
    {
        public string CI;
        public PROFESOR()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
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
            if (Application.OpenForms["Control_de_Asistencia"] == null)
                button1.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Buscar_Estudiantes"] == null)
                button2.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Publicar_Tarea"] == null)
                button3.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["Agregar_Notas"] == null)
                button4.BackColor = Color.FromArgb(4, 41, 68);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Control_de_Asistencia>();
            button1.BackColor = Color.FromArgb(12, 61, 92);
            button2.BackColor = Color.FromArgb(7, 16, 25);
            button3.BackColor = Color.FromArgb(7, 16, 25);
            button4.BackColor = Color.FromArgb(7, 16, 25);
        }

        private void PROFESOR_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelformularios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Buscar_Estudiantes>();
            button2.BackColor = Color.FromArgb(12, 61, 92);
            button1.BackColor = Color.FromArgb(7, 16, 25);
            button3.BackColor = Color.FromArgb(7, 16, 25);
            button4.BackColor = Color.FromArgb(7, 16, 25);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Agregar_Notas>();
            button4.BackColor = Color.FromArgb(12, 61, 92);
            button3.BackColor = Color.FromArgb(7, 16, 25);
            button1.BackColor = Color.FromArgb(7, 16, 25);
            button2.BackColor = Color.FromArgb(7, 16, 25);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Publicar_Tarea>();
            button3.BackColor = Color.FromArgb(12, 61, 92);
            button1.BackColor = Color.FromArgb(7, 16, 25);
            button2.BackColor = Color.FromArgb(7, 16, 25);
            button4.BackColor = Color.FromArgb(7, 16, 25);
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
