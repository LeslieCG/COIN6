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
    public partial class CantidadSalida : Form
    {
        public CantidadSalida()
        {
            InitializeComponent();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtCantidadS.Clear();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuProductosS mps = new MenuProductosS();
            mps.Show();
            this.Hide();
        }
    }
}
