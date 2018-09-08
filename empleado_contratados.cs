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
    public partial class Registro_Empleados : Form
    {
        public Registro_Empleados()
        {
            InitializeComponent();
        }

        private void Empleado_contratados_Load(object sender, EventArgs e)//ventana
        {
            Foto_fashion.Hide();
            DataTable dt = new DataTable();
            string consulta = "Select E.IDEMPLEADO,DNI,NOMBRE,APELLIDO1,APELLIDO2,DIRECCION,EMAIL,OBSERVACIONES,CONVERT (VARCHAR,FECHA_INICIO,103) AS FECHA_INICIO, CONVERT (VARCHAR,FECHA_FINAL,103) AS FECHA_FINAL,SEXO,TELEFONO1,TELEFONO2 from empleado as E  join telefonos_empleado on E.IDEMPLEADO= TELEFONOS_EMPLEADO.IDEMPLEADO"; //consulta que hacemos para el boton donde elegimos
            dt = Conexion.Conectar(consulta); //se le pone la variable consulta que tendra 
            datalistado.DataSource = dt;
        }
        private void Regresar_Empleado_menu_Click(object sender, EventArgs e)//regresa
        {
            this.Close();
        }
        private void Clear_registro_empleado_Click(object sender, EventArgs e) //limpiar
        {
            Foto_fashion.Show();  
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Foto_fashion.Hide();
        }

        private void Cbocampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //caja de busqueda con flecha no ponemos nada
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(datalistado.CurrentRow.Cells[0].Value);
                DataTable dt = new DataTable();
                string consulta = "delete from telefonos_empleado where idempleado = " + i + ";"; //consulta que hacemos para el boton donde elegimos
                dt = Conexion.Conectar(consulta); //se le pone la variable consulta que tendra 
                consulta = "delete from empleado_arreglo where idempleado = " + i + ";";
                dt = Conexion.Conectar(consulta);
                consulta = "delete from nomina where idempleado = " + i + ";";
                dt = Conexion.Conectar(consulta);
                consulta = "delete from usuario where idempleado = " + i + ";";
                dt = Conexion.Conectar(consulta);
                consulta = "delete from empleado where idempleado = " + i + ";"; 
                dt = Conexion.Conectar(consulta);
                datalistado.DataSource = dt;
                MessageBox.Show("usuario borrado");

                dt = Conexion.Conectar("select  E.IDEMPLEADO,DNI,NOMBRE,APELLIDO1,APELLIDO2,DIRECCION,EMAIL,OBSERVACIONES,CONVERT (VARCHAR,FECHA_INICIO,103) AS FECHA_INICIO, CONVERT (VARCHAR,FECHA_FINAL,103) AS FECHA_FINAL,SEXO,TELEFONO1,TELEFONO2 from empleado as E  join telefonos_empleado on E.IDEMPLEADO= TELEFONOS_EMPLEADO.IDEMPLEADO" );
                datalistado.DataSource = dt;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }

        
    }
}
