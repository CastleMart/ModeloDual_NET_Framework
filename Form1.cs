using ModeloDual_NET_Framework.Modelos.Cursos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDual_NET_Framework
{
    public partial class Form1 : Form
    {

        private Actividad act =  new Actividad();
        private Tema tema = new Tema();
        private ConsultaActividad consulta = new ConsultaActividad ();
        private DataTable dt = new DataTable ();

        
        public Form1()
        {
            InitializeComponent();
            categoriasTemas();
        }

        public void categoriasTemas()
        {
            cboxTema.DataSource = null;
            cboxTema.Items.Clear ();

            try
            {
                consulta.busquedaTemaComboBox(dt);
                cboxTema.ValueMember = "idTema";
                cboxTema.DisplayMember = "nombreTema";
                cboxTema.DataSource = dt;
            }catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);
            }
        }

        public void limpiarCajas()
        {
            //tboxNoAct.Text = "";
            tboxNombreAct.Text = "";
            tboxHorasAct.Text = "";
            tBoxDescAct.Text = "";
            
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarAct_Click(object sender, EventArgs e)
        {

            
            try
            {
                act.Id = int.Parse(tboxNoAct.Text);
                tema.Id = 1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            limpiarCajas();

            if (consulta.buscarActividad(act, tema))
            {
                
                tboxNoAct.Text = act.Id.ToString();
                tboxNombreAct.Text = act.Nombre;
                tBoxDescAct.Text = act.Descripcion;
                tboxHorasAct.Text = act.Horas.ToString();
            }
            else
            {
                MessageBox.Show("No existe el registro solicitado.");
            }
            
            
        }



    }
}
