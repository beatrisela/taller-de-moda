using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TALLER_DE_MODA
{
    public partial class Cliente_facturas : Form
    {
        public Cliente_facturas()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            impirmirFactura i = new impirmirFactura();
            i.Show();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
