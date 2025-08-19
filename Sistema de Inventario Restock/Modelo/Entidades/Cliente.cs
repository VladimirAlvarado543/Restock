using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Conexion;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Modelo.Entidades
{
    public class Cliente
    {
        // Declarar las variables privadas que representan los campos de la tabla Cliente
        public int idCliente;
        private string nombre;
        private string nombreEmpresa;
        private string detalles;
        private string idDocumento;
        private string contacto;
        private string correoElectronico;
        private string direccion;
        private int numeroTelefono;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string Detalles { get => detalles; set => detalles = value; }
        public string IdDocumento { get => idDocumento; set => idDocumento = value; }
        public string Contacto { get => contacto; set => contacto = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int NumeroTelefono { get => numeroTelefono; set => numeroTelefono = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public static DataTable ObtenerCliente(string nombre, string nombreEmpresa, int id)
        {
            try { 
            using (SqlConnection con = ConexionDB.Conectar())
            {
              
                // Se define una consulta SQL que selecciona varios campos de la tabla Producto y sus relaciones
                string consulta = "SELECT *from Cliente WHERE 1=1";

                // Se agrega una condición para filtrar los resultados según el nombre del producto y el ID
                if (!string.IsNullOrWhiteSpace(nombre))
                { 
                    // Si el nombre no está vacío, se agrega una condición a la consulta SQL
                    consulta += " AND (nombre LIKE @nombre)";
                }
                // Si el ID es mayor que 0, se agrega una condición para filtrar por ID
                if (id > 0)
                {
                    consulta += "AND idCliente = @id";
                    // Si no se proporciona nombre ni ID, se retorna un DataTable vacío
                    return new DataTable();
                }
                if (!string.IsNullOrWhiteSpace(nombreEmpresa))
                { 
                
                    // Si el nombre no está vacío, se agrega una condición a la consulta SQL
                    consulta += " AND (nombreEmpresa LIKE @nombreEmpresa)";
                }
                // Se crea un comando SQL que se usará para ejecutar la consulta
                using (SqlCommand cmd = new SqlCommand(consulta, con))
                {
                    if (!string.IsNullOrWhiteSpace(nombre))
                    { 
                        // Si el nombre no está vacío, se agrega como parámetro al comando SQL
                        cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                        // Si el ID es mayor que 0, se agrega como parámetro al comando SQL
                    }
                    if (id > 0)
                    { 
                        cmd.Parameters.AddWithValue("@id", id);
                    }
                    if (!string.IsNullOrWhiteSpace(nombreEmpresa))

                        // Si el nombre no está vacío, se agrega como parámetro al comando SQL
                        cmd.Parameters.AddWithValue("@nombreEmpresa", "%" + nombreEmpresa + "%");
                    // Crea un adaptador que usa el comando SQL ya preparado (cmd)
                    // Este adaptador se encarga de ejecutar la consulta y llenar los datos en un DataTable
                    SqlDataAdapter add = new SqlDataAdapter(cmd);

                    // Se crea una nueva tabla donde se guardarán los datos obtenidos desde la base de datos
                    DataTable dt = new DataTable();

                    // El adaptador ejecuta la consulta y llena el DataTable con los resultados
                    add.Fill(dt);

                    // Retorna el DataTable lleno de datos al lugar donde se llamó esta función
                    return dt;

                }
                }
            }
            catch
            { return null; }
            
        }
        public bool InsertarClientes()
        {
            try { 
            // Se establece una conexión a la base de datos utilizando la clase ConexionDB
            SqlConnection conexion = ConexionDB.Conectar();

            // Se define una consulta SQL que selecciona varios campos de la tabla Producto y sus relaciones
            string consultaQueryInsertar = "INSERT INTO Cliente(nombre,nombreEmpresa,detalles,idDocumento,contacto,correoElectronico,direccion,numeroTelefono)" +
                " values (@Nombre,@NombreEmpresa,@Detalles,@IdDocumento,@Contacto,@CorreoElectronico,@Direccion,@NumeroTelefono);";
            // Se crea un comando SQL que se usará para ejecutar la consulta
            SqlCommand insertar = new SqlCommand(consultaQueryInsertar, conexion);
            // Se añaden los parámetros necesarios para la consulta SQL
            insertar.Parameters.AddWithValue("@Nombre", nombre);
            insertar.Parameters.AddWithValue("@NombreEmpresa", nombreEmpresa);
            insertar.Parameters.AddWithValue("@Detalles", detalles);
            insertar.Parameters.AddWithValue("@IdDocumento", IdDocumento);
            insertar.Parameters.AddWithValue("@Contacto", contacto);
            insertar.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
            insertar.Parameters.AddWithValue("@Direccion", direccion);
            insertar.Parameters.AddWithValue("@NumeroTelefono", numeroTelefono);
                insertar.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar el Cliente" + ex.Message, "Error al insertar datos",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
