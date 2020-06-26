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
    public partial class Agregar_Notas : Form
    {
        
        public Agregar_Notas()
        {
            InitializeComponent();
            Coneccion_de_Director conec = new Coneccion_de_Director();
            string[] arraycurso = conec.Combo_curso().ToArray();
            curso.Items.AddRange(arraycurso);
            string[] arraymateria = conec.Combo_materia().ToArray();
            materia.Items.AddRange(arraymateria);
        }
        List<string> l_nombre = new List<string>();
        Coneccion_de_Profesor con = new Coneccion_de_Profesor();
        private NumericUpDown[] com;
       
        private void B_buscar_Click(object sender, EventArgs e)
        {
           
        }
        public void construir_lista()
        {
            int cont = 0;
            int l_y = 36;
            Titulo.Visible = true;
            Label temp = new Label();
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
                cont++;
                temp.Text = (cont) + ".  " + con.mostrar_alumno("Apellido_paterno", i) + " " + con.mostrar_alumno("Apellido_materno", i) + " " + con.mostrar_alumno("Nombre_del_estudiante", i);
                temp.BackColor = Color.Silver;
                temp.TextAlign = ContentAlignment.MiddleLeft; //alineacion
                Panel_lista.Controls.Add(temp);
                
            }
        }
        public void constrir_notas()
        {
            bool haycalificacion = con.hay_tarea(curso.Text, materia.Text, Titulo.Text) > 0;
            int tamaño = con.n_de_alumnos(curso.Text);
            com = new NumericUpDown[tamaño];
            int cont = 0;
            int c_y = 36;
            string[] arraynotas = con.cargar_notas(curso.Text, materia.Text, Titulo.Text).ToArray();
            //combobox = new List<ComboBox>();
            foreach (string id in con.listar_id_estudiante(curso.Text))
            {
                
                com[cont] = new NumericUpDown();
                com[cont].Height = 21;
                com[cont].Width = 70;
                com[cont].Location = new Point(339, c_y);
                c_y += 21;
                com[cont].Name = "combo" + cont;
                if (haycalificacion)
                {
                    com[cont].Value = Convert.ToInt32(arraynotas[cont]);
                }
                com[cont].BackColor = Color.Silver;
                //com[cont].DropDownStyle = ComboBoxStyle.DropDownList;
                Panel_lista.Controls.Add(com[cont]);
                cont++;
            }
        }

        private void curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curso.Text != "---  Seleccione Curso ---" && materia.Text != "--  Seleccione Materia --")
            {
                Panel_lista.Controls.Clear();
                Label totilo = new Label();
                totilo.Height = 23;
                totilo.Width = 414;
                totilo.Location = new Point(5, 12);
                totilo.Name = "totilo";
                totilo.BackColor = Color.DimGray;
                totilo.Text = "N°    Nombres:                                                                                          Nota";
                Panel_lista.Controls.Add(totilo);
                construir_lista();
                Titulo.Visible = true;
                Coneccion_de_Profesor conec = new Coneccion_de_Profesor();
                string[] arraytitulo = conec.Combo_titulo(curso.Text, materia.Text).ToArray();
                Titulo.Items.AddRange(arraytitulo);
            }
            
        }

        private void Titulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Titulo.Text != "----Seleccione la tarea---")
            {
                constrir_notas();
            }
        }
        private void materia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curso.Text != "---  Seleccione Curso ---" && materia.Text != "--  Seleccione Materia --")
            {
                Panel_lista.Controls.Clear();
                Label totilo = new Label();
                totilo.Height = 23;
                totilo.Width = 414;
                totilo.Location = new Point(5, 12);
                totilo.Name = "totilo";
                totilo.BackColor = Color.DimGray;
                totilo.Text = "N°    Nombres:                                                                                          Nota";
                Panel_lista.Controls.Add(totilo);
                construir_lista();
                Titulo.Visible = true;
                Coneccion_de_Profesor conec = new Coneccion_de_Profesor();
                string[] arraytitulo = conec.Combo_titulo(curso.Text, materia.Text).ToArray();
                Titulo.Items.AddRange(arraytitulo);
            }
        }

        private void b_guardar_Click(object sender, EventArgs e)
        {
            bool haycalificacion = con.hay_tarea(curso.Text, materia.Text, Titulo.Text) > 0;
            conexion conectar = new conexion();
            int i =0;
            foreach (string id in con.listar_id_estudiante(curso.Text))
            {
                if (haycalificacion)
                {
                    conectar.modificar("UPDATE Calificacion SET nota = " + com[i].Value + " where curso = '" + curso.Text + "' and materia = '" + materia.Text + "' and titulo = '" + Titulo.Text + "' and id_estudiante = " + Convert.ToInt32(id));
                    i++;
                    
                }
                else
                {
                    conectar.insertar("INSERT INTO Calificacion (id_estudiante,curso, materia,titulo, nota) VALUES (" + Convert.ToInt32(id) + ", '" + curso.Text + "', '" + materia.Text + "', '"+Titulo.Text+"', " + com[i].Value + ")");
                    i++;
                    
                }

            }
            MessageBox.Show("guardado con exito");
        }
    }
}
