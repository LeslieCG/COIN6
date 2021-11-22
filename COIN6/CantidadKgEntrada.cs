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
    public partial class CantidadKgEntrada : Form
    {
        public CantidadKgEntrada()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            CantidadCajasEntrada cce = new CantidadCajasEntrada();
            cce.Show();
            this.Hide();
        }

        private void BtnMayoreo_Click(object sender, EventArgs e)
        {

        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtKgE.Clear();
        }
    }
}
