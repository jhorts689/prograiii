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
    public partial class Registrar_estudiante : Form
    {
        public Registrar_estudiante()
        {
            
            InitializeComponent();
            Coneccion_de_Director conec = new Coneccion_de_Director();
            string[] array = conec.Combo_curso().ToArray();
            curso.Items.AddRange(array);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coneccion_de_Director conexionbdd = new Coneccion_de_Director();
            conexion conectar = new conexion();
            int temp = 0;
            l_curso.Visible = "----  seleccione curso ----" == curso.Text;
            l_ci.Visible = !int.TryParse(CI_de_tutor.Text, out temp);
            if (!l_ci.Visible && !l_ci.Visible && Nombre_del_estudiante.Text != "" && Apellido_paterno.Text != "" && Apellido_materno.Text != "")
            {
                if (conexionbdd.Verificador_de_estudiante(Nombre_del_estudiante.Text, Apellido_paterno.Text, Apellido_materno.Text) < 1)
                {

                    MessageBox.Show("Guardado.." + conectar.insertar("INSERT INTO Estudiante (Nombre_del_estudiante, Apellido_paterno, Apellido_materno, CI_de_tutor, curso) VALUES ('" + Nombre_del_estudiante.Text + "', '" + Apellido_paterno.Text + "', '" + Apellido_materno.Text + "', " + Convert.ToInt32(CI_de_tutor.Text) + ", '" + curso.Text + "')"));

                }
                else
                {
                    MessageBox.Show("ERROR... Ingrese datos validos");

                }
            }
            else
            {
                MessageBox.Show("ERROR... Ingrese datos validos");

            }


        }

        private void curso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            bool verdad = true;
            conexion conexionbdd = new conexion();
            for (int i = 0; i < curso.Items.Count; i++)
            {
                if(curso.Items[i].ToString() == txtCurso.Text)
                {
                    verdad = false;
                }
            }
            if (txtCurso.Text != "" && verdad)
            {
                conexionbdd.insertar("INSERT INTO Curso (curso) values ( '" + txtCurso.Text + "')");
                curso.Items.Add(txtCurso.Text);
            }
                
        }

        private void curso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
