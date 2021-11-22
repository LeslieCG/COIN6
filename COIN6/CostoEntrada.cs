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
    public partial class CostoEntrada : Form
    {
        public CostoEntrada()
        {
            InitializeComponent();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtCostoE.Clear();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            CantidadKgEntrada cke = new CantidadKgEntrada();
            cke.Show();
            this.Hide();
        }
    }
}
