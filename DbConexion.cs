using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TALLER_DE_MODA
{
    public class DbConexion
    {
        private string parametrosDeConexion;
        public DbConexion(string parametrosDeConexion = "")
        {
            this.parametrosDeConexion = parametrosDeConexion == null || parametrosDeConexion == ""
                ? "Data Source=" + Environment.UserDomainName + "\\SQLEXPRESS;Initial Catalog=TALLER_MODA;Integrated Security=True"
                : parametrosDeConexion;
        }
        public T PasarConexion<T>(Func<SqlConnection, T> accion)
        {
            SqlConnection conexion = new SqlConnection(parametrosDeConexion);
            conexion.Open();
            T resultado = accion(conexion);
            conexion.Close();
            return resultado;
        }
        public T PasarConexionConConsulta<T>(string q, Func<SqlConnection, string, T> accion)
        {
            SqlConnection conexion = new SqlConnection(parametrosDeConexion);
            conexion.Open();
            T resultado = accion(conexion, q);
            conexion.Close();
            return resultado;
        }
    }
}
