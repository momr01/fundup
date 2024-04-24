using CapaNegocio;
using CapaPresentacion.Formularios;
using CapaPresentacion.UserControls;
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

namespace CapaPresentacion
{
    public partial class DashboardForm : Form
    {
        int panelWidth;
        bool Hidden;
        Usuario usuario;
        CN_Plan CN_Plan = new CN_Plan();

        public DashboardForm(Usuario _usuario)
        {
            InitializeComponent();
            timerTime.Start();
            panelWidth = panelLeft.Width;
            Hidden = false;
            usuario = _usuario;
            lblEmail.Text = usuario!.emailUsuario!.ToString();
            lblUsuario.Text = PrimeraLetraMayuscula(usuario!.nombreUsuario!) + " " + PrimeraLetraMayuscula(usuario!.apellidoUsuario!);

        }

        private int GetTotalPlanesPendientes()
        {
            int total = 0;
            try
            {
                total = CN_Plan.GetTotalPlanesPendientes(usuario.idUsuario);
            } catch
            {
                total = 0;
            }

            return total;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

            /*if(GetTotalPlanesPendientes()>0)
            {
                using (AlertaToast at = new AlertaToast(GetTotalPlanesPendientes()))
                {
                    at.ShowDialog();
                }
            }*/
           
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("The form will now be closed.", "Time Elapsed");
        }


        private string PrimeraLetraMayuscula(string palabra)
        {
            return palabra.First().ToString().ToUpper() + palabra.Substring(1).ToLower();
        }

        private void addControls(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void cerrarTodosPanelSide()
        {
            panelSideTablero.Visible = false;
            panelSideIngresos.Visible = false;
            panelSideGastos.Visible = false;
            panelSideGraficos.Visible = false;
            panelSideCategorias.Visible = false;
            panelSideMovimientos.Visible = false;
            panelSidePlanes.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void slidePanel(Panel panel, Button btn)
        {
            panel.Height = btn.Height;
            panel.Top = btn.Top;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Tablero";
            cerrarTodosPanelSide();
            panelSideTablero.Visible = true;
            UC_Dashboard dashboard = new UC_Dashboard(usuario.idUsuario);
            addControls(dashboard);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            if (Hidden)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 55)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void btnGraficos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gráficos";
            cerrarTodosPanelSide();
            panelSideGraficos.Visible = true;
            UC_Graficos graficos = new UC_Graficos(usuario);
            addControls(graficos);
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ingresos";
            cerrarTodosPanelSide();
            panelSideIngresos.Visible = true;
            UC_Ingresos ingresos = new UC_Ingresos(usuario);
            addControls(ingresos);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblHora.Text = dt.ToString();
          
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.No)
            {
                return;
            }
            MessageBox.Show("Sesión finalizada. Vuelva pronto!", "Sesión Finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dispose();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gastos";
            cerrarTodosPanelSide();
            panelSideGastos.Visible = true;
            UC_Gastos gastos = new UC_Gastos(usuario);
            addControls(gastos);

        }



        private void btnCategorias_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Categorías";
            cerrarTodosPanelSide();
            panelSideCategorias.Visible = true;
            UC_Categorias categorias = new UC_Categorias(usuario);
            addControls(categorias);
        }





        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Listado de Movimientos";
            cerrarTodosPanelSide();
            panelSideMovimientos.Visible = true;
            UC_Movimientos movimientos = new UC_Movimientos(usuario);
            addControls(movimientos);
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Planes de Inversión";
            cerrarTodosPanelSide();
            panelSidePlanes.Visible = true;
            UC_PlanInversion planes = new UC_PlanInversion(usuario);
            addControls(planes);
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
           // AlertaToast alerta = new AlertaToast(GetTotalPlanesPendientes());
           // alerta.Show();
        }
    }
}
