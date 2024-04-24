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
    public partial class UC_Gastos : UserControl
    {
        CN_Categoria CN_Categoria = new CN_Categoria();
        CN_Dinero CN_Dinero = new CN_Dinero();
        Usuario _usuario = new Usuario();
        int idGasto = 0;

        public UC_Gastos(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private bool GastoSeleccionado()
        {
            if (tableGastos.SelectedRows.Count > 0)
            {
                try
                {
                    string id = tableGastos.CurrentRow?.Cells["ID"].Value.ToString();
                    if (id == null)
                        return false;

                    idGasto = Convert.ToInt32(id);
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

        private void btnEditarGasto_Click(object sender, EventArgs e)
        {
            if (GastoSeleccionado())
            {
                using (EditarGasto eg = new EditarGasto(_usuario.idUsuario, idGasto))
                {
                    eg.ShowDialog();
                    this.OnLoad(e);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un gasto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool FormularioValido()
        {
            if (txtDescripcion.Text.Length == 0 || txtImporte.Text.Length == 0 || cbCategoria.SelectedValue == null)
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

        private void CargarComboCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            listaCategorias = CN_Categoria.GetCategorias(0, _usuario.idUsuario);
            cbCategoria.DataSource = listaCategorias;
        }

        private void UC_Gastos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboCategorias();
                MostrarGastos();
                dpFecha.Value = DateTime.Now;

            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }

        private void LimpiarControles()
        {
            txtDescripcion.Clear();
            txtImporte.Clear();
            cbCategoria.SelectedIndex = 0;
            dpFecha.Value = DateTime.Now;
        }

        private void MostrarGastos()
        {
            CN_Dinero gastos = new CN_Dinero();
            tableGastos.DataSource = gastos.GetDinero(_usuario.idUsuario, null, 'G');
            tableGastos.Columns["ID"].Visible = false;
            tableGastos.Columns["ID_CATEGORIA"].Visible = false;
            tableGastos.ClearSelection();
            lblTotalGastos.Text = tableGastos.Rows.Count.ToString();

            if ((tableGastos.Rows.Count) > 0)
            {
                txtBuscar.Enabled = true;
            }
        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            if (!FormularioValido())
            {
                MessageBox.Show("Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Dinero nuevoGasto = new Dinero();

                    nuevoGasto.ImporteDinero = Convert.ToDouble(txtImporte.Text.Trim());
                    nuevoGasto.DescripcionDinero = txtDescripcion.Text.Trim();
                    nuevoGasto.FechaDinero = dpFecha.Value;
                    nuevoGasto.EstaActivoDinero = true;

                    nuevoGasto.Categoria = new Categoria();
                    nuevoGasto.Categoria.IdCategoria = (int)cbCategoria.SelectedValue;

                    nuevoGasto.Usuario = new Usuario();
                    nuevoGasto.Usuario.idUsuario = Convert.ToInt32(_usuario.idUsuario);



                    DialogResult registrar = MessageBox.Show("¿Confirma registrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (registrar == DialogResult.No)
                    {
                        return;
                    }

                    int idGastoCreado = CN_Dinero.InsertDinero(nuevoGasto, 'G');
                    MessageBox.Show("Se registro el gasto correctamente.", "Gasto registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    MostrarGastos();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarGasto_Click(object sender, EventArgs e)
        {
            if (GastoSeleccionado())
            {
                try
                {
                    DialogResult anular = MessageBox.Show("¿Confirma que desea eliminar el gasto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (anular == DialogResult.No)
                    {
                        return;
                    }

                    bool anulacion = CN_Dinero.AnularDinero(_usuario.idUsuario, idGasto, 'G');
                    MessageBox.Show("Se eliminó el gasto.", "Gasto eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarGastos();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un gasto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void tableGastos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarGasto.Enabled = true;
            btnEliminarGasto.Enabled = true;
        }

        private void Filtrar()
        {
            if (cbBuscar.Text == "CATEGORIA")
            {
                (tableGastos.DataSource as DataTable)!.DefaultView.RowFilter = TextoParaFiltrar("CATEGORIA", txtBuscar.Text);
                lblTotalGastos.Text = tableGastos.Rows.Count.ToString();

            }
            else if (cbBuscar.Text == "DESCRIPCION")
            {
                (tableGastos.DataSource as DataTable)!.DefaultView.RowFilter = TextoParaFiltrar("DESCRIPCION", txtBuscar.Text);
                lblTotalGastos.Text = tableGastos.Rows.Count.ToString();
            }
        }

        private string TextoParaFiltrar(string columna, string input)
        {
            return string.Format("[{0}] LIKE '*{1}*'", columna, input);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0 && cbBuscar.Text != "" && tableGastos.DataSource != null)
            {
                Filtrar();
            }
            else
            {
                (tableGastos.DataSource as DataTable).DefaultView.RowFilter = "";
                lblTotalGastos.Text = tableGastos.Rows.Count.ToString();
            }
        }
    }
}
