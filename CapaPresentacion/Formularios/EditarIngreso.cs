using CapaDatos;
using CapaNegocio;
using Entidades;
using Krypton.Toolkit;
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
    public partial class EditarIngreso : Form
    {
        CN_Categoria CN_Categoria = new CN_Categoria();
        CN_Dinero CN_Dinero = new CN_Dinero();

        int _idIngreso;
        int? _idUsuario;
        public EditarIngreso(int? idUsuario, int idIngreso)
        {
            InitializeComponent();
            _idIngreso = idIngreso;
            _idUsuario = idUsuario;
        }
        private void AgregarMovimiento_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboCategorias();
                MostrarDatosIngreso();
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
                listaCategorias = CN_Categoria.GetCategorias(0);
                cbCategoria.DataSource = listaCategorias;
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }

        private void MostrarDatosIngreso()
        {
            try
            {
                CN_Dinero ingresos = new CN_Dinero();
                var data = ingresos.GetDinero(_idUsuario, _idIngreso, 'I');
                txtDescripcion.Text = data.Rows[0].Field<string>("DESCRIPCION");
                txtImporte.Text = data.Rows[0].Field<decimal>("IMPORTE").ToString();
                cbCategoria.SelectedValue = Convert.ToInt32(data.Rows[0].Field<int>("ID_CATEGORIA"));
                dpFecha.Value = data.Rows[0].Field<DateTime>("FECHA");
            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }

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
                    Dinero ingresoModificado = new Dinero();

                    ingresoModificado.IdDinero = _idIngreso;
                    ingresoModificado.ImporteDinero = Convert.ToDouble(txtImporte.Text.Trim());
                    ingresoModificado.DescripcionDinero = txtDescripcion.Text.Trim();
                    ingresoModificado.FechaDinero = dpFecha.Value;

                    ingresoModificado.Categoria = new Categoria();
                    ingresoModificado.Categoria.IdCategoria = (int)cbCategoria.SelectedValue;

                    DialogResult editar = MessageBox.Show("¿Confirma edición?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (editar == DialogResult.No)
                    {
                        return;
                    }

                    bool exito = CN_Dinero.EditarDinero(_idUsuario, ingresoModificado, 'I');
                    MessageBox.Show("Se modificó el ingreso correctamente.", "Ingreso editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
