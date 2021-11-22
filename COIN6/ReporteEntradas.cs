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
    public partial class ReporteEntradas : Form
    {
        public ReporteEntradas()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuReportes mr = new MenuReportes();
            mr.Show();
            this.Hide();
        }
    }
}
