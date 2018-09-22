using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TALLER_DE_MODA;//libreria


namespace TALLER_DE_MODA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //**********************VENTANA DEL MENU********************
        private void Menu_Load(object sender, EventArgs e)
        {
            labelusuario.Text = "Usuario:  " + Program.usuario; // para que aparesca el id que se introdujo anteriormente en el login
            lblNombre.Text = Conexion.ObtenerNombre(Program.usuario);//Para que aparesca el nombre del empleado


            if (Program.usuario != "1")
            {
                imagen_menu_almacen.Enabled = false;
                imagen_menu_Nempleado.Enabled = false;
                imagen_menu_Empleado.Enabled = false;
                boton_tipo_usario.Enabled = false;
            }
            //imagen_menu_almacen.Enabled = true; //para que se vea poner permisos aqui
        }
        //*********************BOTONES MENU***********************
        private void Boton_contraseña_tipo_usario_Click(object sender, EventArgs e)
        {
           
            Cambiar_contraseña micontraseña = new Cambiar_contraseña(lblNombre.Text);// ventana contraseña
            micontraseña.Show();
        }
        private void Boton_administrador_Click(object sender, EventArgs e)
        {
            this.Hide();
            DbConexion con = new DbConexion();
            GestorDeDatosDeUsuario gestor = new GestorDeDatosDeUsuario(con);
            usuario usuarios = new usuario(gestor);// ventana usuario
            usuarios.Show();
        }
        private void Boton_cerrar_tipo_usario_Click(object sender, EventArgs e)
        {
            Application.Exit(); //sale del programa
        }
        //**********************PARTE DEL TIMER BOTON SUELTO***********************
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss"); //hora se inserta en los labes
            lblfecha.Text = DateTime.Now.ToShortDateString();//fecha
        }

        // ************************IMAGENES MENU SON BOTONES**************************
        private void Imagen_menu_Login_Click(object sender, EventArgs e)//regrese a la ventana login 
        {
            this.Hide();
            Login milogin = new Login();
            milogin.Show();    //la mostramos   
        }
        private void Imagen_menu_Nempleado_Click(object sender, EventArgs e)
        {
            DbConexion conexion = new DbConexion();
            GestorDeDatosDeEmpleado gestor = new GestorDeDatosDeEmpleado(conexion);
            Nuevo_Empleado miempleado = new Nuevo_Empleado(gestor);//ventana empleado
            miempleado.Show();  
        }
        private void Imagen_menu_Empleado_Click(object sender, EventArgs e)
        {
            
            Registro_Empleados registro_Empleados = new Registro_Empleados();
            registro_Empleados.Show();
        }
        private void Imagen_menu_cuadrante_Click(object sender, EventArgs e)
        {
            cuadrante miturno = new cuadrante();
            miturno.Show();
        }
        private void Imagen_menu_confeccion_Click(object sender, EventArgs e)
        {
            Confeccion_de_ropa miconfeccion = new Confeccion_de_ropa();
            miconfeccion.Show();
        }
        private void Imagen_menu_Cliente_nuevo_Click(object sender, EventArgs e)
        {
            Cliente_nuevo miclientenuevo = new Cliente_nuevo();
            miclientenuevo.Show();
        }
        private void Menu_cliente_factura_Click(object sender, EventArgs e)
        {
            Cliente_facturas micliente = new Cliente_facturas();
            micliente.Show();
        }
        private void Imagen_menu_provedor_Click(object sender, EventArgs e)
        {
            Proveedor miproveedor = new Proveedor();
            miproveedor.Show();
        }
        private void Imagen_menu_pedido_Click(object sender, EventArgs e)
        {
            pedidos mipedido = new pedidos();
            mipedido.Show();
        }
        private void Imagen_menu_almacen_Click(object sender, EventArgs e)
        {
            almacen mialmacen = new almacen();
            mialmacen.Show();
        }

        private void Menu_imagen_clientela_Click(object sender, EventArgs e)
        {
            Cliente_registrado micliente = new Cliente_registrado();
            micliente.Show();
        }

        private void Menu_imagen_tienda_Click(object sender, EventArgs e)
        {
            Tienda_clientes mitienda = new Tienda_clientes();
            mitienda.Show();
        }
    }
    
}
