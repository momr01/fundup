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
        //double? categoriasIngresos = 0;
        // double? categoriasGastos = 0;

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


                if (tipo == 'I')
                {
                    if(registro?.ImporteDinero?.ToString().Length > 0)
                    {
                        totalIngresos = registro.ImporteDinero;
                        lblTotalIngresos.Text = "$ " + String.Format("{0:n}", registro.ImporteDinero);
                    }
                    else
                    {
                        totalIngresos = 0;
                        lblTotalIngresos.Text = "$ 0.00";
                    }
                    
                }
                else if (tipo == 'G')
                {
                    if (registro?.ImporteDinero?.ToString().Length > 0)
                    {
                        totalGastos = registro.ImporteDinero;
                        lblTotalGastos.Text = "$ " + String.Format("{0:n}", registro.ImporteDinero);
                    }
                    else
                    {
                        totalGastos = 0;
                        lblTotalGastos.Text = "$ 0.00";
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        private void CargarCategoriasUsadas(char tipo)
        {
            try
            {
                Dinero registro = new Dinero();
                registro = CN_Dinero.TableroCategoriasUsadas(idUsuario, tipo);


                if (tipo == 'I')
                {
                    if (registro?.ImporteDinero?.ToString().Length > 0)
                    {
                        lblCategoriasIngresos.Text = registro.ImporteDinero.ToString();
                    }
                    else
                    {
                        lblCategoriasIngresos.Text = "0";
                    }
                }
                else if (tipo == 'G')
                {
                    if (registro?.ImporteDinero?.ToString().Length > 0)

                    {
                        lblCategoriasGastos.Text = registro.ImporteDinero.ToString();
                    }
                    else
                    {
                        lblCategoriasGastos.Text="0";
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        private void CargarUltimaFecha()
        {
            try
            {
                Dinero registro = new Dinero();
                registro = CN_Dinero.TableroUltimaFecha(idUsuario);

                if (registro?.FechaDinero?.ToString().Length > 0)
                {
                    DateTime dateTime = registro.FechaDinero.Value.Date;
                    lblUltimaFecha.Text = dateTime.ToShortDateString();
                }
                else
                {
                    lblUltimaFecha.Text = "--/--/---";
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
            try
            {
                CargarImporteTotal('I');
                CargarImporteTotal('G');
                CargarUltimaFecha();
                CargarCategoriasUsadas('I');
                CargarCategoriasUsadas('G');
                CargarResultado();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }


        }


    }
}
