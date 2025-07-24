using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Conexion
{
    class ConexionDB
    {
        private static string servidor = "VLADIMIR_AG\\SQLEXPRESS";
        private static string baseDeDatos = "SistemaInventario";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data Source={servidor};Initial Catalog={baseDeDatos};Integrated Security =true;";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
