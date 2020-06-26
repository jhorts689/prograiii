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
    public partial class Asistencia : Form
    {
        public string ci;
        public Asistencia()
        {
            InitializeComponent();

            Button temp = new Button();
            int y = 12;
            Coneccion_de_Director con = new Coneccion_de_Director();
            string[] array = con.datos_de_estudiante(ci, "fecha").ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                temp = new Button();
                temp.Height = 70;
                temp.Width = 230;
                temp.Location = new Point(10, y);
                y += 75;
                temp.Name = "btnBoton" + i;
                temp.Text = "El estudiante esta con " + con.datos_de_estudiante(ci, "asistencia")[i] + " \n Fecha: " + (DateTime.Parse(con.datos_de_estudiante(ci, "fecha")[i])).ToShortDateString() + " \n materia: " + con.datos_de_estudiante(ci, "materia")[i];
                temp.BackColor = Color.CornflowerBlue;
                temp.TextAlign = ContentAlignment.MiddleLeft;
                Panel_de_asistencia.Controls.Add(temp);
            }
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {

        }
    }
}
