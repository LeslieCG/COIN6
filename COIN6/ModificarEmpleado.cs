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
    public partial class ModificarEmpleado : Form
    {
        public ModificarEmpleado()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuEmpleados me = new MenuEmpleados();
            me.Show();
            this.Hide();
        }
    }
}
