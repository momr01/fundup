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
    public partial class AlertaToast : Form
    {
        int toastX, toastY;
        int _total;
        public AlertaToast(int total)
        {
            InitializeComponent();
            _total = total;

            if (_total == 1)
            {
                lblTotal.Text = "1 plan";
            }
            else
            {
                lblTotal.Text = _total.ToString() + " planes";
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width;
            toastY = ScreenHeight - this.Height;

            this.Location = new Point(toastX, toastY);
        }

        private void AlertaToast_Load(object sender, EventArgs e)
        {
            Position();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
