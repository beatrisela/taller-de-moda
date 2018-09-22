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
        GestorDeDatosDeEmpleado gestor;
        public Nuevo_Empleado(GestorDeDatosDeEmpleado gestor)
        {
            this.gestor = gestor;
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
            if (p_nombres.Text == "" || Pertenese_DNI.Text == "")
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("Error, El Empleado no se a podido insertar ", "Mensaje Empleado", botones, MessageBoxIcon.Error);
            }
            else
            {
                string sexoEmpleado = rdbHombre.Checked ? "M" : "H";

                //(string nombre, string DNI, string apellido1, string apellido2, string direccion, string fecha_inicio, string fecha_final, string sexo, string EMAIL, string observaciones)
                EmpleadoModelo empleado = new EmpleadoModelo
                {
                    nombre = p_nombres.Text,
                    dni = Pertenese_DNI.Text,
                    apellido1 = p_apellido1.Text,
                    apellido2 = p_apellido2.Text,
                    direccion = p_direccion.Text,
                    fecha_inicio = p_fecha_inicio.Text,
                    fecha_final = p_fecha_final.Text,
                    sexo = sexoEmpleado,
                    email = textEMAIL.Text,
                    observaciones = textobservaciones.Text
                };

                if (this.gestor.insert(empleado))
                {
                    empleado.idempleado = this.gestor.select(empleado.dni).idempleado;
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show("El Empleado ha  sido insertado correctamente", "Mensaje Empleado", botones, MessageBoxIcon.Information);
                    Conexion.Insertar_TFNO_empleado(empleado.idempleado, p_telefono1.Text, p_telefono2.Text);
                }
                /*
                if ((Conexion.Insertar_Empleados(p_nombres.Text, Pertenese_DNI.Text, p_apellido1.Text, p_apellido2.Text, p_direccion.Text, p_fecha_inicio.Text, p_fecha_final.Text, sexoEmpleado, textEMAIL.Text, textobservaciones.Text)) == true)
                {
                    MessageBoxButtons botones = MessageBoxButtons.OK;
                    MessageBox.Show("El Empleado ha  sido insertado correctamente", "Mensaje Empleado", botones, MessageBoxIcon.Information);

                    // CONESTAMOS CON EL METODO INSERTAR_TFN_EMPEADO  Y LE PASAMOS LOS PARAMETROS Y LA CONEXION DE OBTENER_IDEMPLEADO
                    Conexion.Insertar_TFNO_empleado(Conexion.Obtener_idempleado(), p_telefono1.Text, p_telefono2.Text);
                }
                */
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
