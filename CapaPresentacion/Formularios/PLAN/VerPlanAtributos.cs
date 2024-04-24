using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.PLAN
{
    public partial class VerPlanAtributos : Form
    {
        Plan _plan;
        public VerPlanAtributos(Plan plan)
        {
            InitializeComponent();
            _plan = plan;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CargarDatos()
        {

            lblDescripcion.Text = _plan.DescripcionPlan;
            lblFechaInicio.Text = FormatoFechaSinHora(_plan.FechaInicioPlan);
            lblFechaFin.Text = FormatoFechaSinHora(_plan.FechaFinPlan);
            lblCapital.Text = "$ " + String.Format("{0:#,##0.00}", _plan.CapitalPlan);


            if (_plan.EstaCompletoPlan! == true)
            {
                lblFechaCompleto.Visible = true;
                txtFechaCompleto.Visible = true;
                txtFechaCompleto.Text = FormatoFechaSinHora(_plan.FechaCompleto);
            }
            else
            {
                lblFechaCompleto.Visible = false;
                txtFechaCompleto.Visible = false;
                txtFechaCompleto.Text = "";
            }
        }

        private String FormatoFechaSinHora(DateTime? fecha)
        {
            return Convert.ToDateTime(fecha).Day.ToString() + "/" + Convert.ToDateTime(fecha).Month.ToString() + "/" + Convert.ToDateTime(fecha).Year.ToString();
        }

        private void VerPlanAtributos_Load(object sender, EventArgs e)
        {
            try
            {
               
                CargarDatos();
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }


        }
    }
}
