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
        private ConsultaActividad consulta;

        
        public Form1()
        {
            InitializeComponent();
        }

        public string getNombre()
        {
            return tboxNombreAct.Text;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarAct_Click(object sender, EventArgs e)
        {
            act.Id = Int16.Parse(tboxNoAct.Text);
            tema.Id = 1;

            consulta.buscarActividad(act, tema);
            tboxNombreAct.Text = act.Nombre;
            tBoxDescAct.Text = act.Descripcion;
            tboxHorasAct.Text = act.Horas.ToString();
            
        }



    }
}
