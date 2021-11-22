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
    public partial class CantidadCajasEntrada : Form
    {
        public CantidadCajasEntrada()
        {
            InitializeComponent();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtCajasE.Clear();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuProductosE mpe = new MenuProductosE();
            mpe.Show();
            this.Hide();
        }
    }
}
