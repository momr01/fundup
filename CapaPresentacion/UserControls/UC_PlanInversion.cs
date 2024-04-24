using CapaDatos;
using CapaNegocio;
using CapaPresentacion.Formularios;
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
    public partial class UC_PlanInversion : UserControl
    {
        CN_Plan CN_Plan = new CN_Plan();
        Usuario _usuario = new Usuario();
        int idPlan = 0;
        public UC_PlanInversion(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            dpFechaFin.Value = DateTime.Now.AddDays(30);
        }

        private bool PlanSeleccionado()
        {
            if (tablePlanesActivos.SelectedRows.Count > 0)
            {
                try
                {
                    string id = tablePlanesActivos.CurrentRow?.Cells["ID"].Value.ToString()!;
                    if (id == null)
                        return false;

                    idPlan = Convert.ToInt32(id);
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

        private bool PlanFinalizadoSeleccionado()
        {
            if (tablePlanesFinalizados.SelectedRows.Count > 0)
            {
                try
                {
                    string id = tablePlanesFinalizados.CurrentRow?.Cells["ID"].Value.ToString()!;
                    if (id == null)
                        return false;

                    idPlan = Convert.ToInt32(id);
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

        private void MostrarPlanes()
        {
            CN_Plan planes = new CN_Plan();
            tablePlanesActivos.DataSource = planes.GetTablaPlanes(_usuario.idUsuario);
            tablePlanesActivos.Columns["ID"].Visible = false;
            tablePlanesActivos.Columns["ESTADO"].Visible = false;
            tablePlanesActivos.Columns["FECHA COMPLETO"].Visible = false;
          //  tablePlanesActivos.DefaultCellStyle.SelectionBackColor = tablePlanesActivos.DefaultCellStyle.BackColor;
            //tablePlanesActivos.DefaultCellStyle.SelectionForeColor = tablePlanesActivos.DefaultCellStyle.ForeColor;
            tablePlanesActivos.ClearSelection();

            if (tablePlanesActivos.Rows.Count > 0)
            {
                btnVerPlan.Visible = true;
                btnEditarPlan.Visible = true;
                btnEliminarPlan.Visible = true;
            }
            else
            {
                btnVerPlan.Visible = false;
                btnEditarPlan.Visible = false;
                btnEliminarPlan.Visible = false;
            }
        }

        private void MostrarPlanesFinalizados()
        {
            CN_Plan planes = new CN_Plan();
            tablePlanesFinalizados.DataSource = planes.GetTablaPlanesFinalizados(_usuario.idUsuario);
            tablePlanesFinalizados.Columns["ID"].Visible = false;
            tablePlanesFinalizados.Columns["ESTADO"].Visible = false;
            tablePlanesFinalizados.ClearSelection();
         
            if (tablePlanesFinalizados.Rows.Count > 0)
            {
                btnVerCompletos.Visible = true;
                btnEliminarCompletos.Visible = true;
            }
            else
            {
                btnVerCompletos.Visible = false;
                btnEliminarCompletos.Visible = false;
            }
        }

        private void btnCargarPlanes_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarPlanes();

            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }

        private void btnVerPlan_Click(object sender, EventArgs e)
        {
            if (PlanSeleccionado())
            {
                using (VerEditarPlan ver = new VerEditarPlan(idPlan, _usuario))
                {
                    ver.ShowDialog();
                    this.OnLoad(e);
                }
                MostrarPlanes();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtCapital.Text = string.Empty;
            dpFechaInicio.Value = DateTime.Now;
            dpFechaFin.Value = DateTime.Now.AddDays(30);
        }

        private void btnEliminarPlan_Click(object sender, EventArgs e)
        {
            if (PlanSeleccionado())
            {
                try
                {
                    DialogResult anular = MessageBox.Show("¿Confirma que desea eliminar el plan de inversión?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (anular == DialogResult.No)
                    {
                        return;
                    }

                    bool anulacion = CN_Plan.AnularPlan(_usuario.idUsuario, idPlan);
                    if (anulacion)
                    {
                        MessageBox.Show("Se eliminó el plan de inversión.", "Plan eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MostrarPlanes();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }


        private bool FormularioValido()
        {
            if (txtNombre.Text.Length == 0 || txtDescripcion.Text.Length == 0 || txtCapital.Text.Length == 0)
            {

                return false;
            }

            var cantDias = (dpFechaFin.Value - dpFechaInicio.Value).TotalDays;
            if (cantDias <= 1)
            {
                return false;
            }


            try
            {
                Double importe = Convert.ToDouble(txtCapital.Text);

                if (importe <= 0) return false;
                else return true;

            }
            catch
            {
                return false;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!FormularioValido())
            {
                MessageBox.Show("Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Plan nuevoPlan = new Plan();

                    nuevoPlan.NombrePlan = txtNombre.Text;
                    nuevoPlan.DescripcionPlan = txtDescripcion.Text;
                    nuevoPlan.CapitalPlan = Convert.ToDouble(txtCapital.Text.Trim());
                    nuevoPlan.FechaInicioPlan = dpFechaInicio.Value;
                    nuevoPlan.FechaFinPlan = dpFechaFin.Value;
                    nuevoPlan.EstaActivoPlan = true;
                    nuevoPlan.FechaCompleto = Convert.ToDateTime("2999-12-31");

                    nuevoPlan.Usuario = new Usuario();
                    nuevoPlan.Usuario.idUsuario = Convert.ToInt32(_usuario.idUsuario);

                    DialogResult registrar = MessageBox.Show("¿Confirma registrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (registrar == DialogResult.No)
                    {
                        return;
                    }

                    int idPlanCreado = CN_Plan.InsertPlan(nuevoPlan);

                    if (idPlanCreado > 0)
                    {
                        MessageBox.Show("Se registro el movimiento correctamente.", "Dinero registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditarPlan_Click(object sender, EventArgs e)
        {
            if (PlanSeleccionado())
            {
                using (EditarPlan ep = new EditarPlan(_usuario.idUsuario, idPlan))
                {
                    ep.ShowDialog();
                    this.OnLoad(e);
                }
                MostrarPlanes();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCargarCompletos_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarPlanesFinalizados();

            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }

        private void btnVerCompletos_Click(object sender, EventArgs e)
        {
            if (PlanFinalizadoSeleccionado())
            {
                using (VerEditarPlan ver = new VerEditarPlan(idPlan, _usuario))
                {
                    ver.ShowDialog();
                    this.OnLoad(e);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnEliminarCompletos_Click(object sender, EventArgs e)
        {
            if (PlanFinalizadoSeleccionado())
            {
                try
                {
                    DialogResult anular = MessageBox.Show("¿Confirma que desea eliminar el plan de inversión?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (anular == DialogResult.No)
                    {
                        return;
                    }

                    bool anulacion = CN_Plan.AnularPlan(_usuario.idUsuario, idPlan);
                    if (anulacion)
                    {
                        MessageBox.Show("Se eliminó el plan de inversión.", "Plan eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MostrarPlanesFinalizados();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
