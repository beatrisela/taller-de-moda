using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER_DE_MODA;//libreria


namespace TALLER_DE_MODA
{
    public partial class usuario : Form
    {
        GestorDeDatosDeUsuario gestor;
        public usuario(GestorDeDatosDeUsuario gestor)
        {
            this.gestor = gestor;
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)//ventana
        {
            DataTable dt = this.gestor.MapaDeIdUsuarioConNombreCompleto();
            comboBox1_nombre.DisplayMember = "usuario"; // Lo que el usuario quiere ver!
            comboBox1_nombre.ValueMember = "idempleado";// Lo que mi aplicación quiere usar!
            comboBox1_nombre.DataSource = dt;//de donde sale la información que quiero mostrar!
            comboBox1_nombre.SelectedIndex = 0; //pone el comboBox en el indixe 0
        }
        //se crea un metodo para 
        private void ComboBox1_nombre_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Al detectar que se ha seleccionado otro usuario, debe cargar en el txtBoxID el ID de dicho usuario
            textBox_ID.Text = comboBox1_nombre.SelectedValue.ToString();// selectedValue devuelve el campo de la consulta 
        }
        private void Button_aceptar_Click(object sender, EventArgs evento)
        {
            UsuarioModelo usuario = new UsuarioModelo()
            {
                idempleado = int.Parse(comboBox1_nombre.SelectedValue.ToString()),
                clave = textBox_clave.Text,
                permisos = textBox_permisos.Text
            };
            try
            {
                if (this.gestor.Insert(usuario))
                {
                    MessageBox.Show("Registrado");
                }
                else
                {
                    MessageBox.Show("NO Registrado!");
                }
            }
            catch(Exception e)// Poner el catch para obtener el posible error
            {
                MessageBoxButtons botones = MessageBoxButtons.OK;
                MessageBox.Show(e.Message.ToString(), "Cágate", botones, MessageBoxIcon.Error);
                MessageBox.Show("Error,Introduzca Bien los datos", "Mensaje ventana Usuarios", botones, MessageBoxIcon.Error);
            }
          
        }
      
        private void Boton_volver_al_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mimenu = new Menu();
            mimenu.Show();
            
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            Foto_fashion.Hide();
            if (comboBox_busqueda.Text != "")//se usa para que el boton buscar no funcione cuando no tenga nada
            {
                DataTable dt = new DataTable();
                string consulta = "Select " + comboBox_busqueda.Text + " from usuario;"; //consulta que hacemos para el boton donde elegimos
                dt = Conexion.Conectar(consulta); //se le pone la variable consulta que tendra 
                dataGridView1.DataSource = dt;
            }
            Foto_fashion.Hide();
        }

      
        private void ComboBox_busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
           //no se pone nada
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            //esta es la manera de limpiar //
            textBox_ID.Text = "";
            textBox_clave.Text = "";
            comboBox1_nombre.Text = "";
            textBox_permisos.Text = "";
            dataGridView1.DataSource = ("");
            Foto_fashion.Show();
        }

        
    }
}
