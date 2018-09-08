using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER_DE_MODA;
using System.Diagnostics;


namespace TALLER_DE_MODA
{
    public partial class Tienda_clientes : Form
    {
        public Tienda_clientes()
        {
            InitializeComponent();
        }

        private void Tienda_clientes_Load(object sender, EventArgs e)
        {
            tiendaR.Hide();
            DataTable dt = new DataTable();
            string consulta = "Select * from cliente_tiendas;"; 
            dt = Conexion.Conectar(consulta); 
            dataGridView1.DataSource = dt;
        }
       
        private void Buttonvolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            tiendaR.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tiendaR.Hide();
        }
        private void Buttonregistrar_Click(object sender, EventArgs e)
        {
            if ((Conexion.Insertar_tienda(textBoxcid.Text, textBoxnombre.Text,  textBoxtelefono.Text, textBoxobservacion.Text)) == true)
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("El CLiente de la tienda se ha insertado correctamente", "Mensaje tienda", botones, MessageBoxIcon.Exclamation);
                DataTable dt = new DataTable();
                string consulta = "Select * from cliente_tiendas;";
                dt = Conexion.Conectar(consulta);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("Error, no se a podido Registrar", "Mensaje Tienda", botones, MessageBoxIcon.Error);
            }
        }
             
        private void Clear_registro_empleado_Click(object sender, EventArgs e)
        {
            textBoxcid.Text = "";
            textBoxnombre.Text = "";
            textBoxtelefono.Text = "";
            textBoxobservacion.Text = "";
            
            tiendaR.Show();
        }

        private void Btneliminar_Registro_tienda_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxcid.Text != "")
                {
                    int i = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    DataTable dt = new DataTable();
                    string consulta = "delete from factura_cliente where idfacturas = " + i + ";"; //consulta que hacemos para el boton donde elegimos
                    dt = Conexion.Conectar(consulta); //se le pone la variable consulta que tendra 
                    consulta = "delete from cliente_tiendas where idtienda = " + i + ";";
                    dt = Conexion.Conectar(consulta);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("usuario borrado");

                    dt = Conexion.Conectar("select * from cliente_tiendas");
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }







        /* Conexion sql = new Conexion();
         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
         {

             DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
             textBoxeliminarCliente.Text = Convert.ToString(fila.Cells[0].Value);
             textBoxcid.Text = Convert.ToString(fila.Cells[1].Value);
             textBoxnombre.Text= Convert.ToString(fila.Cells[2].Value);
             textBoxtelefono.Text= Convert.ToString(fila.Cells[3].Value);
             textBoxobservacion.Text=Convert.ToString(fila.Cells[4].Value);


         }*/
    }
}
