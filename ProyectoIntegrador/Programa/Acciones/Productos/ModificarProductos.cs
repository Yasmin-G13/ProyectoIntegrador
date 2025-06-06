using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    public partial class ModificarProductos : Form
    {
        // Variable para guardar el ID del producto seleccionado
        private int idProductoSeleccionado = -1;

        public ModificarProductos()
        {
            InitializeComponent();
            CargarProductos(); // Cargar productos al abrir el formulario
        }

        // Método para cargar los productos en el DataGridView
        private void CargarProductos()
        {
            string cadenaConexion = $"Server=localhost;Port=3306;Database=nyas;Uid=root;Pwd=tics";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
                {
                    string query = "SELECT ID, Nombre, Cantidad, Precio, Categoria, Detalles FROM productos";
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dataGridViewProductos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        // Al hacer clic en una fila del DataGridView
        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProductos.Rows[e.RowIndex];

                // Asignar el ID y mostrar los datos en los TextBox
                idProductoSeleccionado = Convert.ToInt32(row.Cells["ID"].Value);
                textNombre.Text = row.Cells["Nombre"].Value.ToString();
                textCantidad.Text = row.Cells["Cantidad"].Value.ToString();
                textPrecio.Text = row.Cells["Precio"].Value.ToString();
                textCategoria.Text = row.Cells["Categoria"].Value.ToString();
                textDetalles.Text = row.Cells["Detalles"].Value.ToString();
            }
        }

        // Botón para modificar y guardar cambios
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == -1)
            {
                MessageBox.Show("Por favor, selecciona un producto primero.");
                return;
            }

            // Obtener datos de los TextBox
            string nombre = textNombre.Text.Trim();
            string cantidad = textCantidad.Text.Trim();
            string precioStr = textPrecio.Text.Trim();
            string categoria = textCategoria.Text.Trim();
            string detalles = textDetalles.Text.Trim();

            // Validar campos vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(cantidad) ||
                string.IsNullOrEmpty(precioStr) || string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Validar que precio sea decimal
            if (!decimal.TryParse(precioStr, out decimal precio))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            // Crear instancia y llamar método para actualizar
            ConexionMySQL conexion = new ConexionMySQL();
            conexion.ModificarProducto(idProductoSeleccionado, nombre, cantidad, precio, categoria, detalles);

            // Recargar productos para reflejar cambios
            CargarProductos();

            // Opcional: limpiar controles
            textNombre.Clear();
            textCantidad.Clear();
            textPrecio.Clear();
            textCategoria.Clear();
            textDetalles.Clear();
            idProductoSeleccionado = -1;

            MessageBox.Show("Producto actualizado correctamente.");
        }
        public class ProductoHelper
        {
            public static DataTable ObtenerProductos(string cadenaConexion)
            {
                string consulta = "SELECT * FROM productos";
                DataTable dt = new DataTable();

                try
                {
                    using (MySqlConnection cargar = new MySqlConnection(cadenaConexion))
                    using (MySqlDataAdapter sda = new MySqlDataAdapter(consulta, cargar))
                    {
                        sda.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
                }

                return dt;
            }

         

            public void MostrarProductos(DataGridView dataGridViewProductos)
            {
                

                string consulta = "SELECT * FROM productos";



                try
                {
                    MySqlConnection conexion = new ConexionMySQL.establecerConexion();


                    using (MySqlConnection cargar = new MySqlConnection(consulta))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(consulta, cargar))
                        {GridItem
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            dataGridViewProductos.DataSource = dt; // tu DataGridView
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar los datos: " + ex.Message);
                }
            }
            private void ModificarProducto_load(object sender, EventArgs e)
            {
                MostrarProductos(GetDataGridViewProductos()); // Aquí llama a tu método que carga en la vista
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos productos = new Productos();
            productos.Show();
        }
    }

}