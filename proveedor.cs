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

namespace TALLER_DE_MODA
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
           c.Llenarpais(comboBoxpais);//conexion con el metodo y se le pasa el combobox 
           c.Llenarprovincias(comboBoxprovincia);

            panelproveedor.Hide();
            DataTable dt = new DataTable();
            string consulta = "Select p.CIF,nombre_empresa,EMAIL,TELEFONO1,TELEFONO2 from proveedores as p join telefono_proveedores as t on p.CIF = t.CIF;";
            dt = Conexion.Conectar(consulta);
            dataGridView1.DataSource = dt;
        }
        private void Boton_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
       

        private void Buttonlimpiar_Click(object sender, EventArgs e)
        {
            textBoxcid.Text = "";
            textBoxnombre.Text = "";
            textBoxemail.Text = "";
            textBoxtelefono1.Text = "";
            textBoxtelefono2.Text = "";
            dataGridView1.DataSource = ("");
            panelproveedor.Show();
        }

        private void Boton_Registrar_Click(object sender, EventArgs e)
        {
            //LLAMAMOS AL METODO INSERTAR_PROVEEDOR Y LE PASAMOS LOS PARAMETROS QUE SON LOS TEXBOX Y SI ES IGUAL A TRUE
            if ((Conexion.Insertar_proveedores(textBoxcid.Text, textBoxnombre.Text, textBoxemail.Text)) == true)
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("El proveedor se ha insertado correctamente", "Mensaje Proveedor", botones, MessageBoxIcon.Exclamation);

                // CONESTAMOS CON EL METODO INSERTAR_TFN_PROVEEDOR  Y LE PASAMOS LOS PARAMETROS Y LA CONEXION DE OBTENER_IDPROVEEDOR
                Conexion.Insertar_TFNO_proveedores(Conexion.Obtener_IDProveedor(), textBoxtelefono1.Text, textBoxtelefono2.Text);
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("Error, el Proveedor no se a podido insertar ", "Mensaje Proveedor", botones, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (textBoxcid.Text != "")
            {
                MessageBox.Show("Esta seguro de que quiere eliminar","ventana provedor", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (Conexion.Eliminar_TFNO_proveedor(textBoxcid.Text) == true)

                { }
                if (Conexion.Eliminar_proveedor(textBoxcid.Text) == true)
                {
                    MessageBox.Show("Se ha borrado correctamente el proveedor con CIF:   " + textBoxcid.Text + " y sus telefonos " + MessageBoxIcon.Exclamation);
                    DataTable dt = new DataTable();
                    string consulta = "Select p.CIF,nombre_empresa,EMAIL,TELEFONO1,TELEFONO2 from proveedores as p join telefono_proveedores as t on p.CIF = t.CIF;";
                    dt = Conexion.Conectar(consulta);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("El proveedor con CIF: " + textBoxcid.Text + " no se ha borrado porque no está en la base de datos." + MessageBoxIcon.Exclamation);
                }

            }
            else
                MessageBox.Show("Debe escribir un CIF para poder borrarlo.");
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            panelproveedor.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelproveedor.Show();
        }
    }
}
