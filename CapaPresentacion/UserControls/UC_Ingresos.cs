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
    public partial class UC_Ingresos : UserControl
    {
        CN_Categoria CN_Categoria = new CN_Categoria();
        CN_Dinero CN_Dinero = new CN_Dinero();
        Usuario _usuario = new Usuario();
        int idIngreso = 0;



        public UC_Ingresos(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool IngresoSeleccionado()
        {
            if (tableIngresos.SelectedRows.Count > 0)
            {
                try
                {
                    string id = tableIngresos.CurrentRow?.Cells["ID"].Value.ToString();
                    if (id == null)
                        return false;

                    idIngreso = Convert.ToInt32(id);
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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (IngresoSeleccionado())
            {
                using (EditarIngreso ei = new EditarIngreso(_usuario.idUsuario, idIngreso))
                {
                    ei.ShowDialog();
                    this.OnLoad(e);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un ingreso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void UC_Ingresos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarComboCategorias();
                MostrarIngresos();
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

        private void MostrarIngresos()
        {
            CN_Dinero ingresos = new CN_Dinero();
            tableIngresos.DataSource = ingresos.GetDinero(_usuario.idUsuario, null, 'I');
            tableIngresos.Columns["ID"].Visible = false;
            tableIngresos.Columns["ID_CATEGORIA"].Visible = false;
            lblTotalIngresos.Text = tableIngresos.Rows.Count.ToString();

            if ((tableIngresos.Rows.Count) > 0)
            {
                txtBuscar.Enabled = true;
            }
        }

        private void btnAgregarIngreso_Click(object sender, EventArgs e)
        {
            if (!FormularioValido())
            {
                MessageBox.Show("Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Dinero nuevoIngreso = new Dinero();

                    nuevoIngreso.ImporteDinero = Convert.ToDouble(txtImporte.Text.Trim());
                    nuevoIngreso.DescripcionDinero = txtDescripcion.Text.Trim();
                    nuevoIngreso.FechaDinero = dpFecha.Value;
                    nuevoIngreso.EstaActivoDinero = true;

                    nuevoIngreso.Categoria = new Categoria();
                    nuevoIngreso.Categoria.IdCategoria = (int)cbCategoria.SelectedValue;

                    nuevoIngreso.Usuario = new Usuario();
                    nuevoIngreso.Usuario.idUsuario = Convert.ToInt32(_usuario.idUsuario);



                    DialogResult registrar = MessageBox.Show("¿Confirma registrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (registrar == DialogResult.No)
                    {
                        return;
                    }

                    int idIngresoCreado = CN_Dinero.InsertDinero(nuevoIngreso, 'I');
                    MessageBox.Show("Se registro el ingreso correctamente.", "Ingreso registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    MostrarIngresos();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarIngreso_Click(object sender, EventArgs e)
        {
            if (IngresoSeleccionado())
            {
                try
                {
                    DialogResult anular = MessageBox.Show("¿Confirma que desea eliminar el ingreso?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (anular == DialogResult.No)
                    {
                        return;
                    }

                    bool anulacion = CN_Dinero.AnularDinero(_usuario.idUsuario, idIngreso, 'I');
                    MessageBox.Show("Se eliminó el ingreso.", "Ingreso eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarIngresos();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un ingreso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void tableIngresos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarIngreso.Enabled = true;
            btnEliminarIngreso.Enabled = true;
        }

        private void Filtrar()
        {
            if (cbBuscar.Text == "CATEGORIA")
            {
                (tableIngresos.DataSource as DataTable)!.DefaultView.RowFilter = TextoParaFiltrar("CATEGORIA", txtBuscar.Text);
                lblTotalIngresos.Text = tableIngresos.Rows.Count.ToString();

            }
            else if (cbBuscar.Text == "DESCRIPCION")
            {
                (tableIngresos.DataSource as DataTable)!.DefaultView.RowFilter = TextoParaFiltrar("DESCRIPCION", txtBuscar.Text);
                lblTotalIngresos.Text = tableIngresos.Rows.Count.ToString();
            }
        }

        private string TextoParaFiltrar(string columna, string input)
        {
            return string.Format("[{0}] LIKE '*{1}*'", columna, input);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscar.Text.Length > 0 && cbBuscar.Text != "" && tableIngresos.DataSource != null)
            {
                Filtrar();
            }
            else
            {
                (tableIngresos.DataSource as DataTable).DefaultView.RowFilter = "";
                lblTotalIngresos.Text = tableIngresos.Rows.Count.ToString();
            }
        }
    }
}
