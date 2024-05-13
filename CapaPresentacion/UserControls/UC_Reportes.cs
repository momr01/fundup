using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using CapaNegocio;
using System.Collections;
using Bunifu.DataViz;
using System.Security.Cryptography.Xml;
using System.Windows.Media.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Krypton.Toolkit;
using System.Drawing.Imaging;

using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Pdf.Advanced;
using CapaPresentacion.Formularios;

using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using PdfSharp.Charting;
using System.IO;
using iTextSharp.tool.xml.html.table;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using System.Linq.Expressions;

namespace CapaPresentacion.UserControls
{
    public partial class UC_Reportes : UserControl
    {
        Usuario _usuario = new Usuario();
        CN_Dinero CN_Dinero = new CN_Dinero();

        public UC_Reportes(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            dpFechaInicio.Value = DateTime.Now.AddMonths(-6);
        }



        private void MostrarMovimientos()
        {
            CN_Dinero mov = new CN_Dinero();
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

        protected void DrawPageBorder(PdfWriter writer, iTextSharp.text.Document document, PdfContentByte canvas)
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

        private String primeraLetraMayuscula(String text)
        {
            char[] letras = text.ToCharArray();
            letras[0] = char.ToUpper(letras[0]);
            return new string(letras);
        }

        private void generarReporte()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", "reporte-" + _usuario.apellidoUsuario + "-" + DateTime.Now.ToString("yyyyMMdd") + "-"+ DateTime.Now.ToString("HHmmss"));


            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@USUARIO", primeraLetraMayuscula(_usuario.nombreUsuario!) + " " + primeraLetraMayuscula(_usuario.apellidoUsuario!));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EMAIL", _usuario.emailUsuario);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            decimal total = 0;
         
            foreach (DataGridViewRow row in tableDinero.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["FECHA"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["DESCRIPCION"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["INGRESO"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["GASTO"].Value.ToString() + "</td>";
                filas += "</tr>";
              
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());




            if (savefile.ShowDialog() == DialogResult.OK) //confirmamos que queremos guardar
            {
               
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create)) //dentro de archivo de memoria
                    {
                        //Creamos un nuevo documento y lo definimos como PDF
                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25); //margenes

                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream); //documento y archivo de memoria que estamos creando
                        pdfDoc.Open();
                        pdfDoc.Add(new Phrase(""));

                        PdfContentByte canvas = new PdfContentByte(writer);

                        DrawPageBorder(writer, pdfDoc, canvas);

                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.fundup, System.Drawing.Imaging.ImageFormat.Png);
                            img.ScaleToFit(100, 100);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 30);

                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(PaginaHTML_Texto))
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
                generarReporte();


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

