using CapaPresentacion.API.Controladores;
using CapaPresentacion.API.Modelos;
using CapaPresentacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Helpers.ExpressiveSortInfo;

namespace CapaPresentacion.UserControls
{
    public partial class UC_Finanzas : UserControl
    {
        private FinanzaController FinanzaController;
        private Finanzas _finanzas;
        private List<Finanza> lista;

        public UC_Finanzas()
        {
            InitializeComponent();
            FinanzaController = new FinanzaController();
            _finanzas = new Finanzas();
            lista = new List<Finanza>();
        }

        private async void GetFinanzas()
        {
            tableFinanzas.Rows.Clear();
            _finanzas = await FinanzaController.ObtenerFinanzas();
            txtBuscar.Text = string.Empty;

            if (_finanzas != null)
            {
                foreach (var finanza in _finanzas?.Results)
                {
                    Finanza nuevaFinanza = new Finanza();
                    nuevaFinanza.Id = finanza.Id;
                    nuevaFinanza.Name = finanza.Name;
                    nuevaFinanza.Description = finanza.Description;
                    nuevaFinanza.IsActive = finanza.IsActive;
                    nuevaFinanza.MinAmount = finanza.MinAmount;
                    nuevaFinanza.MaxAmount = finanza.MaxAmount;
                    nuevaFinanza.Url = finanza.Url;
                    nuevaFinanza.Country = finanza.Country;
                    nuevaFinanza.CurrencyDesc = finanza.CurrencyDesc;
                    nuevaFinanza.CurrencySymbol = finanza.CurrencySymbol;
                    nuevaFinanza.Market = finanza.Market;
                    nuevaFinanza.Types = finanza.Types;
                    nuevaFinanza.Costs = finanza.Costs;
                    nuevaFinanza.Profile = finanza.Profile;
                    nuevaFinanza.Risk = finanza.Risk;
                    nuevaFinanza.Profitability = finanza.Profitability;

                    lista.Add(nuevaFinanza);

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(tableFinanzas);

                    row.Cells[0].Value = finanza.Id;
                    row.Cells[1].Value = finanza.Name;
                    row.Cells[2].Value = finanza.Description;
                    row.Cells[3].Value = finanza.Profile;
                    row.Cells[4].Value = finanza.Risk;
                    row.Cells[5].Value = finanza.Profitability;

                    tableFinanzas.Columns[1].Width = 250;
                    tableFinanzas.Columns[3].Width = 150;
                    tableFinanzas.Columns[4].Width = 150;
                    tableFinanzas.Columns[5].Width = 150;

                    tableFinanzas.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    tableFinanzas.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    tableFinanzas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
                    tableFinanzas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    tableFinanzas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    tableFinanzas.Rows.Add(row);

                    lblTotal.Text = lista.Count.ToString();
                }

                btnMasInfo.Visible = true;

                if ((tableFinanzas.Rows.Count) > 0)
                {
                    txtBuscar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No se pudo obtener la petición.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMasInfo.Visible = false;
            }
        }



        private void btnGet_Click(object sender, EventArgs e)
        {
            lista.Clear();
            GetFinanzas();
        }

        private bool OpcionSeleccionada()
        {
            if (tableFinanzas.SelectedRows.Count > 0)
            {
                return true;

            }
            else
            {
                return false;
            }

        }

        private void btnMasInfo_Click(object sender, EventArgs e)
        {
            if (OpcionSeleccionada())
            {
                string name = tableFinanzas.CurrentRow?.Cells[1].Value.ToString();

                Finanza finanzaSeleccionada = lista.Where(x => x.Name == name).First();

                using (OpcionFinancieraDetalle ofd = new OpcionFinancieraDetalle(finanzaSeleccionada))
                {
                    ofd.ShowDialog();
                    this.OnLoad(e);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            switch (cbBuscar.Text)
            {
                case "NOMBRE":
                    BuscarPor(1);
                    break;
                case "PERFIL":
                    BuscarPor(3);
                    break;
                case "RIESGO":
                    BuscarPor(4);
                    break;
                case "RENTABILIDAD":
                    BuscarPor(5);
                    break;
            }


        }


        private void BuscarPor(int numColumna)
        {
            tableFinanzas.ClearSelection();

            int totalItems = 0;

            for (int u = 0; u < tableFinanzas.RowCount; u++)
            {

                if (tableFinanzas.Rows[u].Cells[numColumna].Value.ToString().ToLower().Contains(txtBuscar.Text.ToLower()))
                {
                    tableFinanzas.Rows[u].Visible = true;
                    totalItems++;
                }
                else
                {
                    tableFinanzas.Rows[u].Visible = false;
                }


            }

            lblTotal.Text = totalItems.ToString();

        }

        private void cbBuscar_SelectedValueChanged(object sender, EventArgs e)
        {
            txtBuscar.Text = string.Empty;
        }

        private void tableFinanzas_SelectionChanged(object sender, EventArgs e)
        {
            if (OpcionSeleccionada())
            {
                btnMasInfo.Visible = true;
            }
            else
            {
                btnMasInfo.Visible = false;
            }
        }
    }
}
