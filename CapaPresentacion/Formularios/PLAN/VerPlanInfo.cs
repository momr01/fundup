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
    public partial class VerPlanInfo : Form
    {
        double? _capital;
        double? _valorDiario;

        public VerPlanInfo(double? capital, double? valorDiario)
        {
            InitializeComponent();
            _capital = capital;
            _valorDiario = valorDiario;
        }

        private void VerPlanInfo_Load(object sender, EventArgs e)
        {
            lblObjetivo.Text = "$ " + String.Format("{0:#,##0.00}", _capital);
            lblValorDiario.Text = "$ " + String.Format("{0:#,##0.00}", _valorDiario);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
