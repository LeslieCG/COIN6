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
    public partial class InformeEntrada : Form
    {
        public InformeEntrada()
        {
            InitializeComponent();
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Hide();
        }

        private void BtnAgregarOtro_Click(object sender, EventArgs e)
        {
            MenuProductosE mpe = new MenuProductosE();
            mpe.Show();
            this.Hide();
        }
    }
}
