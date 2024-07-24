using CapaNegocio;
using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;

namespace CapaPresentacion.UserControls
{
    public partial class UC_Graficos : UserControl
    {

        CN_Dinero CN_Dinero = new();
        Usuario _usuario;
       

        public UC_Graficos(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }


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
            lblTituloGrafico.Text = $"{tipo} desde {String.Format("{0:d/M/yy}", dpFecha1.Value)} hasta {String.Format("{0:d/M/yy}", dpFecha2.Value)}";

            if(lista.Count > 0)
            {
                btnPDF.Visible = true;
            } else
            {
                btnPDF.Visible = false;
            }
            

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

            if(lista.Count > 0)
            {
                btnPDF.Visible = true;
            } else
            {
                btnPDF.Visible = false;
            }
            
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
            dpFecha1.Value = DateTime.Now.AddMonths(-6);

        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            GenerarReporte();
           
        }

      

            private Bitmap Screenshot()
        {
            Point location = PointToScreen(bunifuDataViz1.Location);
            Size size = bunifuDataViz1.Size;
            Bitmap bmpScreenshot = new(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics g = Graphics.FromImage(bmpScreenshot);
            g.CopyFromScreen(location.X, location.Y, 0, 0, new Size(size.Width, size.Height));

            return bmpScreenshot;
        }

        protected void DrawPageBorder(PdfWriter writer, Document document, PdfContentByte canvas)
        {
            var pageBorderRect = new iTextSharp.text.Rectangle(document.PageSize);
            var content = writer.DirectContent;

            pageBorderRect.Left += document.LeftMargin - 10;
            pageBorderRect.Right -= document.RightMargin - 12;
            pageBorderRect.Top -= document.TopMargin - 12;
            pageBorderRect.Bottom += document.BottomMargin - 12;
            content.SetColorStroke(BaseColor.BLACK);
            canvas.SetLineWidth(pageBorderRect.Width);
            canvas.SetRGBColorStroke(0, 0, 0);
            canvas.SetLineDash(6f, 6f, 0f);
            content.Rectangle(pageBorderRect.Left, pageBorderRect.Bottom, pageBorderRect.Width, pageBorderRect.Height);
            content.Stroke();
        }

        private String PrimeraLetraMayuscula(String text)
        {
            char[] letras = text.ToCharArray();
            letras[0] = char.ToUpper(letras[0]);
            return new string(letras);
        }

        private void GenerarReporte()
        {
            SaveFileDialog savefile = new();
            savefile.FileName = string.Format("{0}.pdf", $"reporte-{_usuario.apellidoUsuario}-{DateTime.Now.ToString("yyyyMMdd")}-{DateTime.Now.ToString("HHmmss")}");

            string PaginaHTML_Texto = Properties.Resources.Plantilla_graficos.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TITLE", lblTituloGrafico.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@USUARIO", $"{PrimeraLetraMayuscula(_usuario.nombreUsuario!)} {PrimeraLetraMayuscula(_usuario.apellidoUsuario!)}");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EMAIL", _usuario.emailUsuario);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());


            if (savefile.ShowDialog() == DialogResult.OK) 
            {
               Document pdfDoc = new(PageSize.A4, 25, 25, 25, 25); //margenes

                using (FileStream stream = new(savefile.FileName, FileMode.Create, FileAccess.Write, FileShare.None)) //dentro de archivo de memoria
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream); //documento y archivo de memoria que estamos creando
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    PdfContentByte canvas = new(writer);

                    DrawPageBorder(writer, pdfDoc, canvas);

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.fundup, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(100, 100);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 30);

                    pdfDoc.Add(img);


                    System.Drawing.Image image2 = Screenshot();
                    iTextSharp.text.Image img3 = iTextSharp.text.Image.GetInstance(image2, System.Drawing.Imaging.ImageFormat.Png);

                    double width = Screen.PrimaryScreen.Bounds.Width;
                    double height = Screen.PrimaryScreen.Bounds.Height;

                    if (width >= 1920 && height >= 1080)
                    {
                        img3.ScaleToFit(1100, 1000);
                        img3.SetAbsolutePosition(pdfDoc.LeftMargin, 50);

                    }
                    else
                    {
                        img3.ScaleToFit(790, 500);
                        img3.SetAbsolutePosition(pdfDoc.LeftMargin, 200);
                    }

                    pdfDoc.Add(img3);

                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }


                MessageBox.Show("Se generó el reporte exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                MessageBox.Show("Se canceló la generación del reporte.", "Tarea cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }


}
