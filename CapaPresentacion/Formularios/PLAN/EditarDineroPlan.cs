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
    public partial class EditarDineroPlan : Form
    {
        CN_Categoria CN_Categoria = new CN_Categoria();
        CN_Dinero CN_Dinero = new CN_Dinero();

        int _idMov;
        int? _idUsuario;
        char _type;
        double? _faltante;
        double? _reunido;

        public EditarDineroPlan(int? idUsuario, int idMov, char type, double? faltante, double? reunido)
        {
            InitializeComponent();
            _idMov = idMov;
            _idUsuario = idUsuario;
            _type = type;
            _faltante = faltante;
            _reunido = reunido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void EditarDineroPlan_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboCategorias();
                MostrarDatosMovimiento();
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }

        private void CargarComboCategorias()
        {
            try
            {
                List<Categoria> listaCategorias = new List<Categoria>();
                listaCategorias = CN_Categoria.GetCategorias(0, _idUsuario);
                cbCategoria.DataSource = listaCategorias;
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }

        private void MostrarDatosMovimiento()
        {
            try
            {
                CN_Dinero movimiento = new CN_Dinero();

                var data = movimiento.GetDinero(_idUsuario, _idMov, _type);

                txtDescripcion.Text = data.Rows[0].Field<string>("DESCRIPCION");
                txtImporte.Text = data.Rows[0].Field<decimal>("IMPORTE").ToString();
                cbCategoria.SelectedValue = Convert.ToInt32(data.Rows[0].Field<int>("ID_CATEGORIA"));
                dpFecha.Value = data.Rows[0].Field<DateTime>("FECHA");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Intente nuevamente." + ex.Message + " " + _type + "-" + _idUsuario + "-" + _idMov);
            }

        }

        private bool LimiteSegunSaldo()
        {
            CN_Dinero movimiento = new CN_Dinero();

            var data = movimiento.GetDinero(_idUsuario, _idMov, _type);

            Double importe = Convert.ToDouble(txtImporte.Text);

            if (_type == 'I') //Ingreso
            {
                if (importe > (_faltante + double.Parse(data.Rows[0].Field<Decimal>("IMPORTE").ToString())))
                {
                    return false;
                }

                if (importe < (double.Parse(data.Rows[0].Field<Decimal>("IMPORTE").ToString()) - _reunido))
                {
                    return false;
                }

                return true;





            }
            else if (_type == 'G') //Gasto
            {
                if (importe > (_reunido + double.Parse(data.Rows[0].Field<Decimal>("IMPORTE").ToString())))
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

        private void btnEditar_Click(object sender, EventArgs e)
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
                    Dinero movModificado = new Dinero();

                    movModificado.IdDinero = _idMov;
                    movModificado.ImporteDinero = Convert.ToDouble(txtImporte.Text.Trim());
                    movModificado.DescripcionDinero = txtDescripcion.Text.Trim();
                    movModificado.FechaDinero = dpFecha.Value;

                    movModificado.Categoria = new Categoria();
                    movModificado.Categoria.IdCategoria = (int)cbCategoria.SelectedValue;

                    DialogResult editar = MessageBox.Show("¿Confirma edición?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (editar == DialogResult.No)
                    {
                        return;
                    }

                    bool exito = CN_Dinero.EditarDinero(_idUsuario, movModificado, _type);
                    MessageBox.Show("Se modificó el movimiento de dinero correctamente.", "Dinero editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
