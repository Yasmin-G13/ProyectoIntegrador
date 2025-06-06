//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System;
//using System.Data;
//using System.Windows.Forms;

//namespace ProyectoIntegrador.Programa.Acciones.Productos
//{
//    public partial class ModificarProductos : Form
//    {
//        private int idProductoSeleccionado;
//        private ConexionMySQL conexion = new ConexionMySQL();

//        public ModificarProductos(int idProducto)
//        {
//            InitializeComponent();
//            idProductoSeleccionado = idProducto;
//            CargarDatosProducto(idProducto);
//        }
//        private void CargarDatosProducto(int idProducto)
//        {
//            try
//            {
//                MySqlConnection conn = conexion.establecerConexion();
//                string query = "SELECT * FROM productos WHERE id_producto = @id";
//                MySqlCommand cmd = new MySqlCommand(query, conn);
//                cmd.Parameters.AddWithValue("@id", idProducto);

//                using (MySqlDataReader reader = cmd.ExecuteReader())
//                {
//                    if (reader.Read())
//                    {
//                        textNombre.Text = reader["nombre"].ToString();
//                        textCantidad.Text = reader["cantidad"].ToString();
//                        textPrecio.Text = reader["precio"].ToString();
//                        textCategoria.Text = reader["categoria"].ToString();
//                        textDetalles.Text = reader["detalles"].ToString();
//                    }
//                }
//                conexion.cerrarConexion();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error al cargar los datos del producto: " + ex.Message);
//            }
//        }

//        private void btnGuardar_Click(object sender, EventArgs e)
//        {
//            if (ValidarCampos())
//            {
//                string nombre = textNombre.Text;
//                string cantidad = textCantidad.Text;
//                decimal precio = decimal.Parse(textPrecio.Text);
//                string categoria = textCategoria.Text;
//                string detalles = textDetalles.Text;
//                MessageBox.Show("ID del producto que se va a modificar: " + idProductoSeleccionado);
//                conexion.ModificarProductos(idProductoSeleccionado, nombre, cantidad, precio, categoria, detalles);

//                // Opcional: volver al formulario principal
//                Productos productosForm = new Productos();
//                productosForm.Show();
//                this.Close();
//            }
//        }

//        private bool ValidarCampos()
//        {
//            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
//                string.IsNullOrWhiteSpace(textCantidad.Text) ||
//                string.IsNullOrWhiteSpace(textPrecio.Text) ||
//                string.IsNullOrWhiteSpace(textCategoria.Text) ||
//                string.IsNullOrWhiteSpace(textDetalles.Text))
//            {
//                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return false;
//            }
//            if (!decimal.TryParse(textPrecio.Text, out _))
//            {
//                MessageBox.Show("El precio debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                return false;
//            }

//            return true;
//        }

//        private void btnRegresar_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            Productos productos = new Productos();
//            productos.Show();
//        }
//    }

//}
using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector; // Muy importante si usas MySqlConnector

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    public partial class ModificarProductos : Form
    {
        private int idProductoSeleccionado;
        private ConexionMySQL conexion = new ConexionMySQL();

        public ModificarProductos(int idProducto)
        {
            InitializeComponent();

            idProductoSeleccionado = idProducto;
            CargarDatosProducto(idProducto);
        }

        private void CargarDatosProducto(int idProducto)
        {
            try
            {
                var conn = conexion.establecerConexion();
                string query = "SELECT * FROM productos WHERE id_producto = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idProducto);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textNombre.Text = reader["nombre"].ToString();
                        textCantidad.Text = reader["cantidad"].ToString();
                        textPrecio.Text = reader["precio"].ToString();
                        textCategoria.Text = reader["categoria"].ToString();
                        textDetalles.Text = reader["detalles"].ToString();
                    }
                }

                conexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del producto: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string nombre = textNombre.Text;
                string cantidad = textCantidad.Text;
                decimal precio = decimal.Parse(textPrecio.Text);
                string categoria = textCategoria.Text;
                string detalles = textDetalles.Text;

                conexion.ModificarProductos(idProductoSeleccionado, nombre, cantidad, precio, categoria, detalles);

                MessageBox.Show("Producto modificado correctamente");

                // Regresar al formulario de productos
                Productos productosForm = new Productos();
                productosForm.Show();
                this.Close();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textCantidad.Text) ||
                string.IsNullOrWhiteSpace(textPrecio.Text) ||
                string.IsNullOrWhiteSpace(textCategoria.Text) ||
                string.IsNullOrWhiteSpace(textDetalles.Text))
            {
                MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!decimal.TryParse(textPrecio.Text, out _))
            {
                MessageBox.Show("El precio debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos productosForm = new Productos();
            productosForm.Show();
        }
    }
}
