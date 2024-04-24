using CapaDatos;
using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Helpers.ExpressiveSortInfo;

namespace CapaPresentacion.Formularios
{
    public partial class VerEditarPlan : Form
    {
        int _idPlan;
        Plan _plan;
        CN_Plan CN_Plan = new CN_Plan();
        CN_Dinero CN_Dinero = new CN_Dinero();
        Usuario _usuario = new Usuario();
        int idDinero = 0;
        char _type;
        double? _porcentaje;
        double? _faltante;
        double? _reunido;

        public VerEditarPlan(int idPlan, Usuario usuario)
        {
            InitializeComponent();
            _idPlan = idPlan;
            _usuario = usuario;
        }

        private void VerEditarPlan_Load(object sender, EventArgs e)
        {
            try
            {

                ConsultarPlan();
                MostrarDinero();
                AnularOrdenColumnas();
                EstiloFilasTotales();
                CargarDatos();
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }


        }

        private bool DineroSeleccionado()
        {
            if (tableDinero.SelectedRows.Count > 0)
            {
                try
                {
                    string id = tableDinero.CurrentRow?.Cells["ID"].Value.ToString()!;
                    if (id == null || int.Parse(id) < 1)
                        return false;

                    idDinero = Convert.ToInt32(id);

                    bool esIngreso = double.Parse(tableDinero.CurrentRow?.Cells["INGRESO"].Value.ToString()!) == 0 ? false : true;

                    if (esIngreso) _type = 'I';
                    else _type = 'G';

                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }

        private void AnularOrdenColumnas()
        {
            foreach (DataGridViewColumn column in tableDinero.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void MostrarDinero()
        {
            CN_Plan plan = new CN_Plan();
            tableDinero.DataSource = plan.GetPlanDinero(_usuario.idUsuario, _idPlan);
            tableDinero.Columns["ID"].Visible = false;
        }



        private void ConsultarPlan()
        {
            CN_Plan planes = new CN_Plan();
            _plan = planes.GetPlanes(_usuario.idUsuario, _idPlan)[0];
        }
        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private String FormatoFechaSinHora(DateTime? fecha)
        {
            return Convert.ToDateTime(fecha).Day.ToString() + "/" + Convert.ToDateTime(fecha).Month.ToString() + "/" + Convert.ToDateTime(fecha).Year.ToString();
        }


        private void CargarDatos()
        {
            lblNombre.Text = _plan.NombrePlan!.ToUpper();
            lblDescripcion.Text = _plan.DescripcionPlan;
            lblFechaInicio.Text = FormatoFechaSinHora(_plan.FechaInicioPlan);
            lblFechaFin.Text = FormatoFechaSinHora(_plan.FechaFinPlan);
            lblCapital.Text = "$ " + String.Format("{0:#,##0.00}", _plan.CapitalPlan);
            lblEstado.Text = EstadoPlan();
            lblDiasFaltantes.Text = _plan.EstaCompletoPlan == false ? "Faltan " + DiasPlan() + " días." : "-";
            lblPorcentaje.Text = String.Format("{0:0.00}", PorcentajeCapital()) + "%";
            lblDineroFaltante.Text = "$ " + String.Format("{0:#,##0.00}", DineroFaltante());
            lblDineroReunido.Text = "$ " + String.Format("{0:#,##0.00}", DineroReunido());

            if (_plan.EstaCompletoPlan! == true)
            {
                btnAgregarDinero.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                lblFechaCompleto.Visible = true;
                txtFechaCompleto.Visible = true;
                txtFechaCompleto.Text = FormatoFechaSinHora(_plan.FechaCompleto);
            }
            else
            {
                btnAgregarDinero.Visible = true;
                btnEditar.Visible = true;
                btnEliminar.Visible = true;
                pbInfo.Visible = true;
                lblFechaCompleto.Visible = false;
                txtFechaCompleto.Visible = false;
                txtFechaCompleto.Text = "";
            }
        }

        private String EstadoPlan()
        {
            if (_plan.EstaCompletoPlan! == true)
            {
                return "FINALIZADO";
            }
            else
            {
                return "PENDIENTE";
            }

        }

        private double DiasPlan()
        {
            DateTime fechaFinal = Convert.ToDateTime(_plan.FechaFinPlan);
            DateTime fechaHoy = DateTime.Now;

            var cantDias = (fechaFinal - fechaHoy).TotalDays;

            return Math.Round(cantDias);


        }

        private double? PorcentajeCapital()
        {
            double? valor = 0;

            foreach (DataGridViewRow row in tableDinero.Rows)
            {
                if (row.Cells[2].Value.ToString() == "TOTAL")
                {

                    if (double.Parse(row.Cells[3].Value.ToString()!) != 0.00)
                    {
                        valor = ((double.Parse(row.Cells[3].Value.ToString()!) * 100) / _plan.CapitalPlan);
                    }
                    else
                    {
                        valor = ((double.Parse(row.Cells[4].Value.ToString()!) * 100) / _plan.CapitalPlan);
                    }
                }

            }
            return valor;
        }

        private double? DineroFaltante()
        {
            double? importe = 0;

            foreach (DataGridViewRow row in tableDinero.Rows)
            {
                if (row.Cells[2].Value.ToString() == "TOTAL")
                {
                    double? valor = _plan.CapitalPlan - double.Parse(row.Cells[3].Value.ToString()!);
                    if (valor < 0.00)
                    {
                        importe = 0.00;
                    }
                    else
                    {
                        importe = valor;
                    }

                }
            }

            return importe;
        }


        private double? DineroReunido()
        {
            double? importe = 0;

            foreach (DataGridViewRow row in tableDinero.Rows)
            {
                if (row.Cells[2].Value.ToString() == "TOTAL")
                {
                    importe = double.Parse(row.Cells[3].Value.ToString());

                }
            }

            return importe;
        }

        private void EstiloFilasTotales()
        {
            foreach (DataGridViewRow row in tableDinero.Rows)
            {
                if (row.Cells[2].Value.ToString() == "SUBTOTALES" || row.Cells[2].Value.ToString() == "TOTAL")
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAgregarDinero_Click(object sender, EventArgs e)
        {
            using (AgregarDineroPlan ag = new AgregarDineroPlan(_usuario.idUsuario, _idPlan, DineroFaltante(), DineroReunido()))
            {
                ag.ShowDialog();
                this.OnLoad(e);
            }
            ComprobarEstado();
            CargarDatos();

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (DineroSeleccionado())
            {
                using (EditarDineroPlan ed = new EditarDineroPlan(_usuario.idUsuario, idDinero, _type, DineroFaltante(), DineroReunido()))
                {
                    ed.ShowDialog();
                    this.OnLoad(e);
                }
                ComprobarEstado();
                CargarDatos();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un movimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DineroSeleccionado())
            {
                try
                {
                    DialogResult anular = MessageBox.Show("¿Confirma que desea eliminar el movimiento?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (anular == DialogResult.No)
                    {
                        return;
                    }

                    CN_Dinero.AnularDinero(_usuario.idUsuario, idDinero, _type);
                    MessageBox.Show("Se eliminó el movimiento.", "Dinero eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarDinero();
                    CargarDatos();
                    EstiloFilasTotales();
                    ComprobarEstado();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un movimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void pbInfo_Click(object sender, EventArgs e)
        {
            if (_plan.EstaCompletoPlan! == true)
            {
                DateTime fechaInicio = Convert.ToDateTime(_plan.FechaInicioPlan);
                DateTime fechaObjetivo = Convert.ToDateTime(_plan.FechaFinPlan);
                DateTime fechaCompleto = Convert.ToDateTime(_plan.FechaCompleto);

                double diasEnCompletar = Math.Round((fechaCompleto - fechaInicio).TotalDays);
                double diferenciaConObjetivo = Math.Round((fechaObjetivo - fechaCompleto).TotalDays);

                using (VerPlanCompletoInfo pci = new VerPlanCompletoInfo(diasEnCompletar, diferenciaConObjetivo))
                {
                    pci.ShowDialog();
                    this.OnLoad(e);
                }


            }
            else
            {
                double? valorDiario = 0;

                valorDiario = DineroFaltante() / DiasPlan();

                using (VerPlanInfo pi = new VerPlanInfo(_plan.CapitalPlan, valorDiario))
                {
                    pi.ShowDialog();
                    this.OnLoad(e);
                }
            }


        }

        private void ComprobarEstado()
        {
            if (DineroFaltante() == 0)
            {
                try
                {
                    CN_Plan.FinalizarPlan(_usuario.idUsuario, _idPlan);
                    lblEstado.Text = "FINALIZADO";
                    lblDiasFaltantes.Text = "-";
                    btnAgregarDinero.Visible = false;
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                    using (MensajePlanFinalizado mpf = new MensajePlanFinalizado())
                    {
                        mpf.ShowDialog();
                    }
                    Dispose();
                }
                catch
                {
                    MessageBox.Show("Ocurrió un error al intentar actualizar el estado del Plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }


    }
}
