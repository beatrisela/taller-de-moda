using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TALLER_DE_MODA
{
    public class GestorDeDatosDeUsuario
    {
        static Func<SqlConnection, string, DataTable> recogerConsultaEnDataTable = (con, q) => {
            DataTable data = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(q, con);
            adaptador.Fill(data);
            return data;
        };
        DbConexion conexion;
        public GestorDeDatosDeUsuario(DbConexion conexion)
        {
            this.conexion = conexion;
        }
        public bool Insert(UsuarioModelo usuario)
        {
            string q = "INSERT INTO usuario (idempleado, clave, permisos) VALUES (@ide, @clave, @permisos)";
            return this.conexion.PasarConexion<bool>((SqlConnection conexion) => {
                SqlCommand cmd = new SqlCommand(q, conexion);
                cmd.Parameters.Add("@ide", SqlDbType.Int).Value = usuario.idempleado;
                cmd.Parameters.Add("@clave", SqlDbType.NVarChar, 100).Value = usuario.clave;
                cmd.Parameters.Add("@permisos", SqlDbType.NVarChar, 100).Value = usuario.permisos;
                return cmd.ExecuteNonQuery() > 0;
            });
        }
        public UsuarioModelo Select(int idusuario, string clave)
        {
            string q = "SELECT idusuario, '' AS clave, permisos FROM usuario WHERE idusuario = @id AND clave = @clave";
            return this.conexion.PasarConexion<UsuarioModelo>((SqlConnection conexion) => {
                SqlCommand cmd = new SqlCommand(q, conexion);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = idusuario;
                cmd.Parameters.Add("@clave", SqlDbType.NVarChar, 100).Value = clave;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    UsuarioModelo usuario = new UsuarioModelo()
                    {
                        idusuario = int.Parse(dr["idusuario"].ToString()),
                        clave = dr["clave"].ToString(),
                        permisos = dr["permisos"].ToString(),
                    };
                    return usuario;
                }
                return null;
            });
        }
        public bool update(UsuarioModelo empleado)
        {
            return false;
        }
        public bool delete(int ID_usario)
        {
            string q = "DELETE FROM usuarios WHERE id = @id";
            return this.conexion.PasarConexion<bool>((SqlConnection conexion) => {
                SqlCommand cmd = new SqlCommand(q, conexion);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID_usario;
                return cmd.ExecuteNonQuery() > 0;
            });
        }
        public DataTable MapaDeIdUsuarioConNombreCompleto()
        {
            string consulta = "SELECT idempleado, nombre + ' ' + apellido1 + ' ' + apellido2 AS usuario FROM empleado";
            return this.conexion.PasarConexionConConsulta(consulta, recogerConsultaEnDataTable);
        }
    }
}
