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
    public partial class Nuevo_Empleado : Form
    {
        public Nuevo_Empleado()
        {
            InitializeComponent();
        }

        private void Nuevo_Empleado_Load(object sender, EventArgs e)//ventana
        {
            p_nombres.Focus();
        }
        private void Boton_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {   
            this.Close();
        }
        private void Boton_Registrar_Click(object sender, EventArgs e)
        {
            if (p_nombres.Text != "")
            {
                string sexoEmpleado = "";//para capturar la opcion del boton

                if (rdbHombre.Checked)
                    sexoEmpleado = "H";
                else if (rdbMujer.Checked)
                    sexoEmpleado = "M";

                if ((Conexion.Insertar_Empleados(p_nombres.Text, Pertenese_DNI.Text, p_apellido1.Text, p_apellido2.Text, p_direccion.Text, p_fecha_inicio.Text, p_fecha_final.Text, sexoEmpleado, textEMAIL.Text, textobservaciones.Text)) == true)
                {
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show("El Empleado ha  sido insertado correctamente", "Mensaje Empleado", botones, MessageBoxIcon.Information);

                    // CONESTAMOS CON EL METODO INSERTAR_TFN_EMPEADO  Y LE PASAMOS LOS PARAMETROS Y LA CONEXION DE OBTENER_IDEMPLEADO
                    Conexion.Insertar_TFNO_empleado(Conexion.Obtener_idempleado(), p_telefono1.Text, p_telefono2.Text);
                }
            }
            else
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("Error, El Empleado no se a podido insertar ", "Mensaje Empleado", botones, MessageBoxIcon.Error);
            }
        }

        private void Buttonlimpiar_Click(object sender, EventArgs e)
        {
            p_nombres.Text = "";
            p_apellido1.Text = "";
            p_apellido2.Text = "";
            p_direccion.Text = "";
            p_fecha_final.Text = "";
            p_fecha_inicio.Text = "";
            rdbHombre.Text = "";
            rdbMujer.Text = "";
            Pertenese_DNI.Text = "";
            textEMAIL.Text = "";
            textobservaciones.Text = "";
            p_telefono1.Text = "";
            p_telefono2.Text = "";
        }
    
    }
    
}
