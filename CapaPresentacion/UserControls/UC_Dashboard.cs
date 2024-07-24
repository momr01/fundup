using CapaNegocio;
using Entidades;

namespace CapaPresentacion.UserControls
{
    public partial class UC_Dashboard : UserControl
    {
        CN_Dinero CN_Dinero = new CN_Dinero();
        CN_Plan CN_Plan = new CN_Plan();
        double? totalIngresos = 0;
        double? totalGastos = 0;
        int? idUsuario;

        public UC_Dashboard(int? idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void CargarImporteTotal(char tipo)
        {
            try
            {
                Dinero registro = new Dinero();
                registro = CN_Dinero.TableroImportesTotales(idUsuario, tipo);


                if (tipo == 'I')
                {
                    if (registro?.ImporteDinero?.ToString().Length > 0)
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
                        lblCategoriasGastos.Text = "0";
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

                    if (dateTime.Year < 2000)
                    {
                        lblUltimaFecha.Text = "--/--/---";
                    }
                    else
                    {
                        lblUltimaFecha.Text = dateTime.ToShortDateString();
                    }


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


        private void CargarPlanesActivos()
        {
            try
            {
                lblPlanes.Text = CN_Plan.GetTotalPlanesPendientes(idUsuario).ToString();
            }
            catch
            {
                lblPlanes.Text = "0";
            }
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
                CargarPlanesActivos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No existen datos suficientes para mostrar. " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


    }
}
