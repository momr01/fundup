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
            //  listBox1.Font = new Font("Century Gothic", 20);
            // listBox1.ItemHeight = 100;
            /*  listBox1.Items.Add($"Nombre: {_finanza.Name}");

              listBox1.Items.Add($"Monto mínimo: ${_finanza.MinAmount}");
              listBox1.Items.Add($"Monto máximo: ${_finanza.MaxAmount}");
              listBox1.Items.Add($"País: {_finanza.Country}");
              listBox1.Items.Add($"Tipo de Moneda: {_finanza.CurrencyDesc}");
              listBox1.Items.Add($"Moneda: {_finanza.CurrencySymbol}");
              listBox1.Items.Add($"Mercados que abarca: {_finanza.Market}");
              listBox1.Items.Add($"Tipos disponibles: {_finanza.Types}");
              listBox1.Items.Add($"Costo inicial para invertir: ${_finanza.Costs}");
              listBox1.Items.Add($"Perfil del Inversor: {_finanza.Profile}");
              listBox1.Items.Add($"Riesgo asociado a la inversión: {_finanza.Risk}");
              listBox1.Items.Add($"Rentabilidad: ${_finanza.Profitability}");*/

            lblNombreTitulo.Text = _finanza.Name.ToString().ToUpper();
            lblNombre.Text = _finanza.Name;
            //lblMinimo.Text = "$" + _finanza.MinAmount;
            lblMinimo.Text = MostrarImportes(_finanza.MinAmount);
            // lblMaximo.Text = "$" + _finanza.MaxAmount;
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

            // Navigate to a URL.
            //System.Diagnostics.Process.Start(lblUrl.Text as String);
            var psi = new ProcessStartInfo(_finanza.Url)
            {
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
