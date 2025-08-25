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
        private static string servidor = "DESKTOP-E9GI9BL\\SQLEXPRESS";
        private static string baseDeDatos = "SistemaInventarioPPP";

        public static SqlConnection Conectar()
        {
            string cadena = $"Data Source={servidor};Initial Catalog={baseDeDatos};Integrated Security =true;";
            SqlConnection conexion = new SqlConnection(cadena);
            conexion.Open();
            return conexion;
        }
    }
}
