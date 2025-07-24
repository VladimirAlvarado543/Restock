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
    public class Usuario
    {
        // Declarar las variables privadas que representan los campos de la tabla Usuario
        private int idUsuario;
        private string contrasenia;
        private string nombre;
        private string apellido;
        private int rol;
        private string numeroTelefono;
        private string contacto;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Rol { get => rol; set => rol = value; }
        public string NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public string Contacto { get => contacto; set => contacto = value; }

        public static DataTable ObtenerUsuarios(string nombre, int id)
        {
            using (SqlConnection con = ConexionDB.Conectar())
            {
                // Se establece una conexión a la base de datos usando la clase ConexionDB
                string consulta = "SELECT idUsuario, contrasenia, nombre, apellido, R.nombreRol AS Rol, numeroTelefono, " +
                    "contacto \r\nFROM Usuario U\r\nINNER JOIN Rol R ON U.idRol = R.id_Rol WHERE 1=1";

                // Se define una consulta SQL que selecciona varios campos de la tabla Usuario y sus relaciones
                if (!string.IsNullOrWhiteSpace(nombre))
                    consulta += " AND (nombre LIKE @nombre)";
                // Si el nombre no está vacío, se agrega una condición a la consulta SQL
                if (id > 0)
                    consulta += " AND idUsuario = @id";

                using (SqlCommand cmd = new SqlCommand(consulta, con))
                {
                    // Se crea un comando SQL que se usará para ejecutar la consulta
                    if (!string.IsNullOrWhiteSpace(nombre))
                        cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    // Si el nombre no está vacío, se agrega como parámetro al comando SQL
                    if (id > 0)
                        cmd.Parameters.AddWithValue("@id", id);

                    SqlDataAdapter add = new SqlDataAdapter(cmd);
                    //sirve para llenar datos desde una base de datos SQL Server

                    DataTable dt = new DataTable();
                    //Crea una tabala donde alamacera los datos de las columnas y filas 
                    add.Fill(dt);
                    //se carga la consulta a la base de datos
                    return dt;
                    //Si todo funciona correctamente regresara los datos 
                }
            }
        }

        
        public bool InsertarUsuarios()
        {
            // Método para insertar un nuevo usuario en la base de datos
            SqlConnection conexion = ConexionDB.Conectar();
            string consultaQueryInsertar = "INSERT INTO Usuario (contrasenia, nombre, apellido, idRol, numeroTelefono, contacto) " +
                                           "VALUES (@contrasenia, @nombre, @apellido, @idRol, @numeroTelefono, @contacto);";
            // Se define una consulta SQL que inserta un nuevo usuario en la tabla Usuario
            SqlCommand insertar = new SqlCommand(consultaQueryInsertar, conexion);
            // Se crea un comando SQL que se usará para ejecutar la consulta
            insertar.Parameters.AddWithValue("@contrasenia", contrasenia);
            insertar.Parameters.AddWithValue("@nombre", nombre);
            insertar.Parameters.AddWithValue("@apellido", apellido);
            insertar.Parameters.AddWithValue("@idRol", rol);
            insertar.Parameters.AddWithValue("@numeroTelefono", numeroTelefono);
            insertar.Parameters.AddWithValue("@contacto", contacto);

            if (insertar.ExecuteNonQuery() > 0)
            {
                // Si la consulta se ejecuta correctamente y afecta a una o más filas, se retorna true
                return true;
            }
            else
            {
                // Si no se afecta ninguna fila, se retorna false
                return false;
            }
        }

    }
}
