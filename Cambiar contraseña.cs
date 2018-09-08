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
    public partial class Cambiar_contraseña : Form 
    {

        //---- ------------------------CONTRUCTOR PARA PODER MOSTRAR EN LA VENTANA EL NOMBRE---------------------------------------------
        
        string nombre = "";//variable que usaremos en la ventana para enseñar los datos
        public Cambiar_contraseña(string nombreUsuario) //parametro que viene de del retun del metodo ObtenerNombre en utilidades
        {
            InitializeComponent();
            this.nombre = nombreUsuario; //guarda el resultado del retun en nombre
        }

        private void Cambiar_contraseña_Load(object sender, EventArgs e)//ventana
        {
            textnombre.Text = nombre; //nos muestra el nombre con sus apellidos en la ventana 
            txt_ID.Text = Program.usuario;  // pasa el id introducido en el login a la ventana cmbiar contraseña ,no lo coje de otro lado
           
        }
        //-------------------------------------------------------------------------------------------------------------------
        //------regresa al menu--
        private void Boton_volver_menu_Click(object sender, EventArgs e)
        {
            this.Hide();//para que regrese al mismo menu   
        }
        private void Limpiar_controles()//se crea el metodo para poder invocarlo tantas veses sea nesesario y ahorrar codigo
        {        
            text_clave_nueva.Text = "";
            text_repite_clave.Text = "";
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar_controles();
        }

        private void Button_cambiar_Click(object sender, EventArgs e)
        {
            if( (text_clave_nueva.Text == text_repite_clave.Text) && (text_clave_nueva.Text !="" )) // para que si estan en blanco salte un error
            {
                Conexion.Cambiar_password(txt_ID.Text, text_clave_nueva.Text);//llamamos al metodo y le pasamos los dos texbox
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("Se ha actualizado la contraseña correctamente.", "Mensaje ventana contraseña", botones, MessageBoxIcon.Information);
            }
            else 
            {   
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("Error,Introduzca Bien los datos", "Mensaje ventana contraseña", botones, MessageBoxIcon.Error);
                Limpiar_controles();
            }
        }

      
    }
}
