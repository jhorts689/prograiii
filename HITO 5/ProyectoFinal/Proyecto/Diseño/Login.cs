using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AyD.Clase;
using System.Runtime.InteropServices;
using AyD.Diseño;

namespace AyD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        [DllImport("user32.DLL",EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void button2_Click(object sender, EventArgs e)
        {
            
            Registro registro = new Registro();
            registro.Show();
            this.Close();
            

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Close();

        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void contraseña_Enter(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "Contraseña")
            {
                txtcontraseña.Text = "";
                txtcontraseña.ForeColor = Color.LightGray;
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void contraseña_Leave(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "")
            {
                txtcontraseña.Text = "Contraseña";
                txtcontraseña.ForeColor = Color.DimGray;
                txtcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            conexion conec = new conexion();
            string rango = conec.comprovar(txtusuario.Text,txtcontraseña.Text);
            if (rango == "Padre")
            {
                PADRE form = new PADRE();
                form.CI = conec.ci(txtusuario.Text, txtcontraseña.Text);
                form.Show();
                this.Close();
            }
            else if (rango == "Maestro")
            {
                PROFESOR form = new PROFESOR();
                form.CI = conec.ci(txtusuario.Text,txtcontraseña.Text); 
                form.Show();
                this.Close();
            }
            else if (rango == "Director" || rango == "Secretaria")
            {
                DIRECTOR form = new DIRECTOR();
                form.CI = conec.ci(txtusuario.Text, txtcontraseña.Text);
                form.Show();
                this.Close();
            }
            else
            {
                Lusuario.Visible = true;
            }
            
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
