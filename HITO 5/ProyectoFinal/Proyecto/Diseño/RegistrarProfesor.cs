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
using AyD.BDD;

namespace AyD.Diseño
{
    public partial class RegistrarProfesor : Form
    {
        public RegistrarProfesor()
        {
            InitializeComponent();
        }

        private void RegistrarProfesor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coneccion_de_Director conexionbdd = new Coneccion_de_Director();
            conexion conectar = new conexion();
            if (Nombre_del_profesor.Text != "" && Apellido_paterno.Text != "" && Apellido_materno.Text != "" && CI_de_profesor.Text != "")
            {
                if (conexionbdd.Verificador_de_profesor(CI_de_profesor.Text) < 1)
                {

                    MessageBox.Show("Guardado.." + conectar.insertar("INSERT INTO Profesor (Nombre_del_profesor, Apellido_paterno, Apellido_materno, CI_de_profesor) VALUES ('" + Nombre_del_profesor.Text + "', '" + Apellido_paterno.Text + "', '" + Apellido_materno.Text + "', " + Convert.ToInt32(CI_de_profesor.Text) + ")"));

                }
                else
                {
                    MessageBox.Show("Este CI ya fue registrado anteriormente..");

                }
            }
            else
            {
                MessageBox.Show("Ingrese los datos vacios");
            }
            
        }
    }
}
