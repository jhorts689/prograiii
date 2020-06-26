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
    public partial class Control_de_Asistencia : Form
    {
        public Control_de_Asistencia()
        {
            InitializeComponent();
            Coneccion_de_Director conec = new Coneccion_de_Director();
            string[] arraycurso = conec.Combo_curso().ToArray();
            curso.Items.AddRange(arraycurso);
            string[] arraymateria = conec.Combo_materia().ToArray();
            materia.Items.AddRange(arraymateria);

        }
        List<string> l_nombre = new List<string>();
        Coneccion_de_Director con = new Coneccion_de_Director();
        private ComboBox[] com;

        private void b_guardar_cambios_Click(object sender, EventArgs e)
        {
            int contador = 0;
            conexion conectar = new conexion();
            bool hayasistencia = con.hay_asistencia(curso.Text, materia.Text, dateTime_fecha.Value.ToShortDateString()) > 0;
            foreach (string cont in con.listar_id_estudiante(curso.Text))
            {
                if (hayasistencia)
                {
                    int i = Convert.ToInt32(cont);
                    conectar.modificar("UPDATE Lista_de_Asistencia SET asistencia = '"+com[contador].Text+ "' where curso = '" + curso.Text + "' and materia = '" + materia.Text + "' and fecha = '" + dateTime_fecha.Value.ToShortDateString() + "' and id_estudiante = " + Convert.ToInt32(cont));
                    contador++;
                }
                else
                {
                    int i = Convert.ToInt32(cont);
                    conectar.insertar("INSERT INTO Lista_de_Asistencia (id_estudiante, fecha, curso, materia, asistencia) VALUES (" + i + ", '" + dateTime_fecha.Value.ToShortDateString() + "', '" + curso.Text + "', '" + materia.Text + "', '" + com[contador].Text + "')");
                    contador++;
                }

               
            }
            MessageBox.Show("guardado con exito");
        }
        private void B_buscar_Click(object sender, EventArgs e)
        {
            
        }
        public void construir_lista()
        {
            //Panel_lista.Controls.Clear();
            int cont = 0;
            int l_y = 36;

            Label temp = new Label();
            int tamaño = con.n_de_alumnos(curso.Text);
            foreach (string id in con.listar_id_estudiante(curso.Text))
            {
                int i = Convert.ToInt32(id);
                temp = new Label();
                temp.Height = 21;
                temp.Width = 322;
                temp.Location = new Point(17, l_y);
                l_y += 21;
                temp.Name = "label" + id;
                l_nombre.Add(temp.Name);
                temp.Text = (cont + 1) + ".  " + con.mostrar_alumno("Apellido_paterno", i) + " " + con.mostrar_alumno("Apellido_materno", i) + " " + con.mostrar_alumno("Nombre_del_estudiante", i);
                temp.BackColor = Color.Silver;
                temp.TextAlign = ContentAlignment.MiddleLeft; //alineacion
                Panel_lista.Controls.Add(temp);
                cont++;
            }
        }
        public void crear_asistencia()
        {
            int cont = 0;
            int c_y = 36;
            bool hayasistencia = con.hay_asistencia(curso.Text, materia.Text, dateTime_fecha.Value.ToShortDateString()) > 0;
            int tamaño = con.n_de_alumnos(curso.Text);
            com = new ComboBox[tamaño];
            string[] arrayasistencia = con.cargar_notas(curso.Text, materia.Text, dateTime_fecha.Value.ToShortDateString()).ToArray();
            foreach (string id in con.listar_id_estudiante(curso.Text))
            {
                //combobox = new List<ComboBox>();
                com[cont] = new ComboBox();
                com[cont].Height = 21;
                com[cont].Width = 70;
                com[cont].Location = new Point(339, c_y);
                c_y += 21;
                com[cont].Name = "combo" + cont;
                com[cont].BackColor = Color.Silver;
                com[cont].Items.Add("puntual");
                com[cont].Items.Add("retraso");
                com[cont].Items.Add("falta");
                com[cont].Items.Add("permiso");
                //com[cont].DropDownStyle = ComboBoxStyle.DropDownList;
                com[cont].Text = "";
                if (hayasistencia)
                {
                    com[cont].Text = arrayasistencia[cont];
                }
                com[cont].KeyPress += this.com_KeyPress;
                Panel_lista.Controls.Add(com[cont]);
                cont++;
            }
        }
        private void com_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dateTime_fecha_ValueChanged(object sender, EventArgs e)
        {
            if (curso.Text != "---  Seleccione Curso ---" && materia.Text != "--  Seleccione Materia --")
            {
                Panel_lista.Controls.Clear();
                totilo();
                construir_lista();
                crear_asistencia();
            }
        }
        public void totilo()
        {
            Label totilo = new Label();
            totilo.Height = 23;
            totilo.Width = 414;
            totilo.Location = new Point(17, 13);
            totilo.Name = "totilo";
            totilo.BackColor = Color.DimGray;
            totilo.Text = "N°    Nombres:                                                                                          Asistencia";
            Panel_lista.Controls.Add(totilo);
        }
        private void curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curso.Text != "---  Seleccione Curso ---" && materia.Text != "--  Seleccione Materia --")
            {
                Panel_lista.Controls.Clear();
                totilo();
                construir_lista();
                crear_asistencia();
            }
        }

        private void materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curso.Text != "---  Seleccione Curso ---" && materia.Text != "--  Seleccione Materia --")
            {
                Panel_lista.Controls.Clear();
                totilo();
                construir_lista();
                crear_asistencia();
            }
        }

        private void PRUEBA_Click(object sender, EventArgs e)
        {

        }
    }
}
