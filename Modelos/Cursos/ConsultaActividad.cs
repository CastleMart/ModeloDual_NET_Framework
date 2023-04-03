using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDual_NET_Framework.Modelos.Cursos
{
    internal class ConsultaActividad : Conexion
    {

        public Boolean buscarActividad(Actividad actividad, Tema tema)
        {
            actividad.Nombre = "Mario";
            actividad.Calificacion = 10;
            actividad.Descripcion = "Miau";
            

            return false;
        }



        public Boolean printNombre(Form1 formulario)
        {

            return true;
        }




        public Boolean insertarActividad(Actividad actividad, Tema tema)
        {
            Boolean respuesta = false;

            String sql = "INSERT INTO modelodual_db.actividad (idActividad,nombreAct, Horas, descripcion, idTema) VALUES " +
                "('"+ actividad.Id+ "','"+ actividad.Nombre+"', '"+actividad.Horas+"', '"+actividad.Descripcion+"', '"+tema.Id+"')";

            MySqlConnection conexionBD = Conexion.conectar();
            conexionBD.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conexionBD);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha guardado el registro.");
                respuesta = true;
                
            }catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
                
            }

            return respuesta;

        }


    }
}
