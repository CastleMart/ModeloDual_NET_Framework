using ModeloDual_NET_Framework.Modelos.Cursos;
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
        public static MySqlConnection conectar()
        {
            String servidor = "localhost",
                    puerto = "3306",
                    usuario = "root",
                    bd = "modelodual_bd",
                    password = "marioantonio2312",
                    cadenaConexion,
                    datos = "";


            cadenaConexion = "Database="+ bd +"; Data Source = " + servidor + "; port=" + puerto + "; user id =" + usuario + "; password=" + password + ";";

            

            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                return conexion;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

    }
}
