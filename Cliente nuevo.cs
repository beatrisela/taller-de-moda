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
    public partial class Cliente_nuevo : Form
    {
        public Cliente_nuevo()
        {
            InitializeComponent();
        }

        private void Cliente_nuevo_Load(object sender, EventArgs e)
        {

        }
        private void Buttonsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Boton_Registrar_Click(object sender, EventArgs e)
        {
           
                if ((Conexion.Insertar_clientes(textBoxdni.Text, textBoxnombre.Text, textBoxapellido1.Text, textBoxapellido2.Text, textBoxdireccion.Text, textEMAIL.Text, textobservasiones.Text)) == true)
                {
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show("El Cliente ha  sido insertado correctamente", "Mensaje Cliente", botones, MessageBoxIcon.Information);

                    // CONESTAMOS CON EL METODO INSERTAR_TFN_CLIENTE  Y LE PASAMOS LOS PARAMETROS Y LA CONEXION DE OBTENER_IDCLIENTE
                    Conexion.Insertar_TFNO_cliente(Conexion.Obtener_IDcliente(), textBoxtelefono1.Text, textBoxtelefono2.Text);
                }
           
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("Error,Introduzca Bien los datos", "Mensaje ventana Cliente ", botones, MessageBoxIcon.Error);

            }
        }         

        private void Boton_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Buttonlimpiar_Click(object sender, EventArgs e)
        {
            textBoxapellido1.Text = "";
            textBoxapellido2.Text = "";
            textBoxnombre.Text = "";
            textBoxdireccion.Text = "";
            textBoxtelefono1.Text = "";
            textBoxtelefono2.Text = "";
            textBoxdni.Text = "";
            textobservasiones.Text = "";
            textEMAIL.Text = "";
        }
    }
}
