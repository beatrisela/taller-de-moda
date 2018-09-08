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
    public partial class pedidos : Form
    {
        public pedidos()
        {
            InitializeComponent();
        }
        private void pedidos_Load(object sender, EventArgs e)
        {
            labelempleado.Text = "Usuario:  " + Program.usuario; 
            labelnombre.Text = Conexion.ObtenerNombre(Program.usuario);

            Conexion c = new Conexion();
            c.Llenar_provedor_productos(comboBoxproveedor);//conexion con el metodo y se le pasael combobox 
           
        }

        private void ButonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Buttonguardar_Click(object sender, EventArgs e)
        {
            if ((Conexion.Insertar_pedidos(textBoxprecio.Text,  textBoxproducto.Text, textBoxexistencias.Text, Conexion.Obtener_ID_PROVEEDOR(comboBoxproveedor.Text)))== true)
            {
                
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("pedido insertado correstamente", "Mensaje ventana Pedidos", botones, MessageBoxIcon.Information);
                
            }
            else 
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("Error,Introduzca Bien los datos", "Mensaje ventana Pedidos", botones, MessageBoxIcon.Error);

            }
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            if (buttonbuscar.Text != "")
            {
                DataTable dt = new DataTable();
                //  string consulta = "Select  " + comboBoxbuscar.Text + " from productos ;";
                string consulta = "Select p.*, pr.NOMBRE_EMPRESA from productos p inner join PROVEEDORES pr on p.cif = pr.CIF where pr.NOMBRE_EMPRESA = '" + comboBoxproveedor.Text + "';";
                
                dt = Conexion.Conectar(consulta);
                dataGridView1.DataSource = dt;
            }
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxprecio.Text = "";
            textBoxproducto.Text = "";
            textBoxexistencias.Text = "";
            comboBoxproveedor.Text = "";
            textBoxpedidos.Text = "";
            comboBoxbuscar.Text = "";
            dataGridView1.DataSource = "";
            panel2.Show();
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            if (textBoxpedidos.Text != "")
            {
                MessageBox.Show("Esta seguro de que quiere eliminar", "mensaje producto", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Conexion.Eliminar_TFNO_proveedor(textBoxpedidos.Text) == true)
                {
                    // MessageBox.Show("Se ha borrado correctamente los teléfonos del proveedor con CID: " + textBoxcid.Text);
                }
                else

                if (Conexion.Eliminar_producto(textBoxpedidos.Text) == true)
                {
                    MessageBox.Show("Se ha borrado correctamente el producto con el id : " + textBoxpedidos.Text + MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El producto con el id : " + textBoxpedidos.Text + " no se ha borrado porque no está en la base de datos" + MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe escribir un id para poder borrarlo.");
            }

        }

        private void comboBoxproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
