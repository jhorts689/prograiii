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

namespace AyD
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void CB_seleccion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            conexion conexionbdd = new conexion();

            LCOREC_CONTRA.Visible = TRcontraseña.Text != contraseña.Text;
            Lusuario.Visible = conexionbdd.Verificador_de_nombre_de_usuario(Usuario.Text) > 0;
            l_seleccion.Visible = CB_seleccion.Text == "---- seleccione una opcion ---";
            if (!LCOREC_CONTRA.Visible && !Lusuario.Visible && !l_seleccion.Visible)
            {
                MessageBox.Show("Guardado.." + conexionbdd.insertar("INSERT INTO Persona (Id_colegio,ci ,Usuario, Nombre, ApellidoPaterno, ApellidoMaterno, contraseña, rango) VALUES ("
                    + Convert.ToInt32(Id_colegio.Text) + ", "+ Convert.ToInt32(CI.Text) + ",'" + Usuario.Text + "', '" + Nombre.Text + "', '" + ApellidoPaterno.Text + "', '" + ApellidoMaterno.Text + "', '" + contraseña.Text + "', '"+CB_seleccion.Text+"')"));
                Login login = new Login();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR CON LOS DATOS");
            }
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void B_atras_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void CB_seleccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
