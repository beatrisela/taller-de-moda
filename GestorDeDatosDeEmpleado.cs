using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;//variables necesarias para la conecion a la BD

namespace TALLER_DE_MODA
{
    public class GestorDeDatosDeEmpleado
    {
        DbConexion conexion;
        public GestorDeDatosDeEmpleado(DbConexion conexion)
        {
            this.conexion = conexion;
        }
        public bool insert(EmpleadoModelo empleado)
        {
            string q = "INSERT INTO empleado (nombre,dni,apellido1,apellido2,direccion,fecha_inicio,fecha_final,sexo,email,observaciones) VALUES (@nombre,@dni,@apellido1,@apellido2,@direccion,@fecha_inicio,@fecha_final,@sexo,@email,@observaciones)";
            return this.conexion.PasarConexion<bool>((SqlConnection conexion) => {
                SqlCommand cmd = new SqlCommand(q, conexion);
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 80).Value = empleado.nombre;
                cmd.Parameters.Add("@dni", SqlDbType.NVarChar, 80).Value = empleado.dni;
                cmd.Parameters.Add("@apellido1", SqlDbType.NVarChar, 80).Value = empleado.apellido1;
                cmd.Parameters.Add("@apellido2", SqlDbType.NVarChar, 80).Value = empleado.apellido2;
                cmd.Parameters.Add("@direccion", SqlDbType.NVarChar, 80).Value = empleado.direccion;
                cmd.Parameters.Add("@fecha_inicio", SqlDbType.NVarChar, 80).Value = empleado.fecha_inicio;
                cmd.Parameters.Add("@fecha_final", SqlDbType.NVarChar, 80).Value = empleado.fecha_final;
                cmd.Parameters.Add("@sexo", SqlDbType.NVarChar, 80).Value = empleado.sexo;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 80).Value = empleado.email;
                cmd.Parameters.Add("@observaciones", SqlDbType.NVarChar, 80).Value = empleado.observaciones;
                return cmd.ExecuteNonQuery() > 0;
            });
        }
        public EmpleadoModelo select(string dni)
        {
            string q = "SELECT idempleado,nombre,dni,apellido1,apellido2,direccion,fecha_inicio,fecha_final,sexo,email,observaciones FROM empleado WHERE dni = @dni";
            return this.conexion.PasarConexion<EmpleadoModelo>((SqlConnection conexion) => {
                SqlCommand cmd = new SqlCommand(q, conexion);
                cmd.Parameters.Add("@dni", SqlDbType.NVarChar, 80).Value = dni;
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                EmpleadoModelo empleado = new EmpleadoModelo();
                empleado.idempleado = dr["idempleado"].ToString();
                empleado.nombre = dr["nombre"].ToString();
                empleado.dni = dr["dni"].ToString();
                empleado.apellido1 = dr["apellido1"].ToString();
                empleado.apellido2 = dr["apellido2"].ToString();
                empleado.direccion = dr["direccion"].ToString();
                empleado.fecha_inicio = dr["fecha_inicio"].ToString();
                empleado.fecha_final = dr["fecha_final"].ToString();
                empleado.sexo = dr["sexo"].ToString();
                empleado.email = dr["email"].ToString();
                empleado.observaciones = dr["observaciones"].ToString();
                dr.Close();
                return empleado;
            });
        }
        public void update() { }
        public bool delete(string dni)
        {
            string q = "DELETE FROM empleado WHERE dni = @dni";
            return this.conexion.PasarConexion<bool>((SqlConnection conexion) => {
                SqlCommand cmd = new SqlCommand(q, conexion);
                cmd.Parameters.Add("@dni", SqlDbType.NVarChar, 80).Value = dni;
                return cmd.ExecuteNonQuery() > 0;
            });
        }
    }
}
