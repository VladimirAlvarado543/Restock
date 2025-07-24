using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Conexion;

namespace Modelo.Entidades
{
    public class Proveedor
    {
        // Declarar las variables privadas que representan los campos de la tabla Proveedor
        private int IDProveedor;
        private string IDDocumento;
        private string Contacto1;
        private string Contacto2;
        private string WhatsApp;
        private string PaginaWeb;
        private string Nombre;
        private string nombreempresa;
        private string detalles;
        private string CorreoElectronico;
        private string Direccion;
        private string Productos;

        public int IDProveedor1 { get => IDProveedor; set => IDProveedor = value; }
        public string IDDocumento1 { get => IDDocumento; set => IDDocumento = value; }
        public string Contacto11 { get => Contacto1; set => Contacto1 = value; }
        public string Contacto21 { get => Contacto2; set => Contacto2 = value; }
        public string WhatsApp1 { get => WhatsApp; set => WhatsApp = value; }
        public string PaginaWeb1 { get => PaginaWeb; set => PaginaWeb = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Nombreempresa { get => nombreempresa; set => nombreempresa = value; }
        public string Detalles { get => detalles; set => detalles = value; }
        public string CorreoElectronico1 { get => CorreoElectronico; set => CorreoElectronico = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Productos1 { get => Productos; set => Productos = value; }



        public bool InsertarProveedor()
        {
            //
            SqlConnection conexion = ConexionDB.Conectar();

            //Realizar la consulta
            string comand = "Insert into Proveedor(nombre,nombreEmpresa,detalles,producto,idDocumento,correoElectronico,direccion,numeroTelefono,paginaWeb,contactoAdicional,contactoAdicionalDos)"
                + "values(@Nombre, @NombreEmpresa, @Detalles, @Producto, @IdDocumento, @CorreoElectronico, @Direccion, @NumeroTelefono, @PaginaWeb, @Contacto1, @Contacto2);";

            //declarar ek sql command
            SqlCommand cmd = new SqlCommand(comand, conexion);
            // Agregar los parámetros necesarios para la consulta
            cmd.Parameters.AddWithValue("@Nombre", Nombre1);
            cmd.Parameters.AddWithValue("@NombreEmpresa", Nombreempresa);
            cmd.Parameters.AddWithValue("@Detalles", Detalles);
            cmd.Parameters.AddWithValue("@Producto", Productos1);
            cmd.Parameters.AddWithValue("@IdDocumento", IDDocumento1);
            cmd.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico1);
            cmd.Parameters.AddWithValue("@Direccion", Direccion1);
            cmd.Parameters.AddWithValue("@NumeroTelefono", WhatsApp1);
            cmd.Parameters.AddWithValue("@PaginaWeb", PaginaWeb);
            cmd.Parameters.AddWithValue("@Contacto1", Contacto11);
            cmd.Parameters.AddWithValue("@Contacto2", Contacto21);



            if (cmd.ExecuteNonQuery() > 0)
            {
                //Si la consulta se ejecuta correctamente y afecta a una o más filas, se retorna true
                return true;
            }
            else
            {
                // Si no se afecta ninguna fila, se retorna false
                return false;
            }
        }

        public static DataTable ObtenerProveedor(string nombre, int id)
        {
            using (SqlConnection con = ConexionDB.Conectar())
            {
                // Se define una consulta SQL que selecciona varios campos de la tabla Producto y sus relaciones
                string consulta = "SELECT *from Proveedor WHERE 1=1";

                // Se agrega una condición para filtrar los resultados según el nombre del producto y el ID
                if (!string.IsNullOrWhiteSpace(nombre))
                    // Si el nombre no está vacío, se agrega una condición a la consulta SQL
                    consulta += " AND (nombre LIKE @nombre)";
                // Si el ID es mayor que 0, se agrega una condición para filtrar por ID
                if (id > 0)
                    consulta += " AND idProveedor = @id";

                // Se crea un comando SQL que se usará para ejecutar la consulta
                using (SqlCommand cmd = new SqlCommand(consulta, con))
                {
                    if (!string.IsNullOrWhiteSpace(nombre))
                        // Si el nombre no está vacío, se agrega como parámetro al comando SQL
                        cmd.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
                    // Si el ID es mayor que 0, se agrega como parámetro al comando SQL
                    if (id > 0)
                        cmd.Parameters.AddWithValue("@id", id);

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
    }
}
