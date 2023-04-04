﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDual_NET_Framework.Modelos.Cursos
{
    internal class ConsultaActividad : Conexion
    {

        public Boolean busquedaTemaComboBox(DataTable dt)
        {
            Boolean seHizo = true;

            string sql = " SELECT idTema, nombreTema from tema;";

            MySqlConnection con = Conexion.conectar();

            try
            {

                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql,con); 
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                data.Fill(dt);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


            return seHizo;
        }

        /// <summary>
        /// Método que realiza una consulta de búsqueda según el id de la actividad y el tema.
        /// </summary>
        /// <param name="actividad"></param>
        /// <param name="tema"></param>
        /// <returns>todos los valores de la tabla actividad de la base de datos.</returns>
        public Boolean buscarActividad(Actividad actividad, Tema tema)
        {
            Boolean seHizo =  false;
            string sql = "Select * FROM actividad, tema WHERE actividad.idActividad = " + actividad.Id + " and actividad.idTema = " + tema.Id + " and actividad.idTema = tema.idTema";
            MySqlDataReader reader = null;
            MySqlConnection conn = Conexion.conectar();
            

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                //actividad.limpiarActividades();
                if (reader.HasRows)
                {
                    seHizo = true;
                    while (reader.Read())
                    {
                        
                        actividad.Id = int.Parse(reader.GetString(0));
                        actividad.Nombre = reader.GetString(1);
                        actividad.Horas = double.Parse(reader.GetString(2));
                        actividad.Descripcion = reader.GetString(3);
                        tema.Id = int.Parse(reader.GetString(4));
                        
                    }
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
            }

            return seHizo;
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
