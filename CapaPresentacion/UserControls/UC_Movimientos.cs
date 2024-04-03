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

namespace CapaPresentacion.UserControls
{
    public partial class UC_Movimientos : UserControl
    {
        Usuario _usuario = new Usuario();
        CN_Dinero CN_Dinero = new CN_Dinero();
        public UC_Movimientos(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void MostrarMovimientos()
        {
            CN_Dinero mov = new CN_Dinero();
            tableMovimientos.DataSource = mov.GetDineroTotal(_usuario.idUsuario);
            //  tableDinero.Columns["ID"].Visible = false;
            // tableDinero.Columns["ID_CATEGORIA"].Visible = false;
            //  lblTotalIngresos.Text = tableIngresos.Rows.Count.ToString();
            //if(tableDinero.CurrentRow?.Cells["DESCRIPCION"].Value.ToString())


            AnularOrdenColumnas();
            EstiloFilasTotales();

            lblTotal.Text = (tableMovimientos.Rows.Count - 2).ToString();

            /*  if (tableDinero.Rows.Count > 2)
              {
                  btnReporte.Visible = true;
              }

              */

            if((tableMovimientos.Rows.Count - 2) > 0)
            {
                txtBuscar.Enabled = true;
            }

        }

        private void EstiloFilasTotales()
        {
            foreach (DataGridViewRow row in tableMovimientos.Rows)
            {
                if (row.Cells[1].Value.ToString() == "SUBTOTALES" || row.Cells[1].Value.ToString() == "TOTAL")
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

        private void AnularOrdenColumnas()
        {
            foreach (DataGridViewColumn column in tableMovimientos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btnListarMovimientos_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarMovimientos();

            }
            catch
            {
                MessageBox.Show("Error! Intente nuevamente.");
            }
        }

        private void Filtrar()
        {
            if (cbBuscar.Text == "DESCRIPCION")
            {
                (tableMovimientos.DataSource as DataTable)!.DefaultView.RowFilter = TextoParaFiltrar("DESCRIPCION", txtBuscar.Text);
                lblTotal.Text = tableMovimientos.Rows.Count.ToString();

            }
        }

        private string TextoParaFiltrar(string columna, string input)
        {
            return string.Format("[{0}] LIKE '*{1}*'", columna, input);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (txtBuscar.Text.Length > 0 && cbBuscar.Text != "" && tableMovimientos.DataSource != null)
            {
                Filtrar();
            }
            else
            {
                (tableMovimientos.DataSource as DataTable).DefaultView.RowFilter = "";
                lblTotal.Text = (tableMovimientos.Rows.Count - 2).ToString();
                AnularOrdenColumnas();
                EstiloFilasTotales();
            }


        }
    }
}
