using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyD.BDD
{
    class Coneccion_de_padres
    {
        private SqlConnection conexiones = new SqlConnection("Data Source=GIGASERVY-64; Initial Catalog=AYD; Integrated Security =True");
        public List<string> datos_de_estudiante(string CI_de_tutor, string columna)
        {
            conexiones.Open();
            string comando = ("select p." + columna + " from Publicacion_de_tareas as p, Estudiante as e where e.CI_de_tutor = " + Convert.ToInt32(CI_de_tutor) + " and p.curso = e.curso");
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
        public List<string> notas_de_estudiante(string CI_de_tutor, string columna)
        {
            conexiones.Open();
            string comando = ("select p." + columna + " from Calificacion as p, Estudiante as e where e.CI_de_tutor = " + Convert.ToInt32(CI_de_tutor) + " and p.id_estudiante = e.id_estudiante");
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
    }
}
