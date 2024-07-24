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
using DinkToPdf;
using DinkToPdf.Contracts;
using PuppeteerSharp;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using static System.Resources.ResXFileRef;
using System.Reflection;

namespace CapaPresentacion.UserControls
{
    public class CustomAssemblyLoadContext : System.Runtime.Loader.AssemblyLoadContext
    {
        public IntPtr LoadUnmanagedLibrary(string absolutePath)
        {
            return LoadUnmanagedDllFromPath(absolutePath);
        }

        protected override IntPtr LoadUnmanagedDll(string unmanagedDllName)
        {
            return LoadUnmanagedDllFromPath(unmanagedDllName);
        }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            return null;
        }
    }
    /* public class CustomAssemblyLoadContext : System.Runtime.Loader.AssemblyLoadContext
     {
         protected override IntPtr LoadUnmanagedDll(string unmanagedDllName)
         {
             return LoadUnmanagedDllFromPath(unmanagedDllName);
         }
     }*/

    public partial class UC_Reportes : UserControl
    {
        Usuario _usuario = new Usuario();
        CN_Dinero CN_Dinero = new CN_Dinero();
        private readonly IConverter _converter;

        public UC_Reportes(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            dpFechaInicio.Value = DateTime.Now.AddMonths(-6);

            /* var context = new CustomAssemblyLoadContext();
             context.LoadUnmanagedLibrary(@"./path/to/libwkhtmltox.dll"); // Update the path as necessary
             _converter = new SynchronizedConverter(new PdfTools());*/
            var context = new CustomAssemblyLoadContext();
            context.LoadUnmanagedLibrary(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libwkhtmltox.dll"));

            _converter = new SynchronizedConverter(new PdfTools());
        }

        private void GeneratePdf3()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save PDF File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string outputPath = saveFileDialog.FileName;

                    // string htmlContent = "<h1>Hello, world!</h1><p>This is a PDF generated from HTML using DinkToPdf!</p>";
                    //string htmlContent = $"<head>\r\n    <title>FUNDUP - Reporte</title>\r\n    <style>\r\n        table.border {\r\n            border-collapse: collapse;\r\n        }\r\n\r\n            table.border th {\r\n                padding: 5px;\r\n                border: 1px solid black;\r\n            }\r\n\r\n            table.border td {\r\n                padding: 5px;\r\n                border: 1px solid black;\r\n            }\r\n    </style>\r\n</head>\r\n<body>\r\n    <table style=\"width:100%\">\r\n        <tr>\r\n            <td style=\"width:20%\"></td>\r\n            <td style=\"width:60%\" align=\"center\" valign=\"top\">\r\n                <table>\r\n                    <tr><td align=\"center\"><h2 style=\"margin:0px; font-size:30px\">FUNDUP</h2></td></tr>\r\n                    <tr><td align=\"center\"><h2 style=\"margin: 0px; font-size: 30px\">Reporte de movimientos</h2></td></tr>\r\n                </table>\r\n            </td>\r\n\r\n        </tr>\r\n\r\n        <tr><td colspan=\"3\" height=\"20\"></td></tr>\r\n\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <table style=\"width:100%\">\r\n                    <tr>\r\n                        <td colspan=\"1\" style=\"width:20%\">Usuario:</td>\r\n                        <td colspan=\"3\" style=\"width:80%;border-bottom:1px solid black\">@USUARIO</td>\r\n                    </tr>\r\n                </table>\r\n                <table style=\"width:100%\">\r\n                    <tr>\r\n                        <td style=\"width:20%\">Email:</td>\r\n                        <td style=\"width:50%;border-bottom:1px solid black\">@EMAIL</td>\r\n                        <td style=\"width:10%\">Fecha:</td>\r\n                        <td style=\"width:20%;border-bottom:1px solid black\">@FECHA</td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n            <td></td>\r\n        </tr>\r\n\r\n        <tr><td colspan=\"3\" height=\"30\"></td></tr>\r\n\r\n        <tr>\r\n            <td colspan=\"3\">\r\n                <table class=\"border\" style=\"width:100%;\">\r\n                    <thead>\r\n                        <tr style=\"background-color:#D8D8D8\">\r\n                            <th>Fecha y Hora</th>\r\n                            \r\n                            <th>Ingreso</th>\r\n                            <th>Gasto</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n                        @FILAS\r\n                        <tr>\r\n                            <td style=\"border: 0px !important\"></td>\r\n                            <td style=\"border: 0px !important\"></td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n\r\n</body>";

                    string filas = string.Empty;
                    decimal total = 0;

                    foreach (DataGridViewRow row in tableDinero.Rows)
                    {
                        filas += "<tr>";
                        filas += "<td style=\"padding: 5px;border: 1px solid black;\">" + row.Cells["FECHA"].Value.ToString() + "</td>";
                         filas += "<td style=\"padding: 5px;border: 1px solid black;\">" + row.Cells["DESCRIPCIÓN"].Value.ToString() + "</td>";
                        filas += "<td style=\"padding: 5px;border: 1px solid black;\">" + row.Cells["INGRESO"].Value.ToString() + "</td>";
                        filas += "<td style=\"padding: 5px;border: 1px solid black;\">" + row.Cells["GASTO"].Value.ToString() + "</td>";
                        filas += "</tr>";

                    }
               //     PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
                //    PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", total.ToString());

                    string htmlContent = $@"

<body>
    <table style=""width:100%"">
        <tr>
            <td style=""width:20%""></td>
            <td style=""width:60%"" align=""center"" valign=""top"">
                <table>
                    <tr><td align=""center""><h2 style=""margin:0px; font-size:30px"">FUNDUP</h2></td></tr>
                    <tr><td align=""center""><h2 style=""margin: 0px; font-size: 30px"">Reporte de movimientos</h2></td></tr>
                </table>
            </td>

        </tr>

        <tr><td colspan=""3"" height=""20""></td></tr>

        <tr>
            <td colspan=""2"">
                <table style=""width:100%"">
                    <tr>
                        <td colspan=""1"" style=""width:20%"">Usuario:</td>
                        <td colspan=""3"" style=""width:80%;border-bottom:1px solid black"">{primeraLetraMayuscula(_usuario.nombreUsuario!)} {primeraLetraMayuscula(_usuario.apellidoUsuario!)}</td>
                    </tr>
                </table>
                <table style=""width:100%"">
                    <tr>
                        <td style=""width:20%"">Email:</td>
                        <td style=""width:50%;border-bottom:1px solid black"">{_usuario.emailUsuario}</td>
                        <td style=""width:10%"">Fecha:</td>
                        <td style=""width:20%;border-bottom:1px solid black"">{DateTime.Now.ToString("dd/MM/yyyy")}</td>
                    </tr>
                </table>
            </td>
            <td></td>
        </tr>

        <tr><td colspan=""3"" height=""30""></td></tr>

        <tr>
            <td colspan=""3"">
                <table class=""border"" style=""width:100%;border-collapse: collapse;"">
                    <thead>
                        <tr style=""background-color:#D8D8D8"">
                            <th style=""padding: 5px;border: 1px solid black;"">Fecha y Hora</th>
                            <th style=""padding: 5px;border: 1px solid black;"">Descripción</th>
                            <th style=""padding: 5px;border: 1px solid black;"">Ingreso</th>
                            <th style=""padding: 5px;border: 1px solid black;"">Gasto</th>
                        </tr>
                    </thead>
                    <tbody>
                       {filas}
                        <tr>
                            <td style=""border: 0px !important""></td>
                            <td style=""border: 0px !important""></td>
                        </tr>
                    </tbody>
                </table>
            </td>
        </tr>
    </table>

</body>


";
                    
                    var doc = new HtmlToPdfDocument()
                    {
                        GlobalSettings = {
                            ColorMode = DinkToPdf.ColorMode.Color,
                            Orientation = DinkToPdf.Orientation.Portrait,
                            PaperSize = DinkToPdf.PaperKind.A4,
                        },
                        Objects = {
                            new ObjectSettings()
                            {
                                PagesCount = true,
                                HtmlContent = htmlContent,
                                WebSettings = { DefaultEncoding = "utf-8" },
                                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page [page] of [toPage]", Line = true },
                                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "This is the footer." }
                            }
                        }
                    };

                    byte[] pdf = _converter.Convert(doc);

                    File.WriteAllBytes(outputPath, pdf);

                    MessageBox.Show($"PDF generated and saved to {outputPath}");
                }
            }
       
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
                        row.Cells[i].Style.BackColor = System.Drawing.Color.Gray;
                        row.Cells[i].Style.ForeColor = System.Drawing.Color.White;
                    }
                    row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
                    row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

                }
                else
                {
                    row.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
                    row.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
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

        private void GeneratePdf2()
        {
            // Define the HTML content
            string htmlContent = "<h1>Hello, world!</h1><p>This is a PDF generated from HTML using PdfSharp and HtmlRenderer.PdfSharp!</p>";

            // Create a new PDF document
            PdfSharp.Pdf.PdfDocument pdf = new PdfSharp.Pdf.PdfDocument();

            // Render the HTML content into the PDF document
         //   PdfGenerator.GeneratePdf(htmlContent, PdfSharp.PageSize.A4, pdf);

            // Save the PDF document to a file
            string outputPath = "output.pdf";
            pdf.Save(outputPath);

            MessageBox.Show($"PDF generated and saved to {outputPath}");
        }

        private async Task GeneratePdf()
        {
            // Download the Chromium revision if necessary
           // await new BrowserFetcher().DownloadAsync(BrowserFetcher);

            // Launch the browser
            var browser = await Puppeteer.LaunchAsync(new LaunchOptions
            {
                Headless = true
            });

            // Create a new page
            var page = await browser.NewPageAsync();

            // Set the HTML content
            string htmlContent = "<h1>Hello, world!</h1><p>This is a PDF generated from HTML using PuppeteerSharp!</p>";
            await page.SetContentAsync(htmlContent);

            // Generate the PDF
            await page.PdfAsync("output.pdf");

            // Close the browser
            await browser.CloseAsync();

            MessageBox.Show("PDF generated and saved to output.pdf");
        }

        private void generarReporte2()
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
               // filas += "<td>" + row.Cells["DESCRIPCIÓN"].Value.ToString() + "</td>";
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
                    // iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25); //margenes
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);                                                                                                           // iTextSharp.text.Document pdfDoc = new();
                  

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream); //documento y archivo de memoria que estamos creando

                    pdfDoc.Open();
                   // writer.CloseStream = false;
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
                //generarReporte2();
                // await GeneratePdf();
                GeneratePdf3();


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Ocurrió un error al intentar generar el reporte. Por favor, intente nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

