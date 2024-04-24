using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class VerPlanCompletoInfo : Form
    {
        double _diasEnCompletar;
        double _difConObjetivo;

        public VerPlanCompletoInfo(double diasEnCompletar, double difConObjetivo)
        {
            InitializeComponent();
            _diasEnCompletar = diasEnCompletar;
            _difConObjetivo = difConObjetivo;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void VerPlanCompletoInfo_Load(object sender, EventArgs e)
        {
            if(_diasEnCompletar <= 0)
            {
                lblDiasEnCompletar.Text = "0 días.";
            } else
            {
                lblDiasEnCompletar.Text = _diasEnCompletar + " días.";
            }
           
            lblDifObjetivo.Text = _difConObjetivo + " días antes de la fecha objetivo.";
        }
    }
}
