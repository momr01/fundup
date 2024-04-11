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
    public partial class UC_Categorias : UserControl
    {
        CN_Categoria CN_Categoria = new CN_Categoria();
        Usuario _usuario = new Usuario();
        int idCategoria = 0;



        public UC_Categorias(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool CategoriaSeleccionada()
        {
            if (tableCategorias.SelectedRows.Count > 0)
            {
                try
                {
                    string id = tableCategorias.CurrentRow?.Cells["ID"].Value.ToString();
                    if (id == null)
                        return false;

                    idCategoria = Convert.ToInt32(id);
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

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (CategoriaSeleccionada())
            {
                using (EditarCategoria ec = new EditarCategoria(_usuario.idUsuario, idCategoria))
                {
                    ec.ShowDialog();
                    this.OnLoad(e);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool FormularioValido()
        {
            if (txtDescripcion.Text.Length == 0 || txtNombre.Text.Length == 0)
            {

                return false;
            }
            else { return true; }

        }

        private void UC_Categorias_Load(object sender, EventArgs e)
        {
            try
            {
                MostrarCategorias();

            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }


        }

        private void LimpiarControles()
        {
            txtDescripcion.Clear();
            txtNombre.Clear();
        }

        private void MostrarCategorias()
        {
            CN_Categoria categorias = new CN_Categoria();
            tableCategorias.DataSource = categorias.GetTablaCategorias(_usuario.idUsuario);
            //tableCategorias.Columns["ID"].Visible = false;
            tableCategorias.Columns["ID"].Visible = false;
            tableCategorias.Columns["ACTIVA"].Visible = false;
            lblTotalCategorias.Text = tableCategorias.Rows.Count.ToString();

            if ((tableCategorias.Rows.Count) > 0)
            {
                txtBuscar.Enabled = true;
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            if (!FormularioValido())
            {
                MessageBox.Show("Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Categoria nuevaCat = new Categoria();

                    nuevaCat.NombreCategoria = txtNombre.Text.Trim();
                    nuevaCat.DescripcionCategoria = txtDescripcion.Text.Trim();
                    nuevaCat.EstaActivaCategoria = true;

                    nuevaCat.Usuario = new Usuario();
                    nuevaCat.Usuario.idUsuario = Convert.ToInt32(_usuario.idUsuario);


                    DialogResult registrar = MessageBox.Show("¿Confirma registrar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (registrar == DialogResult.No)
                    {
                        return;
                    }

                    int idCatCreada = CN_Categoria.InsertCategoria(nuevaCat);
                    MessageBox.Show("Se registró la categoría correctamente.", "Categoría registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    MostrarCategorias();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (CategoriaSeleccionada())
            {
                try
                {
                    DialogResult anular = MessageBox.Show("¿Confirma que desea eliminar la categoría?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (anular == DialogResult.No)
                    {
                        return;
                    }

                    bool anulacion = CN_Categoria.AnularCategoria(idCategoria, _usuario.idUsuario);
                    MessageBox.Show("Se eliminó la categoría.", "Categoría eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarCategorias();

                }
                catch
                {
                    MessageBox.Show("Ocurrió un error. Por favor inténtelo nuevamente más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void tableCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditarCategoria.Enabled = true;
            btnEliminarCategoria.Enabled = true;
        }

        private void Filtrar()
        {
            if (cbBuscar.Text == "NOMBRE")
            {
                (tableCategorias.DataSource as DataTable)!.DefaultView.RowFilter = TextoParaFiltrar("NOMBRE", txtBuscar.Text);
                lblTotalCategorias.Text = tableCategorias.Rows.Count.ToString();

            }
            else if (cbBuscar.Text == "DESCRIPCION")
            {
                (tableCategorias.DataSource as DataTable)!.DefaultView.RowFilter = TextoParaFiltrar("DESCRIPCION", txtBuscar.Text);
                lblTotalCategorias.Text = tableCategorias.Rows.Count.ToString();
            }
        }

        private string TextoParaFiltrar(string columna, string input)
        {
            return string.Format("[{0}] LIKE '*{1}*'", columna, input);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscar.Text.Length > 0 && cbBuscar.Text != "" && tableCategorias.DataSource != null)
            {
                Filtrar();
            }
            else
            {
                (tableCategorias.DataSource as DataTable).DefaultView.RowFilter = "";
                lblTotalCategorias.Text = tableCategorias.Rows.Count.ToString();
            }
        }
    }

}
