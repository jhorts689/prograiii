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
using AyD.BDD;
using System.Runtime.InteropServices;

namespace AyD.Diseño
{
    public partial class CrearHorario : Form
    {
        public CrearHorario()
        {
            InitializeComponent();
            Coneccion_de_Director conec = new Coneccion_de_Director();
            string[] arraycurso = conec.Combo_curso().ToArray();
            curso.Items.AddRange(arraycurso);
            string[] arraymateria = conec.Combo_materia().ToArray();
            materia.Items.AddRange(arraymateria);
        }
        private void B_Crear_Horario_Click(object sender, EventArgs e)
        {
            Coneccion_de_Director conec = new Coneccion_de_Director();
            string horarioDE = de_hora.Text + ":" + de_minutos.Text;
            string horarioHASTA = hasta_hora.Text + ":" + hasta_minutos.Text;
            conexion conexionbdd = new conexion();
            L_error_CI.Visible = CI_de_profesor.Text == "";
            l_curso.Visible = curso.Text == "---  Seleccione Curso ---";
            l_materia.Visible = materia.Text == "--  Seleccione Materia --";
            l_dia.Visible = dia.Text == "-----  Seleccione Dia -----";
            if(!L_error_CI.Visible && !l_curso.Visible && !l_materia.Visible && !l_dia.Visible)
            {
                L_error_CI.Visible = CI_de_profesor.Text != conec.mostrar_profesor(CI_de_profesor.Text, "CI_de_profesor");
                if (!L_error_CI.Visible)
                {
                    conexionbdd.insertar("INSERT INTO Horarios (CI_de_profesor, curso, materia,dia , horarioDE, horarioHASTA) VALUES (" + Convert.ToInt32(CI_de_profesor.Text) + ", '" + curso.Text
                    + "', '" + materia.Text + "', '" + dia.Text + "', '" + horarioDE + "', '" + horarioHASTA + "')");
                    MessageBox.Show("Guardado..");
                }
                else
                {
                    MessageBox.Show("ERROR CON LOS DATOS");
                }
            }
            else
            {
                MessageBox.Show("ERROR CON LOS DATOS");
            }
        }
        private void materia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void materia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void curso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void dia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void bagregar_Click(object sender, EventArgs e)
        {
            bool verdad = true;
            conexion conexionbdd = new conexion();
            for (int i = 0; i < materia.Items.Count; i++)
            {
                if (materia.Items[i].ToString() == txtmateria.Text)
                {
                    verdad = false;
                }
            }
            if (txtmateria.Text != "" && verdad)
            {
                conexionbdd.insertar("INSERT INTO Materia (materia) values ( '" + txtmateria.Text + "')");
                materia.Items.Add(txtmateria.Text);
            }
            //listBox1.Items.Clear(); ELIMINA DATOS DEL COMBOBOX
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool verdad = true;
            conexion conexionbdd = new conexion();
            for (int i = 0; i < curso.Items.Count; i++)
            {
                if (curso.Items[i].ToString() == txtCurso.Text)
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

        private void de_hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void de_minutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void hasta_hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void hasta_minutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
