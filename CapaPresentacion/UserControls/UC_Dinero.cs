using CapaPresentacion.Formularios;
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
    public partial class UC_Dinero : UserControl
    {
        public UC_Dinero()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            using (EditarIngreso am = new EditarIngreso(1,1))
            {
                am.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
