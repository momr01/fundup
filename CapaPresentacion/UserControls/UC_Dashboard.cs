using CapaNegocio;
using Entidades;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        int idUsuario = 1;
        CN_Dinero CN_Dinero = new CN_Dinero();
        double? totalIngresos = 0;
        double? totalGastos = 0;

        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void CargarImporteTotal(char tipo)
        {
            try
            {
                Dinero registro = new Dinero();
                registro = CN_Dinero.TableroImportesTotales(idUsuario, tipo);
                

                if(tipo == 'I')
                {
                    totalIngresos = registro.ImporteDinero;
                    lblTotalIngresos.Text = "$ " + String.Format("{0:n}", registro.ImporteDinero);
                } else if(tipo == 'G')
                {
                    totalGastos = registro.ImporteDinero;
                    lblTotalGastos.Text = "$ " + String.Format("{0:n}", registro.ImporteDinero);
                }
                    
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void CargarResultado()
        {
            double? resultado = totalIngresos - totalGastos;
            lblResultado.Text = "$ " + String.Format("{0:n}", resultado);
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            CargarImporteTotal('I');
            CargarImporteTotal('G');
            //CargarCantidadCategorias();
            //CargarUltimaFecha();
            CargarResultado();

        }
    }
}
