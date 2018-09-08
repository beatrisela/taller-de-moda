using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;//variables necesarias para la conecion a la BD
using System.Windows.Forms;//permite utilizar componentes graficos y los messenger

namespace TALLER_DE_MODA
{
    public  class Conexion
    {


          //*****************************************CONEXION A LA BASE DE DATOS***********************************************

        public static DataTable Conectar (string cmd) //cmd variable ,Conectar nombre del metodo,el tipo es DataTable
        {

                                                              //HMLMVQ5 del poyecto  //9DIONMU de casa       //nombre BD
            // SqlConnection con = new SqlConnection("Data Source=DESKTOP-HMLMVQ5\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");

          SqlConnection con = new SqlConnection("Data Source="+Environment.UserDomainName+"\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
          con.Open();//habre la conexion 
          DataTable dt = new DataTable(); //crea la Tabla le damos el nombre de dt 
          SqlDataAdapter da = new SqlDataAdapter(cmd,con); //SqlDataAdapter origen de datos,hactualizar,da nombre inventado
          da.Fill(dt); //filas de las tabla 
          con.Close();// cierra conexion
          return dt;  // retorna el valor de la tabla 
        }

      
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< METODOS CREADOS >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


        //--------------------------------------------------INSERTAR DATOS:-----------------------------------------

          
                                     /*-------- TABLA USUARIO ADMINISTRADOR------------*/

        public static bool Insertar_claves(string ID_usuario,  string CLAVE, string PERMISOS) //
        {
            SqlConnection conexion = new SqlConnection("Data Source="+Environment.UserDomainName+"\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into USUARIO VALUES ('{0}','{1}','{2}')",ID_usuario,  CLAVE, PERMISOS), conexion);//STRING.fORMAT formato que quieres que coja
            cmd.ExecuteNonQuery();//para que se ejecute nuestra sentencia SQL
            conexion.Close();
            bool b = true; 
            return b;
        }
        /*  ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

                                  /*-------- TABLA EMPLEADO-------- Y------------TELEFONOS----------------*/

        //insertar los datos 
        public static bool Insertar_Empleados(string nombre, string DNI, string apellido1, string apellido2, string direccion, string fecha_inicio, string fecha_final, string sexo, string EMAIL, string observaciones)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into EMPLEADO (nombre,DNI,apellido1,apellido2, direccion,fecha_inicio,fecha_final,sexo,EMAIL,observaciones)values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", nombre, DNI, apellido1, apellido2, direccion, fecha_inicio, fecha_final, sexo, EMAIL, observaciones), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            bool b = true;
            return b;
        }
        //---una vez insertados los datos genera el id ,ese id lo tenemos que capturar
        public static string Obtener_idempleado()
        {
            string id = "";
            DataTable dt = Conexion.Conectar("select max(idempleado) as IDCAPTURADO from empleado;");//SELECCIONA EL ULTIMO ID INTRODUCIDO EN LA TABLA PROVEEDORES
            foreach (DataRow row in dt.Rows)//para las filas 
            {
                id = Convert.ToString(row["IDCAPTURADO"]);//rows son para tuplas ,el dato se convierte a un estring              
            }
            return id;
        }
        //---insertar los datos de telefono ,se utilizara el idcapturado en el boton de registrar
        public static bool Insertar_TFNO_empleado(string IDempleado, string telefono1, string telefono2)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into telefonos_empleado (idempleado, telefono1, telefono2)  VALUES ('{0}','{1}','{2}')", IDempleado, telefono1, telefono2), conexion);//STRING.fORMAT formato que quieres que coja
            cmd.ExecuteNonQuery();
            conexion.Close();
            bool b = true;
            return b;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                //-------- TABLA  CLIENTE--- Y---------- TELEFONOS ------------

        public static bool Insertar_clientes(string DNI, string nombre, string apellido1, string apellido2, string direccion, string EMAIL, string observaciones)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into CLIENTE (DNI,nombre,apellido1,apellido2,direccion, email,observaciones)values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",DNI, nombre, apellido1, apellido2, direccion, EMAIL,observaciones), conexion);//STRING.fORMAT formato que quieres que coja
            cmd.ExecuteNonQuery();
            conexion.Close();
            bool b = true;
            return b;
        }

        public static string Obtener_IDcliente()
        {
            string id = "";
            DataTable dt = Conexion.Conectar("select max(idcliente) as IDCAPTURADO from cliente;");//SELECCIONA EL ULTIMO ID INTRODUCIDO EN LA TABLA PROVEEDORES
            foreach (DataRow row in dt.Rows)//para las filas 
            {
                id = Convert.ToString(row["IDCAPTURADO"]);//rows son para tuplas ,EL DATO SE CONVIERTE A UN STRING              
            }
            return id;
        }

        public static bool Insertar_TFNO_cliente(string idcliente, string telefono1, string telefono2)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into telefono_cliente (idcliente, telefono1, telefono2)  VALUES ('{0}','{1}','{2}')", idcliente, telefono1, telefono2), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            bool b = true;
            return b;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                           //---Tienda Cliente-------

        public static bool Insertar_tienda(string cif_tienda, string nombre, string telefono, string observasion)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into cliente_tiendas (cif_tienda,nombre,telefono,observacion) VALUES ('{0}','{1}','{2}','{3}')", cif_tienda, nombre, telefono, observasion), conexion);//STRING.fORMAT formato que quieres que coja
            cmd.ExecuteNonQuery();
            conexion.Close();
            bool b = true;
            return b;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //-----------------TABLAPROVEEDOR------------TELEFONOS---------PAIS---PROVINCIA



         //------PRIMERO INSERTA LOS DATOS EN LA TABLA POVEEDORES------------
        public static bool Insertar_proveedores(string CIF, string nombre_empresa, string EMAIL)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into proveedores (CIF, Nombre_empresa, email)  VALUES ('{0}','{1}','{2}')", nombre_empresa, EMAIL,CIF), conexion);//STRING.fORMAT formato que quieres que coja                                       
            cmd.ExecuteNonQuery();
            conexion.Close();
            bool b = true;
            return b;
        }
        //----SEGUNDO PARA UNA VEZ INSERTADOS LOS DATOS GENERA EL ID , ESE ID LO TENEMOS QUE CAPTURA

            // ******* HAY QUE MODIFICARLO *****

        public static string Obtener_IDProveedor()
        {
            string id = "";
            DataTable dt = Conexion.Conectar("select CIF as IDCAPTURADO from proveedores;");//SELECCIONA EL ULTIMO ID INTRODUCIDO EN LA TABLA PROVEEDORES
            foreach (DataRow row in dt.Rows)//para las filas 
            {
                id = Convert.ToString(row["IDCAPTURADO"]);//rows son para tuplas ,EL DATO SE CONVIERTE A UN STRING              

            }
            return id;
        }
        //----TERCERO INSERTAR LOS DATOS DE TELEFONO ,SE UTILIZARA EL IDCAPTURADO EN EL BOTON DE REGISTRAR 
        public static bool Insertar_TFNO_proveedores(string CIF, string telefono1, string telefono2)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into telefono_proveedores (CIF, telefono1, telefono2)  VALUES ('{0}','{1}','{2}')", CIF, telefono1, telefono2), conexion);//STRING.fORMAT formato que quieres que coja
            cmd.ExecuteNonQuery();
            conexion.Close();
            bool b = true;
            return b;
        }

        /*---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

        public static string Obtener_ID_PROVEEDOR(string nombreProveedor)
        {
            string id = "";
            DataTable dt = Conexion.Conectar("SELECT CIF FROM PROVEEDORES WHERE NOMBRE_EMPRESA = '" + nombreProveedor +"';");//SELECCIONA EL ULTIMO ID INTRODUCIDO EN LA TABLA PROVEEDORES
            foreach (DataRow row in dt.Rows)//para las filas 
            {
                id = Convert.ToString(row["CIF"]);//rows son para tuplas ,EL DATO SE CONVIERTE A UN STRING              
            }
            return id;
        }


        //-------- TABLA PRODUCTOS---------------

        public static bool Insertar_pedidos(string precio_unidad, string descripcion_producto, string cantidad, string cif)
        {
            SqlConnection conexion = new SqlConnection("Data Source="+Environment.UserDomainName+"\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("Insert into productos VALUES ('{0}','{1}','{2}', '{3}')", precio_unidad, descripcion_producto, cantidad, cif ), conexion);//STRING.fORMAT formato que quieres que coja
            cmd.ExecuteNonQuery();
            conexion.Close();
            bool b = true; 
            return b;
        }
       //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------



                                         //------------------------- METODOS  BUSCAR SELECT  -----------------------------------

        //---------------TABLA PARA OBTENER NOMBRE-----apellido1------ apellido2------DE EMPLEADO y el id  DE USUARIO  ---------//

        public static string ObtenerNombre(string ID_usuario) //parametro que necesitamos  de la BD tabla usuario
        {
            string nombreUsuario = ""; //variable inventada
            DataTable dt = Conexion.Conectar("SELECT IDUSUARIO, NOMBRE, APELLIDO1, APELLIDO2 from EMPLEADO  INNER JOIN USUARIO ON EMPLEADO.IDEMPLEADO = USUARIO.IDEMPLEADO WHERE USUARIO.IDUSUARIO = '" + ID_usuario + "'");//se le pasa el parametro
            foreach (DataRow row in dt.Rows)//DataRow representa una fila de datos en  la tabla //row variable inventada//dt la tabla//Rows filas
            {
                
                nombreUsuario = Convert.ToString(row["nombre"]) + " " + Convert.ToString(row["apellido1"]) + " " + Convert.ToString(row["apellido2"]);

            }
            return nombreUsuario; //retornamos su valor al metodo cambiar contraseña y nos enseñara el nombre completo del empleado

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

                                           //------- RRELLENAR COMBOBOX----------
       //---------PROVEEDOR-----
         public void Llenarpais (ComboBox cb)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select pais from paises"), conexion);
            SqlDataReader dr = cmd.ExecuteReader();//para llenar nuestro dr con nuestra consulta
            while (dr.Read()) //va lellendo los registros 
            {
                cb.Items.Add(dr["PAIS"].ToString()); //asignadolos a nuestro combobox
            }
            dr.Close();
        }
        public void Llenarprovincias(ComboBox cb)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select provincia from provincias"), conexion);
            SqlDataReader dr = cmd.ExecuteReader();//para llenar nuestro dr con nuestra consulta
            while (dr.Read()) //va lellendo los registros 
            {
                cb.Items.Add(dr["PROVINCIA"].ToString()); //asignadolos a nuestro combobox
            }
            dr.Close();
        }
        //-------------------------------------------------------------------------------------------------------------------
        public void Llenar_provedor_productos(ComboBox cb)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select nombre_empresa from proveedores"), conexion);
            SqlDataReader dr = cmd.ExecuteReader();//para llenar nuestro dr con nuestra consulta
            while (dr.Read()) //va lellendo los registros 
            {
                cb.Items.Add(dr["nombre_empresa"].ToString()); //asignadolos a nuestro combobox
            }
            dr.Close();
        }


        //-------------------------------------------------------------------------------------------------------------------

        


        //***********************************METODOS DE  MODIFICAR DATOS *******************************

        //-------------USUARIO  cambiar clave----------------

        public static bool Cambiar_password(string ID_usuario, string CLAVE)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("UPDATE USUARIO SET CLAVE = '{0}' WHERE IDUSUARIO = '{1}'", CLAVE, ID_usuario), conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
            bool b = true; 
            return b;
        }
       //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
     


       //**********************************METODO DE  ELIMINAR DATOS ********************************

        //-------- TABLA EMPLEADO---------------
        public static bool Eliminar_empleado(string IDEMPLEADO)
            {
                SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
                conexion.Open();
                SqlCommand cmd = new SqlCommand(string.Format("delete from empleado WHERE IDEMPLEADO = '{0}'", IDEMPLEADO), conexion);
                int filasafectadas = cmd.ExecuteNonQuery();
                conexion.Close();
                if (filasafectadas > 0) return true;
                else return false;
            }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
      
        //------------TABLA PROVEEDOR---------
        public static bool Eliminar_TFNO_proveedor(string CIF)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from TELEFONO_PROVEEDORES WHERE CIF = '{0}'", CIF), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public static bool Eliminar_proveedor(string CIF)
        {
        SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
        conexion.Open();
        SqlCommand cmd = new SqlCommand(string.Format("delete from PROVEEDORES WHERE CIF = '{0}'", CIF), conexion);
        int filasafectadas = cmd.ExecuteNonQuery();
        conexion.Close();
        if (filasafectadas > 0) return true;
        else return false;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
      
        //------------TABLA TIENDA---------

        public static bool Eliminar_tienda(string idtienda)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from cliente_tiendas WHERE idtienda = '{0}'", idtienda), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        //------------------------------------------------------------------------------------------------------------------------------
       
        //------------REGISTRO CLIENTE----------------

        public static bool Eliminar_TFNO_Clientes(string idcliente)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from TELEFONO_CLIENTE WHERE idcliente = '{0}'", idcliente), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public static bool Eliminar_cliente(string idcliente)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from cliente WHERE idcliente = '{0}'", idcliente), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        //------------------------------------------------------------------------------------------------------------------
        public static bool Eliminar_producto(string idproductos)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True");
            conexion.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from productos WHERE idproductos = '{0}'", idproductos), conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }
    }
}
