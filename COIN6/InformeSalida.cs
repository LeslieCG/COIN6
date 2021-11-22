using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COIN6
{
    public partial class InformeSalida : Form
    {
        public InformeSalida()
        {
            InitializeComponent();
        }

        private void BtnRetirarOtro_Click(object sender, EventArgs e)
        {
            MenuProductosS mps = new MenuProductosS();
            mps.Show();
            this.Hide();
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Hide();
        }
    }
}
