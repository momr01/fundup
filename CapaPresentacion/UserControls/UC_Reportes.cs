using Entidades;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using CapaNegocio;


namespace CapaPresentacion.UserControls
{
    public partial class UC_Reportes : UserControl
    {
        private readonly Usuario _usuario = new();

        public UC_Reportes(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            dpFechaInicio.Value = DateTime.Now.AddMonths(-6);
        }

         private void MostrarMovimientos()
        {
            CN_Dinero mov = new();
            tableDinero.DataSource = mov.GetDineroPorFechas(_usuario.idUsuario, dpFechaInicio.Value, dpFechaFin.Value);
    
            AnularOrdenColumnas();
            EstiloFilasTotales();

            lblTotal.Text = (tableDinero.Rows.Count - 2).ToString();

            if (tableDinero.Rows.Count > 2)
            {
                btnReporte.Visible = true;
            }



        }

        private void EstiloFilasTotales()
        {
            foreach (DataGridViewRow row in tableDinero.Rows)
            {
                if (row.Cells[1].Value.ToString() == "SUBTOTALES" || row.Cells[1].Value.ToString() == "TOTAL")
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        row.Cells[i].Style.BackColor = Color.Gray;
                        row.Cells[i].Style.ForeColor = Color.White;
                    }
                    row.DefaultCellStyle.SelectionBackColor = Color.Gray;
                    row.DefaultCellStyle.SelectionForeColor = Color.White;

                }
                else
                {
                    row.DefaultCellStyle.SelectionBackColor = Color.White;
                    row.DefaultCellStyle.SelectionForeColor = Color.Black;
                }

            }
        }

        private void AnularOrdenColumnas()
        {
            foreach (DataGridViewColumn column in tableDinero.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
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
            SaveFileDialog savefile = new()
            {
                FileName = string.Format("{0}.pdf", $"reporte-{_usuario.apellidoUsuario}-{DateTime.Now.ToString("yyyyMMdd")}-{DateTime.Now.ToString("HHmmss")}")
            };


            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@USUARIO", $"{PrimeraLetraMayuscula(_usuario.nombreUsuario!)} {PrimeraLetraMayuscula(_usuario.apellidoUsuario!)}");
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EMAIL", _usuario.emailUsuario);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
         
            foreach (DataGridViewRow row in tableDinero.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["FECHA"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["DESCRIPCIÓN"].Value.ToString() + "</td>";
                filas += "<td>" + String.Format("{0:n2}", row.Cells["INGRESO"].Value) + "</td>";
                filas += "<td>" + String.Format("{0:n2}", row.Cells["GASTO"].Value) + "</td>";
                filas += "</tr>";
              
            }
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

                    using (StringReader sr = new(PaginaHTML_Texto))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        stream.Close();
                    }


                MessageBox.Show("Se generó el reporte exitosamente.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            } else
            {
                MessageBox.Show("Se canceló la generación del reporte.", "Tarea cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReporte_Click2(object sender, EventArgs e)
        {
            try
            {
                GenerarReporte();

            } catch
            {
               
                MessageBox.Show("Ocurrió un error al intentar generar el reporte. Por favor, intente nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarMovimientos();

            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }


    }
}

