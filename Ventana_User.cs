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
    public partial class Ventana_User : Ventana_administrador // esta heredando 
    {
        public Ventana_User()
        {
            InitializeComponent();
        }

        private void Ventana_User_Load(object sender, EventArgs e) //ventana usuario
        {
            this.Hide();
           
        }

        private void salir_administrador_Click(object sender, EventArgs e)
        {

        }

       
    }
}
