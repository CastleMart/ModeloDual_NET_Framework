using ModeloDual_NET_Framework.Modelos.Cursos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDual_NET_Framework.Controlador
{
    internal class CtrlActividad
    {
        private Actividad act = new Actividad();
        private Tema tema = new Tema();
        private ConsultaActividad consulta;
        private Form1 formAct;
        private DataTable dt = new DataTable();

        public CtrlActividad(Actividad act, Tema tema, ConsultaActividad consulta,Form1 formAct)
        {
            this.act = act;
            this.tema = tema;
            this.consulta = consulta;
            this.formAct = formAct;

        }


        /// <summary>
        /// Método que muestra un mansaje con opciones para aceptar eliminar o no un registro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private Boolean MessageBoxBtnAceptar_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("¡¡¿Desea eliminar registro permanentemente?!!", "Eliminación de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            return resultado == DialogResult.OK;
        }

        /// <summary>
        /// Método que muestra un mensaje para saber si se quiere actualizar el registro.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private Boolean MessageBoxBtnActualizar(object sender, EventArgs e)
        {
            DialogResult resultado;
            resultado = MessageBox.Show("¿Desea actualizar registro?", "Actualización de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            return resultado == DialogResult.OK;
        }

        /// <summary>
        /// Método que limpia en pantalla los mensajes de estado.
        /// </summary>
        private void labelEstadoLimpiar()
        {
            labelMensajeEstado.Text = "";
            labelMensajeEstado.Visible = false;
            labelMensajeEstado.ForeColor = Color.Black;
        }

        /// <summary>
        /// Método que expresa un mensaje satisfactorio según una accion del programa.
        /// </summary>
        /// <param name="mensaje"></param>
        private void labelEstadoMensajeBueno(String mensaje)
        {
            labelMensajeEstado.Text = mensaje;
            labelMensajeEstado.Visible = true;
            labelMensajeEstado.ForeColor = Color.Green;
        }

        /// <summary>
        /// Método que muestra un mensaje de estado de error en pantalla.
        /// </summary>
        /// <param name="mensaje"></param>
        private void labelEstadoMensajeError(String mensaje)
        {
            labelMensajeEstado.Text = mensaje;
            labelMensajeEstado.Visible = true;
            labelMensajeEstado.ForeColor = Color.Red;
        }

        /// <summary>
        /// Método que imprime un mensaje en pantalla advirtiendo las acciones que se están realizando.
        /// </summary>
        /// <param name="mensaje"></param>
        private void labelEstadoMensajeAdvertencia(String mensaje)
        {
            labelMensajeEstado.Text = mensaje;
            labelMensajeEstado.Visible = true;
            labelMensajeEstado.ForeColor = Color.Orange;
        }

        /// <summary>
        /// Simple mensaje en pantalla para notificar algo.
        /// </summary>
        /// <param name="mensaje"></param>
        private void labelEstadoMensajeNormal(String mensaje)
        {
            labelMensajeEstado.Text = mensaje;
            labelMensajeEstado.Visible = true;
            labelMensajeEstado.ForeColor = Color.Blue;
        }


        /// <summary>
        /// Método que muestra en pantalla las diferentes opciones de temas disponibles.
        /// </summary>
        public void categoriasTemas()
        {
            cboxTema.DataSource = null;
            cboxTema.Items.Clear();

            try
            {
                consulta.busquedaTemaComboBox(dt);
                cboxTema.ValueMember = "idTema";
                cboxTema.DisplayMember = "nombreTema";
                cboxTema.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        /// <summary>
        /// Método que limpia los textos de las cajas en el formulario.
        /// </summary>
        public void limpiarCajas()
        {
            //tboxNoAct.Text = "";
            tboxNombreAct.Text = "";
            tboxHorasAct.Text = "";
            tBoxDescAct.Text = "";

        }

        /// <summary>
        /// Método sin función por ahora....
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Método que realiza las opciones del botón buscar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarAct_Click(object sender, EventArgs e)
        {


            try
            {
                act.Id = int.Parse(tboxNoAct.Text);
                tema.Id = int.Parse(cboxTema.SelectedValue.ToString());
                labelEstadoLimpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            limpiarCajas();
            if (act.Id <= 0)
            {
                labelEstadoMensajeError("Solo se puede buscar IDs mayores a 0.");
            }
            else if (consulta.buscarActividad(act, tema))
            {

                tboxNoAct.Text = act.Id.ToString();
                tboxNombreAct.Text = act.Nombre;
                tBoxDescAct.Text = act.Descripcion;
                tboxHorasAct.Text = act.Horas.ToString();
            }
            else
            {
                labelEstadoMensajeNormal("No existe Registro");
                //MessageBox.Show("No existe el registro solicitado.");
            }


        }

        /// <summary>
        /// Método que realiza las acciones del botón guardar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarAct_Click(object sender, EventArgs e)
        {
            try
            {

                tema.Id = int.Parse(cboxTema.SelectedValue.ToString());
                act.Id = int.Parse(tboxNoAct.Text);
                act.Nombre = tboxNombreAct.Text;
                act.Descripcion = tBoxDescAct.Text;
                act.Horas = double.Parse(tboxHorasAct.Text);

                if (act.Id <= 0)
                {
                    labelEstadoMensajeError("Solo se puede guardar IDs Mayores a 0.");
                }
                else if (consulta.existeActividad(act, tema))
                {
                    Boolean respuesta = MessageBoxBtnActualizar(sender, e);
                    if (respuesta)
                    {
                        if (consulta.actualizarActividad(act, tema))
                        {

                            labelEstadoMensajeBueno("Registro Actualizado");
                            MessageBox.Show("Se ha actualizado el registro correctamente.");

                        }
                    }

                }
                else
                {
                    if (consulta.insertarActividad(act, tema))
                    {

                        labelEstadoMensajeBueno("Registro Guardado");
                        MessageBox.Show("Se ha guardado el registro correctamente.");

                    }
                }

            }
            catch (Exception ex)
            {

                labelEstadoMensajeError("Sin guardar");
                MessageBox.Show(ex.Message);
            }




        }

        /// <summary>
        /// Método realiza ciertas acciones al seleccionar un nuevo elemento del combo box tema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboxTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarCajas();
            labelEstadoLimpiar();
        }

        /// <summary>
        /// Método que elimina una actividad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarAct_Click(object sender, EventArgs e)
        {
            try
            {
                tema.Id = int.Parse(cboxTema.SelectedValue.ToString());
                act.Id = int.Parse(tboxNoAct.Text);
                if (act.Id <= 0)
                {
                    labelEstadoMensajeError("Id no válido para eliminar.");
                }
                else if (!consulta.existeActividad(act, tema))
                {
                    labelEstadoMensajeNormal("No hay registro para eliminar.");
                }
                else if (MessageBoxBtnAceptar_cancelar_Click(sender, e))
                {
                    if (consulta.eliminarActividad(act, tema))
                    {
                        limpiarCajas();
                        labelEstadoMensajeBueno("Registro Eliminado");
                        MessageBox.Show("Se ha eliminado el registro.");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// Método que limpiar el formulario al hacer click el bontón limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiarAct_Click(object sender, EventArgs e)
        {
            tboxNoAct.Text = "";
            limpiarCajas();
        }

        /// <summary>
        /// Método que detecta cuando el textBox del id ha sido modificado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tboxNoAct_TextChanged(object sender, EventArgs e)
        {
            //limpiarCajas();
            labelEstadoMensajeAdvertencia("Id modificado");
            //labelEstadoLimpiar();
        }
    }
}
