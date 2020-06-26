using AyD.BDD;
using AyD.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyD.Diseño
{
    public partial class Publicar_Tarea : Form
    {
        public Publicar_Tarea()
        {
            InitializeComponent();
            Coneccion_de_Director conec = new Coneccion_de_Director();
            string[] arraycurso = conec.Combo_curso().ToArray();
            curso.Items.AddRange(arraycurso);
            string[] arraymateria = conec.Combo_materia().ToArray();
            materia.Items.AddRange(arraymateria);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion conexionbdd = new conexion();
            l_curso.Visible = curso.Text == "---  Seleccione Curso ---";
            l_materia.Visible = materia.Text == "--  Seleccione Materia --";
            if (!l_materia.Visible && !l_curso.Visible)
            {
                conexionbdd.insertar("INSERT INTO Publicacion_de_tareas (curso, materia, Titulo, descripcion, fecha) VALUES ('" + curso.Text + "', '" + materia.Text + "', '"+ Titulo.Text + "', '" + descripcion.Text + "', '" + fecha.Value.ToShortDateString() + "')");
                MessageBox.Show("Guardado con exito" );
            }
           
        }

        private void Publicar_Tarea_Load(object sender, EventArgs e)
        {

        }
    }
}
