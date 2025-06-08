using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace ProyectoIntegrador.Programa.Acciones.Productos
{
    public partial class AñadirPedido : Form
    {
        public AñadirPedido()
        {
            InitializeComponent();
            ConfigurarAutoCompletarProductos();
            ConfigurarAutoCompletarUsuarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos productos = new Productos();
            productos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Leer y validar campos
            string cliente = textNombredelcliente.Text.Trim();
            string producto = textNombredelproducto.Text.Trim();
            string cantidadStr = textCantidad.Text.Trim();
            string detalles = textDetalles.Text.Trim();
            string status = textStatus.Text.Trim();

            if (string.IsNullOrEmpty(cliente) || string.IsNullOrEmpty(producto) ||
                string.IsNullOrEmpty(cantidadStr) || string.IsNullOrEmpty(detalles) || string.IsNullOrEmpty(status))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(cantidadStr, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener ID de producto
            var conexion = new global::ConexionMySQL();
            int idProducto = conexion.obtenerIdProducto(producto);

            if (idProducto == -1)
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Añadir pedido
            conexion.AñadirPedido(cliente, idProducto, cantidad, detalles, status);
            MessageBox.Show("Pedido añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Regresar al listado de pedidos
            this.Hide();
            Pedidos registro = new Pedidos();
            registro.Show();
        }

        private void ConfigurarAutoCompletarProductos()
        {
            ConexionMySQL conexion = new ConexionMySQL();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            try
            {
                MySqlConnection conn = conexion.establecerConexion();
                string query = "SELECT nombre FROM productos";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    coleccion.Add(reader.GetString("nombre"));
                }

                textNombredelproducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textNombredelproducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textNombredelproducto.AutoCompleteCustomSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        private void ConfigurarAutoCompletarUsuarios()
        {
            ConexionMySQL conexion = new ConexionMySQL();
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            try
            {
                MySqlConnection conn = conexion.establecerConexion();
                string query = "SELECT nombre FROM usuarios";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    coleccion.Add(reader.GetString("nombre"));
                }

                textNombredelcliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textNombredelcliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textNombredelcliente.AutoCompleteCustomSource = coleccion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
            finally
            {
                conexion.cerrarConexion();
            }
        }

        // Manejo de eventos vacíos si no se usan
        private void textNombredelcliente_TextChanged(object sender, EventArgs e) { }
        private void textNombredelproducto_TextChanged(object sender, EventArgs e) { }
        private void textCantidad_TextChanged(object sender, EventArgs e) { }
        private void textDetalles_TextChanged(object sender, EventArgs e) { }
        private void textStatus_TextChanged(object sender, EventArgs e) { }
    }
}
