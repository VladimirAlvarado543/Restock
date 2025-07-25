using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Conexion;

namespace Modelo.Entidades
{
    public class Categoria
    {
        private int idCategoria;
        private string nombreCategoria;
        private string detalles;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombreCategoria { get => nombreCategoria; set => nombreCategoria = value; }
        public string Detalles { get => detalles; set => detalles = value; }

        public static DataTable VerCategoria()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQuery = "select  idCategoria, nombreCategoria, detalles from Categoria;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataVirtual = new DataTable();
            add.Fill(dataVirtual);
            return dataVirtual;
        }
        public bool InsertarCategoria()
        {
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQueryInsertar = "INSERT INTO Categoria(NombreCategoria, Detalles) values (@NombreCategoria, @Detalles);";
            SqlCommand insertar = new SqlCommand(consultaQueryInsertar, conexion);
            insertar.Parameters.AddWithValue("@NombreCategoria", nombreCategoria);
            insertar.Parameters.AddWithValue("@Detalles", detalles);

            if (insertar.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
