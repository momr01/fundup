using CapaPresentacion.API.Modelos;
using com.itextpdf.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion.Formularios
{
    public partial class OpcionFinancieraDetalle : Form
    {
        private Finanza _finanza;
        public OpcionFinancieraDetalle(Finanza finanza)
        {
            InitializeComponent();
            _finanza = finanza;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void OpcionFinancieraDetalle_Load(object sender, EventArgs e)
        {

            lblNombreTitulo.Text = _finanza.Name.ToString().ToUpper();
            lblNombre.Text = _finanza.Name;
            lblMinimo.Text = MostrarImportes(_finanza.MinAmount);
            lblMaximo.Text = MostrarImportes(_finanza.MaxAmount);
            lblPais.Text = _finanza.Country;
            lblMoneda.Text = $"{_finanza.CurrencyDesc} - {_finanza.CurrencySymbol}";
            lblMercados.Text = UnirElementos(_finanza.Market);
            lblTipos.Text = UnirElementos(_finanza.Types);
            lblCosto.Text = "$" + _finanza.Costs;
            lblPerfil.Text = _finanza.Profile;
            lblRiesgo.Text = _finanza.Risk;
            lblRentabilidad.Text = _finanza.Profitability;
            lblUrl.Text = _finanza.Url;
        }

        private String MostrarImportes(String importe)
        {
            int number;

            bool success = int.TryParse(importe, out number);
            if (success)
            {
                return "$" + importe;
            }
            else
            {
                return importe;
            }
        }

        private String UnirElementos(List<string> elementos)
        {
            string elementosFinal = "";

            elementos.ForEach(elemento => { elementosFinal += elemento + " - "; });

            if(elementosFinal.Length > 0)
            {
                return elementosFinal.Substring(0, elementosFinal.Length - 3);
            } else
            {
                return elementosFinal;
            }

            
        }

        private void lblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.lblUrl.LinkVisited = true;

            var psi = new ProcessStartInfo(_finanza.Url)
            {
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
