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
    public partial class Buscar_Profesor : Form
    {
        public Buscar_Profesor()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int y = 12;
            Coneccion_de_Director con = new Coneccion_de_Director();
            int tamaño = con.numero_de_horaio_prof(Buscador_profe.Text);
            foreach (string cont in con.listar_id_profe(Buscador_profe.Text))
            {
                int i = Convert.ToInt32(cont);
                Button temp = new Button();
                temp.Height = 70;
                temp.Width = 230;
                temp.Location = new Point(10, y);
                y += 75;
                temp.Name = "btnBoton" + cont;
                temp.Text = " Materia: " + con.mostrar_horario("materia",i ) + " \n Curso: " + con.mostrar_horario("curso", i) + " \n Dia: " + con.mostrar_horario("dia", i) + " \n hora: " + con.mostrar_horario("horarioDE", i) +"   " +con.mostrar_horario("horarioHASTA", i);
                temp.BackColor = Color.CornflowerBlue;
                temp.TextAlign = ContentAlignment.MiddleLeft;
                panel_de_horario.Controls.Add(temp);
            }
           
            Nombre_Profesor.Text = con.mostrar_profesor(Buscador_profe.Text, "Nombre_del_profesor");
            Apellido_paterno.Text = con.mostrar_profesor(Buscador_profe.Text, "Apellido_paterno");
            Apellido_materno.Text = con.mostrar_profesor(Buscador_profe.Text, "Apellido_materno");
            CI_de_profesor.Text = con.mostrar_profesor(Buscador_profe.Text, "CI_de_profesor");
        }

        private void Nombre_Profesor_Click(object sender, EventArgs e)
        {

        }
    }
}
