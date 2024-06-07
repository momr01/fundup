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
    public partial class AgregarDineroPlan : Form
    {
        CN_Categoria CN_Categoria = new CN_Categoria();
        CN_Dinero CN_Dinero = new CN_Dinero();
        CN_Plan CN_Plan = new CN_Plan();

        int _idPlan;
        int? _idUsuario;
        double? _faltante;
        double? _reunido;

        public AgregarDineroPlan(int? idUsuario, int idPlan, double? faltante, double? reunido)
        {
            InitializeComponent();
            _idPlan = idPlan;
            _idUsuario = idUsuario;
            _faltante = faltante;
            _reunido = reunido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private bool FormularioValido()
        {
            if (txtDescripcion.Text.Length == 0 || txtImporte.Text.Length == 0)
            {

                return false;
            }

            try
            {
                Double importe = Convert.ToDouble(txtImporte.Text);

                if (importe <= 0) return false;
                else return true;

            }
            catch
            {
                return false;
            }

        }

        private bool LimiteSegunSaldo()
        {
            Double importe = Convert.ToDouble(txtImporte.Text);

            if (cbTipo.SelectedIndex == 0) //Ingreso
            {
                if (importe > _faltante)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (cbTipo.SelectedIndex == 1) //Gasto
            {
                if (importe > _reunido)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }

        }

        private void CargarComboCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            listaCategorias = CN_Categoria.GetCategorias(0, _idUsuario);
            cbCategoria.DataSource = listaCategorias;
        }

        private void LimpiarControles()
        {
            txtDescripcion.Clear();
            txtImporte.Clear();
            cbCategoria.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;
            dpFecha.Value = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!FormularioValido())
            {
                MessageBox.Show("Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!LimiteSegunSaldo())
            {
                MessageBox.Show("Por favor respete los límites al agregar un nuevo movimiento.", "Conflicto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Dinero nuevoMov = new Dinero();

                    nuevoMov.ImporteDinero = Convert.ToDouble(txtImporte.Text.Trim());
                    nuevoMov.DescripcionDinero = txtDescripcion.Text.Trim();
                    nuevoMov.FechaDinero = dpFecha.Value;
                    nuevoMov.EstaActivoDinero = true;

                    nuevoMov.Categoria = new Categoria();
                    nuevoMov.Categoria.IdCategoria = (int)cbCategoria.SelectedValue;

                    nuevoMov.Usuario = new Usuario();
                    nuevoMov.Usuario.idUsuario = Convert.ToInt32(_idUsuario);

                    DialogResult registrar = MessageBox.Show("¿Confirma registrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (registrar == DialogResult.No)
                    {
                        return;
                    }

                    // int idGastoCreado = CN_Dinero.InsertDinero(nuevoGasto, 'G');

                    if (cbTipo.SelectedIndex == 0) //Ingreso
                    {
                        //CN_Dinero.
                        CN_Plan.InsertDineroPlan(nuevoMov, 'I', _idPlan);
                    }
                    else //gasto
                    {
                        //CN_Dinero
                        CN_Plan.InsertDineroPlan(nuevoMov, 'G', _idPlan);
                    }
                    MessageBox.Show("Se registro el movimiento correctamente.", "Dinero registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    //MostrarGastos();
                    Dispose();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AgregarDineroPlan_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboCategorias();
                //MostrarDatosGasto();
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }
    }
}
