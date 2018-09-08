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
    public partial class Cliente_registrado : Form
    {
        public Cliente_registrado()
        {
            InitializeComponent();
        }
        private void Cliente_registrado_Load(object sender, EventArgs e)//ventana
        {
            Foto_fashion.Hide();
            DataTable dt = new DataTable();
            string consulta = "Select c.idcliente,DNI,nombre,apellido1,apellido2,direccion,EMAIL,observaciones,telefono1,telefono2 from cliente as c join telefono_cliente on c.idcliente =telefono_cliente.idcliente;";
            dt = Conexion.Conectar(consulta);
            datalistado.DataSource = dt;
        }
           
        private void Regresar_Empleado_menu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Limpiar_registro_empleado_Click(object sender, EventArgs e)
        {
            Foto_fashion.Show();
        }
        private void Buscar_registro_cliente_Click(object sender, EventArgs e)
        {
            Foto_fashion.Hide();
        }


        private void Btneliminar_Registro_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(datalistado.CurrentRow.Cells[0].Value);
                DataTable dt = new DataTable();
                string consulta = "delete from telefono_cliente where idcliente = " + i + ";"; //consulta que hacemos para el boton donde elegimos
                dt = Conexion.Conectar(consulta); //se le pone la variable consulta que tendra 
                consulta = "delete from factura_cliente where id_cliente= " + i + ";";
                dt = Conexion.Conectar(consulta);
                consulta = "delete from cliente where idcliente = " + i + ";";
                dt = Conexion.Conectar(consulta);
                datalistado.DataSource = dt;
                MessageBox.Show("cliente  borrado");

                dt = Conexion.Conectar("select c.idcliente,DNI,NOMBRE,APELLIDO1,APELLIDO2,DIRECCION,EMAIL,OBSERVACIONES,TELEFONO1,TELEFONO2 from cliente as c  join telefono_cliente on c.IDCLIENTE = TELEFONO_CLIENTE.idcliente");
                datalistado.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

       
    }
}
