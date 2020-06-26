using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 

namespace AyD.Clase
{
    class conexion
    {
        private string cadenadeconexion = "Data Source=GIGASERVY-64; Initial Catalog=AYD; Integrated Security =True";
        SqlConnection Conexion;
        private SqlConnection conexiones = new SqlConnection("Data Source=GIGASERVY-64; Initial Catalog=AYD; Integrated Security =True");
        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.cadenadeconexion);
            return this.Conexion;
        }
        public bool insertar(string comandoSQL)
        {
            try
            {
                
                SqlCommand comando = new SqlCommand();
                comando.CommandText = comandoSQL;
                comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }


        }
        public string comprovar(string Usuario, string contraseña)
        {
            conexiones.Open();
            string comando = ("select rango from Persona where Usuario = '" + Usuario + "' and contraseña = '" + contraseña + "'");
            SqlCommand cmd = new SqlCommand(comando, conexiones);
            SqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string a = leer["rango"].ToString();
                leer.Close();
                conexiones.Close();
                return a;

            }
            leer.Close();
            conexiones.Close();
            return "error";
            
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
        public bool modificar(string comandoSQL)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.CommandText = comandoSQL;
                comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                comando.ExecuteNonQuery();
                Conexion.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public int Verificador_de_nombre_de_usuario(string Usuario)
        {
            conexiones.Open();
            SqlCommand comando = new SqlCommand("select Nombre from Persona where Usuario = @Usuario", conexiones);
            comando.Parameters.AddWithValue("Usuario", Usuario);
            SqlDataAdapter SDA = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            return dt.Rows.Count;//devuelve el numero de busquedas

        }
        

    }
}
