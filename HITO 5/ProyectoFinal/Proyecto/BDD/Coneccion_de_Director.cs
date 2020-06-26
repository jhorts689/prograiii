using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyD.BDD
{
    class Coneccion_de_Director
    {
        private SqlConnection conexiones = new SqlConnection("Data Source=GIGASERVY-64; Initial Catalog=AYD; Integrated Security =True");
        public string mostrar_profesor(string CI_de_profesor, string columna)
        {
            conexiones.Open();
            string comando = ("select " + columna + " from Profesor where CI_de_profesor = " + Convert.ToInt32(CI_de_profesor));
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string a = leer["" + columna + ""].ToString();
                leer.Close();
                conexiones.Close();
                return a;

            }
            leer.Close();
            conexiones.Close();
            return "error";
        }
        public int Verificador_de_estudiante(string Nombre_del_estudiante, string Apellido_paterno, string Apellido_materno)
        {
            conexiones.Open();
            SqlCommand comando = new SqlCommand("select Nombre_del_estudiante, Apellido_paterno, Apellido_materno from Estudiante where Nombre_del_estudiante = @Nombre_del_estudiante and  Apellido_paterno = @Apellido_paterno and Apellido_materno = @Apellido_materno", conexiones);
            comando.Parameters.AddWithValue("Nombre_del_estudiante", Nombre_del_estudiante);
            comando.Parameters.AddWithValue("Apellido_paterno", Apellido_paterno);
            comando.Parameters.AddWithValue("Apellido_materno", Apellido_materno);

            SqlDataAdapter SDA = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            return dt.Rows.Count;
        }
        public int Verificador_de_profesor(string CI_de_profesor)
        {
            conexiones.Open();
            SqlCommand comando = new SqlCommand("select CI_de_profesor from Profesor where CI_de_profesor = @CI_de_profesor", conexiones);
            comando.Parameters.AddWithValue("CI_de_profesor", CI_de_profesor);
            SqlDataAdapter SDA = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            SDA.Fill(dt);

            return dt.Rows.Count;

        }
        public List<String> Combo_curso()
        {
            conexiones.Open();
            string comando = ("select distinct* from Curso ");
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            List<String> list = new List<String>();
            while (leer.Read())
            {
                list.Add(leer["curso"].ToString());
            }
            leer.Close();
            conexiones.Close();
            return list;
        }
        public List<String> Combo_materia()
        {
            conexiones.Open();
            string comando = ("select distinct* from Materia ");
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            List<String> list = new List<String>();
            while (leer.Read())
            {
                list.Add(leer["materia"].ToString());
            }
            leer.Close();
            conexiones.Close();
            return list;
        }
        public int numero_de_horaio_prof(string CI_de_profesor)
        {
            conexiones.Open();
            SqlCommand comando = new SqlCommand("select CI_de_profesor from Horarios where CI_de_profesor = @CI_de_profesor", conexiones);
            comando.Parameters.AddWithValue("CI_de_profesor", CI_de_profesor);
            SqlDataAdapter SDA = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            int a= dt.Rows.Count;
            conexiones.Close();
            return a;

        }
        public List<String> listar_id_profe(string CI_de_profesor)
        {
            conexiones.Open();
            string comando = ("select id_prof from Horarios where CI_de_profesor = " + CI_de_profesor);
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            List<String> list = new List<String>();
            while (leer.Read())
            {
                list.Add(leer["id_prof"].ToString());
            }
            leer.Close();
            conexiones.Close();
            return list;
        }
        public string mostrar_horario(string columna, int cont)
        {
            conexiones.Open();
            string comando = ("select " + columna + " from Horarios where id_prof = " + cont);
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
        public List<String> listar_id_estudiante(string curso)
        {
            conexiones.Open();
            string comando = ("select id_estudiante from Estudiante where curso = '" + curso+"'");
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
        public List<string>  datos_de_estudiante(string CI_de_tutor, string columna)
        {
            conexiones.Open();
            string comando = ("select "+ columna + " from Lista_de_Asistencia as l, Estudiante as e where CI_de_tutor = "+ Convert.ToInt32(CI_de_tutor) + " and l.id_estudiante = e.id_estudiante and asistencia != 'PUNTUAL'");
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            List<String> list = new List<String>();
            while (leer.Read())
            {
                list.Add(leer["" + columna + ""].ToString());
            }
            leer.Close();
            conexiones.Close();
            return list;
        }
        public int hay_asistencia(string curso, string materia, string fecha)
        {
            conexiones.Open();
            SqlCommand comando = new SqlCommand("select curso, materia, fecha from Lista_de_Asistencia where curso = @curso and materia = @materia and fecha = @fecha", conexiones);
            comando.Parameters.AddWithValue("curso", curso);
            comando.Parameters.AddWithValue("materia", materia);
            comando.Parameters.AddWithValue("fecha", fecha);
            SqlDataAdapter SDA = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            int a = dt.Rows.Count;
            conexiones.Close();
            return a;
        }
        public List<string> cargar_notas(string curso, string materia, string fecha)
        {
            conexiones.Open();
            string comando = ("select asistencia from Lista_de_Asistencia where curso = '" + curso + "' and materia = '" + materia + "' and fecha = '" + fecha + "'");
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            List<String> list = new List<String>();
            while (leer.Read())
            {
                list.Add(leer["asistencia"].ToString());
            }
            leer.Close();
            conexiones.Close();
            return list;
        }
    }
    
}
