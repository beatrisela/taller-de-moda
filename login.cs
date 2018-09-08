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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
          
        }
                           //*************************VENTANA LOGIN  **************************

        private void Login_Load(object sender, EventArgs e)
        {
            this.Hide(); //oculto esta ventana
            text_nombre.Focus();
        }
        //----------BOTON INICIAR PARA LOGEARSE -----------
        private void Boton_login_Click(object sender, EventArgs e)
        {
            bool b = true; //variable
            DataTable dt = Conexion.Conectar("select IdUsuario, clave from Usuario");//para poder logearte si estas en la BD
            foreach (DataRow row in dt.Rows)//para las filas 
            {
                if (text_nombre.Text == Convert.ToString(row["IDUSUARIO"]) && text_clave.Text == Convert.ToString(row["CLAVE"]))//rows son para tuplas
                {
                    Program.usuario = text_nombre.Text;// usamos la variable creada en la clase program para capturar el id ,y luego lo enseñara en el menu
                    Menu mimenu = new Menu();
                    this.Hide();
                    mimenu.Show();
                    b = false;// si no coincide el nombre se va al otro if                 
                    break;
                }
            }
            if (b) //condicion false
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show("Error,en Usuario o Contraseña", "Mensaje Login", botones, MessageBoxIcon.Error);
                text_clave.Text = "";
                text_nombre.Text = "";
                text_nombre.Focus();
            }  
        }
        //------------------------SALIR---------------------
        private void Boton_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //cierra la aplicacion
        }
       
        //------------------------boton quitar -------------------
      /*  private void Btn_invitado_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
        }*/

        
    }
}
