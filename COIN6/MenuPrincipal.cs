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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            IniEntradas ie = new IniEntradas();
            ie.Show();
            this.Hide();
        }

        private void BtnRetirar_Click(object sender, EventArgs e)
        {
            IniSalidas ins = new IniSalidas();
            ins.Show();
            this.Hide();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            IniReportes inr = new IniReportes();
            inr.Show();
            this.Hide();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            IniRegistro ir = new IniRegistro();
            ir.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
