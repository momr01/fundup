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

namespace CapaPresentacion.Formularios
{
    //  CN_Categoria CN_Categoria = new CN_Categoria();


    /* public EditarCategoria(int? idUsuario, int idCategoria)
     {
         InitializeComponent();
         _idCategoria = idCategoria;
         _idUsuario = idUsuario;
     }*/
    public partial class EditarPlan : Form
    {
        int _idPlan;
        int? _idUsuario;
        CN_Plan CN_Plan = new CN_Plan();
        public EditarPlan(int? idUsuario, int idPlan)
        {
            InitializeComponent();
            _idPlan = idPlan;
            _idUsuario = idUsuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void MostrarDatosPlan()
        {
            try
            {
                var data = CN_Plan.GetPlanes(_idUsuario, _idPlan);


                txtNombre.Text = data[0].NombrePlan;
                txtDescripcion.Text = data[0].DescripcionPlan;
                txtCapital.Text = data[0].CapitalPlan.ToString();
                dpFechaInicio.Value = data[0].FechaInicioPlan!.Value;
                dpFechaFin.Value = data[0].FechaFinPlan!.Value;

            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }

        }

        private void EditarPlan_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarDatosPlan();
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!FormularioValido())
            {
                MessageBox.Show("Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Plan planModificado = new Plan();

                    planModificado.IdPlan = _idPlan;
                    planModificado.NombrePlan = txtNombre.Text;
                    planModificado.DescripcionPlan = txtDescripcion.Text;
                    planModificado.CapitalPlan = Convert.ToDouble(txtCapital.Text.Trim());
                    planModificado.FechaInicioPlan = dpFechaInicio.Value;
                    planModificado.FechaFinPlan = dpFechaFin.Value;

                    DialogResult editar = MessageBox.Show("¿Confirma edición?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (editar == DialogResult.No)
                    {
                        return;
                    }

                    //int idPlanCreado = CN_Plan.InsertPlan(nuevoPlan);

                    // if (idPlanCreado > 0)
                    //  {
                    CN_Plan.EditarPlan(_idUsuario, planModificado);
                        MessageBox.Show("Se modificó el plan correctamente.", "Plan editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       Dispose();
                 //   }
                 //   else
                 //   {
                //        MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }

                    /*
                     * 
                     * 
                     * */
                    /*
                     * 
                     *   DialogResult editar = MessageBox.Show("¿Confirma edición?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (editar == DialogResult.No)
                    {
                        return;
                    }

                   // bool exito = CN_Dinero.EditarDinero(_idUsuario, gastoModificado, 'G');
                    CN_Categoria.EditarCategoria(catModificada);
                    MessageBox.Show("Se modificó la categoría correctamente.", "Categoría editada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    */

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
