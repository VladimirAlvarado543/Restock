using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public class Marca
    {
        private int idMarca;
        private string nombreMarca;
        private string detalles;

        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string NombreMarca { get => nombreMarca; set => nombreMarca = value; }
        public string Detalles { get => detalles; set => detalles = value; }

        public static DataTable VerMarca()
        {
            SqlConnection conexion = Conexion.ConexionDB.Conectar();
            string consultaQuery = "SELECT idMarca, nombreMarca, detalles FROM Marca;";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable dataVirtual = new DataTable();
            add.Fill(dataVirtual);
            return dataVirtual;
        }

        public bool InsertarMarca()
        {
            SqlConnection conexion = Conexion.ConexionDB.Conectar();
            string consultaQueryInsertar = "INSERT INTO Marca(NombreMarca, Detalles) VALUES (@NombreMarca, @Detalles);";
            SqlCommand insertar = new SqlCommand(consultaQueryInsertar, conexion);
            insertar.Parameters.AddWithValue("@NombreMarca", nombreMarca);
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
