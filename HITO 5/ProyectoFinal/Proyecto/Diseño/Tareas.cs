using AyD.BDD;
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
    public partial class Tareas : Form
    {
        public Tareas()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Panel_de_asistencia.Controls.Clear();
            Label temp = new Label();
            int y = 8;
            Coneccion_de_padres con = new Coneccion_de_padres();
            string[] array = con.datos_de_estudiante(Buscador_tutor.Text, "Titulo").ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                temp = new Label();
                temp.Height = 78;
                temp.Width = 420;
                temp.Location = new Point(11, y); 
                y += 80;
                temp.Name = "btnBoton" + i;
                temp.Text = "titulo: " + con.datos_de_estudiante(Buscador_tutor.Text, "Titulo")[i] + "                                      fecha de entrega: " + con.datos_de_estudiante(Buscador_tutor.Text, "fecha")[i] + "\n materia:" + con.datos_de_estudiante(Buscador_tutor.Text, "materia")[i] + " \n descripcion: " + con.datos_de_estudiante(Buscador_tutor.Text, "descripcion")[i];
                temp.BackColor = Color.CornflowerBlue;
                temp.TextAlign = ContentAlignment.MiddleLeft;
                Panel_de_asistencia.Controls.Add(temp);
            }
        }
    }
}
