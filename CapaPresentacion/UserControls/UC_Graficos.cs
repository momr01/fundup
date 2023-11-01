using CapaNegocio;
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

        Random rand = new Random();

        private void LoadChart()
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_splineArea);


            dataPoint.addLabely("Jan", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Feb", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Mar", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Apr", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jun", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jul", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Aug", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sep", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Oct", rand.Next(0, 500).ToString());

            cnv.addData(dataPoint);
            bunifuDataViz1.colorSet.Add(Color.Red);
            bunifuDataViz1.Render(cnv);

        }

        private void LoadLine()
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_line);


            dataPoint.addLabely("Jan", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Feb", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Mar", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Apr", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jun", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jul", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Aug", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sep", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Oct", rand.Next(0, 500).ToString());

            cnv.addData(dataPoint);
            //bunifuDataViz1.colorSet.Add(Color.Red);
            bunifuDataViz1.Render(cnv);

        }

        private void LoadPie()
        {
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_pie);


            dataPoint.addLabely("Jan", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Feb", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Mar", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Apr", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jun", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Jul", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Aug", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Sep", rand.Next(0, 500).ToString());
            dataPoint.addLabely("Oct", rand.Next(0, 500).ToString());

            cnv.addData(dataPoint);
            bunifuDataViz1.Render(cnv);

        }

        private void GraficoIngresosFechas(List<Dinero> lista)
        {
            bunifuDataViz1.Visible = true;
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_line);

            //dataPoint.addxyz("Hola", "hh", "ddd");
            //dataPoint.addxy("uno", "dos");
            //dataPoint.addxyLabel("Hola", "hh", "ddd");

            lista.ForEach(item =>
            {
                dataPoint.addLabely(String.Format("{0:d/M/yy}", item.FechaDinero), item.ImporteDinero.ToString());
            });



            cnv.addData(dataPoint);
            bunifuDataViz1.Render(cnv);
            lblTituloGrafico.Text = "Ingresos desde " + String.Format("{0:d/M/yy}", dpFecha1.Value) + " hasta " + String.Format("{0:d/M/yy}", dpFecha2.Value);

        }

        private void GraficoIngresosCategorias(List<Dinero> lista)
        {
            bunifuDataViz1.Visible = true;
            var cnv = new Bunifu.DataViz.Canvas();
            var dataPoint = new Bunifu.DataViz.DataPoint(Bunifu.DataViz.BunifuDataViz._type.Bunifu_pie);

            //dataPoint.addxyz("Hola", "hh", "ddd");
            //dataPoint.addxy("uno", "dos");
            //dataPoint.addxyLabel("Hola", "hh", "ddd");

            lista.ForEach(item =>
            {
                dataPoint.addLabely(item.Categoria?.NombreCategoria?.ToString(), item.ImporteDinero.ToString());
            });



            cnv.addData(dataPoint);
            bunifuDataViz1.Render(cnv);
            lblTituloGrafico.Text = "Ingresos según Categorías";
        }

        private void LimpiarCanvas()
        {
            bunifuDataViz1.Visible = false;
            lblTituloGrafico.Text = "";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //LoadChart();

            //LoadLine();


            /*List<Ingreso> lista = new List<Ingreso>();
            lista = CN_Ingreso.GetGraficoPorFecha(DateTime.Parse("01/10/2023"), DateTime.Parse("12/10/2023"));
            LoadLine2(lista);*/

            /*List<Ingreso> lista = new List<Ingreso>();
            lista = CN_Ingreso.GetGraficoPorCategorias();
            LoadPie2(lista);*/

            if (cbFiltro1.SelectedIndex == 0 && cbFiltro2.SelectedIndex == 0)
            {
                List<Dinero> lista = new List<Dinero>();
                lista = CN_Dinero.GetGraficoPorCategorias(_usuario.idUsuario, 'I');
                GraficoIngresosCategorias(lista);
            }
            else if (cbFiltro1.SelectedIndex == 0 && cbFiltro2.SelectedIndex == 1)
            {
                List<Dinero> lista = new List<Dinero>();
                lista = CN_Dinero.GetGraficoPorFecha(dpFecha1.Value, dpFecha2.Value, _usuario.idUsuario, 'I');
                GraficoIngresosFechas(lista);
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
