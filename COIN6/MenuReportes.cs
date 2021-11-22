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
    public partial class MenuReportes : Form
    {
        public MenuReportes()
        {
            InitializeComponent();
        }

        private void BtnGraficas_Click(object sender, EventArgs e)
        {
            Graficas gr = new Graficas();
            gr.Show();
            this.Hide();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            ReporteVentas rp = new ReporteVentas();
            rp.Show();
            this.Hide();
        }

        private void BtnInventario_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.Show();
            this.Hide();
        }

        private void BtnTicket_Click(object sender, EventArgs e)
        {
            Ticket t = new Ticket();
            t.Show();
            this.Hide();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Hide();
        }

        private void BtnEntradas_Click(object sender, EventArgs e)
        {
            ReporteEntradas re = new ReporteEntradas();
            re.Show();
            this.Hide();
        }
    }
}
