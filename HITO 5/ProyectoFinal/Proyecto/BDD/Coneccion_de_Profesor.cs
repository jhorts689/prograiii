using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyD.BDD
{
    class Coneccion_de_Profesor
    {
        private SqlConnection conexiones = new SqlConnection("Data Source=GIGASERVY-64; Initial Catalog=AYD; Integrated Security =True");
        public int n_de_alumnos(string curso)
        {
            conexiones.Open();
            SqlCommand comando = new SqlCommand("select curso from Estudiante where curso = @curso", conexiones);
            comando.Parameters.AddWithValue("curso", curso);
            SqlDataAdapter SDA = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            int a = dt.Rows.Count;
            conexiones.Close();
            return a;

        }
        public string ci(string Usuario, string contraseña)
        {
            conexiones.Open();
            string comando = ("select ci from Persona where Usuario = '" + Usuario + "' and contraseña = '" + contraseña + "'");
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string a = leer["ci"].ToString();
                leer.Close();
                conexiones.Close();
                return a;

            }
            leer.Close();
            conexiones.Close();
            return "error";


        }
        public List<String> listar_id_estudiante(string curso)
        {
            conexiones.Open();
            string comando = ("select id_estudiante from Estudiante where curso = '" + curso + "'");
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            List<String> list = new List<String>();
            while (leer.Read())
            {
                list.Add(leer["id_estudiante"].ToString());
            }
            leer.Close();
            conexiones.Close();
            return list;
        }
        public string mostrar_alumno(string columna, int cont)
        {
            conexiones.Open();
            string comando = ("select " + columna + " from Estudiante where id_estudiante = " + cont);
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string a = leer[columna].ToString();
                leer.Close();
                conexiones.Close();
                return a;

            }
            leer.Close();
            conexiones.Close();
            return "error";
        }
        public List<string> Combo_titulo(string curso, string materia)
        {
            conexiones.Open();
            string comando = ("select titulo from Publicacion_de_tareas where curso = '" + curso + "' and materia = '"+materia+"'");
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            List<String> list = new List<String>();
            while (leer.Read())
            {
                list.Add(leer["titulo"].ToString());
            }
            leer.Close();
            conexiones.Close();
            return list;
        }
        public int hay_tarea(string curso, string materia, string titulo)
        {
            conexiones.Open();
            SqlCommand comando = new SqlCommand("select curso, materia, titulo from Calificacion where curso = @curso and materia = @materia and titulo =@titulo", conexiones);
            comando.Parameters.AddWithValue("curso", curso);
            comando.Parameters.AddWithValue("materia", materia);
            comando.Parameters.AddWithValue("titulo", titulo);
            SqlDataAdapter SDA = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            int a = dt.Rows.Count;
            conexiones.Close();
            return a;
        }
        public List<string> cargar_notas(string curso, string materia, string titulo)
        {
            conexiones.Open();
            string comando = ("select nota from Calificacion where curso = '" + curso + "' and materia = '" + materia + "' and titulo = '" +titulo+"'");
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            List<String> list = new List<String>();
            while (leer.Read())
            {
                list.Add(leer["nota"].ToString());
            }
            leer.Close();
            conexiones.Close();
            return list;
        }
        

    }

}
