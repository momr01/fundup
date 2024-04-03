using CapaNegocio;
using Entidades;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.UserControls
{
    public partial class UC_Graficos : UserControl
    {
       
        CN_Dinero CN_Dinero = new CN_Dinero();
        Usuario _usuario;

        public UC_Graficos(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_PRINT = 791;

        /// <summary>
        /// The WM_PRINT drawing options
        /// </summary>
        [Flags]
        private enum DrawingOptions
        {
            /// <summary>
            /// Draws the window only if it is visible.
            /// </summary>
            PRF_CHECKVISIBLE = 1,

            /// <summary>
            /// Draws the nonclient area of the window.
            /// </summary>
            PRF_NONCLIENT = 2,
            /// <summary>

            /// Draws the client area of the window.
            /// </summary>
            PRF_CLIENT = 4,

            /// <summary>
            /// Erases the background before drawing the window.
            /// </summary>
            PRF_ERASEBKGND = 8,

            /// <summary>
            /// Draws all visible children windows.
            /// </summary>
            PRF_CHILDREN = 16,

            /// <summary>
            /// Draws all owned windows.
            /// </summary>
            PRF_OWNED = 32
        }


        /// <summary>
        /// /////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="tipo"></param>

        private void GraficoFechas(List<Dinero> lista, string tipo)
        {
            bunifuDataViz1.Visible = true;
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_line);

            lista.ForEach(item =>
            {
                dataPoint.addLabely(String.Format("{0:d/M/yy}", item.FechaDinero), item.ImporteDinero.ToString());
            });



            cnv.addData(dataPoint);
            bunifuDataViz1.Render(cnv);
            lblTituloGrafico.Text = tipo + " desde " + String.Format("{0:d/M/yy}", dpFecha1.Value) + " hasta " + String.Format("{0:d/M/yy}", dpFecha2.Value);


        }

        private void GraficoCategorias(List<Dinero> lista, string tipo)
        {
            bunifuDataViz1.Visible = true;
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_pie);

            lista.ForEach(item =>
            {
                dataPoint.addLabely(item.Categoria?.NombreCategoria?.ToString(), item.ImporteDinero.ToString());
            });



            cnv.addData(dataPoint);
            bunifuDataViz1.Render(cnv);
            lblTituloGrafico.Text = tipo + " según Categorías";
        }

        private void LimpiarCanvas()
        {
            bunifuDataViz1.Visible = false;
            lblTituloGrafico.Text = "";
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (cbFiltro1.SelectedIndex == 0 && cbFiltro2.SelectedIndex == 0)
            {
                List<Dinero> lista = new List<Dinero>();
                lista = CN_Dinero.GetGraficoPorCategorias(_usuario.idUsuario, 'I');
                GraficoCategorias(lista, "Ingresos");
               
            }
            else if (cbFiltro1.SelectedIndex == 0 && cbFiltro2.SelectedIndex == 1)
            {
                List<Dinero> lista = new List<Dinero>();
                lista = CN_Dinero.GetGraficoPorFecha(dpFecha1.Value, dpFecha2.Value, _usuario.idUsuario, 'I');
                GraficoFechas(lista, "Ingresos");
               
            }
            else if (cbFiltro1.SelectedIndex == 1 && cbFiltro2.SelectedIndex == 0)
            {
                List<Dinero> lista = new List<Dinero>();
                lista = CN_Dinero.GetGraficoPorCategorias(_usuario.idUsuario, 'G');
                GraficoCategorias(lista, "Gastos");
               

            }
            else if (cbFiltro1.SelectedIndex == 1 && cbFiltro2.SelectedIndex == 1)
            {
                List<Dinero> lista = new List<Dinero>();
                lista = CN_Dinero.GetGraficoPorFecha(dpFecha1.Value, dpFecha2.Value, _usuario.idUsuario, 'G');
                GraficoFechas(lista, "Gastos");
               

            }
            else
            {
                MessageBox.Show("No fue posible generar un gráfico. Por favor intente con otras opciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCanvas();
            }



        }

        private void cbFiltro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltro2.SelectedIndex == 1)
            {
                dpFecha1.Visible = true; dpFecha2.Visible = true;
            }
            else
            {
                dpFecha1.Visible = false; dpFecha2.Visible = false;
            }


        }

        private void UC_Graficos_Load(object sender, EventArgs e)
        {

        }

        

   


    }
}
