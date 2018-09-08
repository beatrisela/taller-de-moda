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
    public partial class cuadrante : Form
    {
        public cuadrante()
        {
            InitializeComponent();
        }
        private void cuadrante_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            if (cbocampo.Text != "")//se usa para que el boton buscar no funcione cuando no tenga nada
            {
                DataTable dt = new DataTable();
                string consulta = "Select " + cbocampo.Text + " from turnos;"; //consulta que hacemos para el boton donde elegimos
                dt = Conexion.Conectar(consulta); //se le pone la variable consulta que tendra 
                dataGridView2.DataSource = dt;
            }
        }

        private void introducir_turno_Click(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
