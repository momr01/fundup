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
    public partial class EditarGasto : Form
    {
        CN_Categoria CN_Categoria = new CN_Categoria();
        CN_Dinero CN_Dinero = new CN_Dinero();

        int _idGasto;
        int? _idUsuario;
        public EditarGasto(int? idUsuario, int idGasto)
        {
            InitializeComponent();
            _idGasto = idGasto;
            _idUsuario = idUsuario;
        }

        private void EditarGasto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboCategorias();
                MostrarDatosGasto();
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

        private void MostrarDatosGasto()
        {
            try
            {
                CN_Dinero gastos = new CN_Dinero();
                var data = gastos.GetDinero(_idUsuario, _idGasto, 'G');
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
                    Dinero gastoModificado = new Dinero();

                    gastoModificado.IdDinero = _idGasto;
                    gastoModificado.ImporteDinero = Convert.ToDouble(txtImporte.Text.Trim());
                    gastoModificado.DescripcionDinero = txtDescripcion.Text.Trim();
                    gastoModificado.FechaDinero = dpFecha.Value;

                    gastoModificado.Categoria = new Categoria();
                    gastoModificado.Categoria.IdCategoria = (int)cbCategoria.SelectedValue;

                    DialogResult editar = MessageBox.Show("¿Confirma edición?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (editar == DialogResult.No)
                    {
                        return;
                    }

                    bool exito = CN_Dinero.EditarDinero(_idUsuario, gastoModificado, 'G');
                    MessageBox.Show("Se modificó el gasto correctamente.", "Gasto editado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
