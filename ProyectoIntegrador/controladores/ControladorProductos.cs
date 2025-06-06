//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using ProyectoIntegrador;
using ProyectoIntegrador.Programa.Acciones.Productos;

namespace ProyectoIntegrador.controladores
{
    internal class ControladorProductos
    {
        public void consultarProductos (DataGridView dgProductos)
        {
            ConexionMySQL conexion = new ConexionMySQL();
            Programa.modelos.ModelosProductos objetoProductos = new Programa.modelos.ModelosProductos();
            DataTable dtProducto = new DataTable();
            dtProducto.Columns.Add("id_produc", typeof(int));
            dtProducto.Columns.Add("Nombre", typeof(string));
            dtProducto.Columns.Add("Cantidad", typeof(string));
            dtProducto.Columns.Add("Precio", typeof(decimal));  // Mejor usar decimal
            dtProducto.Columns.Add("Descripcion", typeof(string));
            dtProducto.Columns.Add("Detalles", typeof(string));

            // Consulta SQL
            string sql = @"SELECT p.id_producto, p.nombre, p.categoria, p.detalles, p.precio, p.cantidad FROM productos p";

            try
            {
                MySqlConnection sqlConnection = conexion.establecerConexion();
                MySqlCommand sqlCommand = new MySqlCommand(sql, sqlConnection);
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);

                DataSet dt = new DataSet();
                sqlDataAdapter.Fill(dt);

                DataTable dtDatos = dt.Tables[0];

                foreach (DataRow row in dtDatos.Rows)
                {
                    Programa.modelos.ModelosProductos objetoProducto = new Programa.modelos.ModelosProductos();

                    objetoProducto.id_produc = Convert.ToInt32(row["id_producto"]);
                    objetoProducto.Nombre = row["nombre"].ToString();
                    objetoProducto.Cantidad = row["cantidad"].ToString();
                    objetoProducto.Precio = Convert.ToDecimal(row["precio"]);
                    objetoProducto.Descripcion = row["categoria"].ToString();
                    objetoProducto.Detalles = row["detalles"].ToString();

                    // Agregar fila al DataTable
                    dtProducto.Rows.Add(objetoProducto.id_produc,
                                        objetoProducto.Nombre,
                                        objetoProducto.Cantidad,
                                        objetoProducto.Precio,
                                        objetoProducto.Descripcion,
                                        objetoProducto.Detalles);
                }

                dgProductos.DataSource = dtProducto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar los productos: " + ex.Message);  // Mensaje corregido
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.cerrarConexion();
                }
            }

        }
        public void DarBaja (int id_producto)
        {
            ConexionMySQL conexion = new ConexionMySQL();
            string sql = @"DELETE FROM productos WHERE id_producto = @id";
            try
            {
                MySqlConnection sqlConexion = conexion.establecerConexion();
                MySqlCommand comando = new MySqlCommand(sql, sqlConexion);
                comando.Parameters.AddWithValue("@id", id_producto);
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto eliminado correctamente.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al eliminar el producto: " + e.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
