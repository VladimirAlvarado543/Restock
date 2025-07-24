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
    public class Producto
    {
        //declarar las variables privadas que representan los campos de la tabla Producto
        private int idProducto;
        private string nombreProducto;
        private string detalles;
        private int idCategoria;
        private int idMarca;
        private int existencia;
        private double precioCompra;
        private DateTime fechaIngreso;
        private double precioVenta;
        private int idProveedor;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public string Detalles { get => detalles; set => detalles = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public int Existencia { get => existencia; set => existencia = value; }
        public double PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }

        public static DataTable ObtenerProducto(string nombre, int id)
        {
            using (SqlConnection con = ConexionDB.Conectar())
            {
                // Se define una consulta SQL que selecciona varios campos de la tabla Producto y sus relaciones
                string consulta = "SELECT idProducto, nombreProducto, P.detalles, C.nombreCategoria AS Categoria," +
                    " NM.nombreMarca AS Marca,\r\nPR.nombre AS Proveedor, existencia, precioCompra, fechaIngreso," +
                    " precioVenta\r\nFROM Producto P INNER JOIN Categoria C ON P.idCategoria = C.idCategoria" +
                    " \r\nINNER JOIN Marca NM ON P.idMarca = NM.idMarca\r\nINNER JOIN Proveedor PR ON" +
                    " P.idProveedor = PR.idProveedor;\r\nselect *from Producto WHERE 1=1";

                // Se agrega una condición para filtrar los resultados según el nombre del producto y el ID
                if (!string.IsNullOrWhiteSpace(nombre))
                    // Si el nombre no está vacío, se agrega una condición a la consulta SQL
                    consulta += " AND (nombreProducto LIKE @nombre)";
                // Si el ID es mayor que 0, se agrega una condición para filtrar por ID
                if (id > 0)
                    consulta += " AND idProducto = @id";

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
        public bool InsertarProductos()
        {
            
            SqlConnection conexion = ConexionDB.Conectar();
            // Realizar la consulta
            string consultaQueryInsertar = " insert into Producto(nombreProducto, detalles, idCategoria, idMarca, existencia, precioCompra, fechaIngreso, precioVenta, idProveedor)" +
                " values (@NombreProducto,@Detalles,@IdDocumento,@IdMarca,@IdCategoria,@Existencia,@PrecioCompra,@FechaIngreso,@PrecioVenta,@IdProveedor);";
            // Se crea un comando SQL que se usará para ejecutar la consulta
            SqlCommand insertar = new SqlCommand(consultaQueryInsertar, conexion);
            // Agregar los parámetros necesarios para la consulta
            insertar.Parameters.AddWithValue("@NombreProducto", nombreProducto);
            insertar.Parameters.AddWithValue("@Detalles", detalles);
            insertar.Parameters.AddWithValue("@IdCategoria", idCategoria);
            insertar.Parameters.AddWithValue("@IdMarca", idMarca);
            insertar.Parameters.AddWithValue("@Existencia", existencia);
            insertar.Parameters.AddWithValue("@PrecioCompra", precioCompra);
            insertar.Parameters.AddWithValue("@FechaIngreso", fechaIngreso);
            insertar.Parameters.AddWithValue("@NumeroTelefono", precioVenta);
            insertar.Parameters.AddWithValue("@NumeroTelefono", idProveedor);

            if (insertar.ExecuteNonQuery() > 0)
            {
                //Si la consulta se ejecuta correctamente y se insertan filas, se retorna true
                return true;
            }
            else
            {
                // Si la consulta no se ejecuta correctamente, retornar false
                return false;
            }
        }
    }
}
