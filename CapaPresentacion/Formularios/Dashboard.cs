using CapaNegocio;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void slidePanel(Button btn)
        {
            panelSide.Height = btn.Height;
            panelSide.Top = btn.Top;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Tablero";
            slidePanel(btnTablero);
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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Gráficos";
            slidePanel(btnReportes);
            UC_Graficos graficos = new UC_Graficos(usuario);
            addControls(graficos);
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "Ingresos";
            slidePanel(btnIngresos);
            UC_Ingresos ingresos = new UC_Ingresos(usuario);
            addControls(ingresos);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //lblHora.Text = dt.ToString("HH:MM:ss");
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
            slidePanel(btnGastos);
            UC_Gastos gastos = new UC_Gastos(usuario);
            addControls(gastos);

        }
    }
}
