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
    public partial class Graficas : Form
    {
        public Graficas()
        {
            InitializeComponent();
        }

        private void PanelGrafica_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuReportes mr = new MenuReportes();
            mr.Show();
            this.Hide();
        }
    }
}
