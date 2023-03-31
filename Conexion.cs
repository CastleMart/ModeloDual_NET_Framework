using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDual_NET_Framework
{
    internal class Conexion
    {
        private String mensaje;
        public Conexion()
        {
            String servidor = "localhost",
                    puerto = "3306",
                    usuario = "root",
                    password = "marioantonio2312",
                    cadenaConexion,
                    datos = "";


            cadenaConexion = "server = " + servidor + "; port=" + puerto + "; user id =" + usuario + "; password=" + password + "; database = Mysql;";

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                MySqlDataReader reader = null;

                MySqlCommand comando = new MySqlCommand("SHOW DATABASES", conexion);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                }
            }
            catch (MySqlException e)
            {
                this.mensaje = e.ToString();
            }

            this.mensaje = datos;
            conexion.Close();

            MessageBox.Show(mensaje);
        }

        public String retornarMensaje()
        {
            return this.mensaje;
        }
    }
}
