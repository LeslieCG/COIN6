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
    public partial class MenuEmpleados : Form
    {
        public MenuEmpleados()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado re = new RegistrarEmpleado();
            re.Show();
            this.Hide();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ModificarEmpleado moe = new ModificarEmpleado();
            moe.Show();
            this.Hide();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado ee = new EliminarEmpleado();
            ee.Show();
            this.Hide();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarEmpleado ce = new ConsultarEmpleado();
            ce.Show();
            this.Hide();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Hide();
        }
    }
}
